using System;
using System.IO;
using System.Windows.Forms;

namespace DownloadManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void tsSettings_Click(object sender, EventArgs e)
        {
            using (FormSettings form = new FormSettings())
            {
                form.ShowDialog();
            }
        }

        private void tsLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://intengine.beskidy.pl");
        }

        private void tsAddUrl_Click(object sender, EventArgs e)
        {
            using(FormAddUrl form = new FormAddUrl())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    FormDownload formDownload = new FormDownload(this);
                    formDownload.Url = form.Url;
                    formDownload.Show();
                }
            }
        }

        private void tsRemove_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for(int i = listView1.SelectedItems.Count; i > 0; i--)
                {
                    ListViewItem item = listView1.SelectedItems[i - 1];
                    App.DB.Files.Rows[item.Index].Delete();
                    listView1.Items[item.Index].Remove();
                }
                App.DB.AcceptChanges();
                App.DB.WriteXml(string.Format("{0}/data.dat", Application.StartupPath));
            }
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            string fileName = string.Format("{0}/data.dat", Application.StartupPath);

            if(File.Exists(fileName))
            {
                App.DB.ReadXml(fileName);
            }

            foreach(Database.FilesRow row in App.DB.Files)
            {
                ListViewItem item = new ListViewItem(row.ID.ToString());
                item.SubItems.Add(row.URL);
                item.SubItems.Add(row.FileName);
                item.SubItems.Add(row.FileSize);
                item.SubItems.Add(row.DateTime.ToLongDateString());
                listView1.Items.Add(item);
            }
        }
    }
}
