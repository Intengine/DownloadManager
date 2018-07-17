using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace DownloadManager
{
    public partial class formDownload : Form
    {
        public formDownload(formMain frm)
        {
            InitializeComponent();
            _frmMain = frm;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(this.Url);
            FileName = System.IO.Path.GetFileName(uri.AbsolutePath);
            client.DownloadFileAsync(uri, Properties.Settings.Default.Path + "/" + FileName);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            client.CancelAsync();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                    Properties.Settings.Default.Path = txtPath.Text;
                    Properties.Settings.Default.Save();
                }
            }
        }

        WebClient client;

        private formMain _frmMain;

        public string Url { get; set; }
        public string FileName { get; set; }
        public double FileSize { get; set; }
        public double Percentage { get; set; }

        private void formDownload_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            txtAddress.Text = Url;
            txtPath.Text = Properties.Settings.Default.Path;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Database.FilesRow row = App.DB.Files.NewFilesRow();

            row.URL = Url;
            row.FileName = FileName;
            row.FileSize = (string.Format("{0:0.##} kb", FileSize / 1024));
            row.DateTime = DateTime.Now;

            App.DB.Files.AddFilesRow(row);
            App.DB.AcceptChanges();
            App.DB.WriteXml(string.Format("{0}/data.dat", Application.StartupPath));

            ListViewItem item = new ListViewItem(row.ID.ToString());
            item.SubItems.Add(row.URL);
            item.SubItems.Add(row.FileName);
            item.SubItems.Add(row.FileSize);
            item.SubItems.Add(row.DateTime.ToLongDateString());

            _frmMain.listView1.Items.Add(item);

            this.Close();
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            double recieve = double.Parse(e.BytesReceived.ToString());
            FileSize = double.Parse(e.TotalBytesToReceive.ToString());
            Percentage = recieve / FileSize * 100;
            labelStatus.Text = $"Downloaded {string.Format("{0:0.##}", Percentage)}";
            progressBar.Value = int.Parse(Math.Truncate(Percentage).ToString());
            progressBar.Update();
        }
    }
}