using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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