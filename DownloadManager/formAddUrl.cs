using System;
using System.Windows.Forms;

namespace DownloadManager
{
    public partial class FormAddUrl : Form
    {
        public FormAddUrl()
        {
            InitializeComponent();
        }

        public string Url { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Url = txtUrl.Text;
        }
    }
}