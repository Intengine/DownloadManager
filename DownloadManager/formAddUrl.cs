using System;
using System.Windows.Forms;

namespace DownloadManager
{
    public partial class formAddUrl : Form
    {
        public formAddUrl()
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