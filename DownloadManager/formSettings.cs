using System;
using System.Windows.Forms;

namespace DownloadManager
{
    public partial class formSettings : Form
    {
        public formSettings()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path."})
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    txtPath.Text = fbd.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                Properties.Settings.Default.Path = txtPath.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
                MessageBox.Show("Please select your path.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}