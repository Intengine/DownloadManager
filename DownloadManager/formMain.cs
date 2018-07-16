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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void tsSettings_Click(object sender, EventArgs e)
        {
            using (formSettings frm = new formSettings())
            {
                frm.ShowDialog();
            }
        }
    }
}