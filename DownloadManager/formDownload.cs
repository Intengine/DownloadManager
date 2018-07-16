using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
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

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        WebClient client;

        public string Url = { get; set; }
        public string FileName = { get; set; }
        public double FileSize = { get; set; }
        public double Percentage = { get; set; }

        private formMain _frmMain;

        private void formDownload_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            txtAddress.Text = Url;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}