namespace DownloadManager
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAddUrl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsLogo = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddUrl,
            this.toolStripSeparator1,
            this.tsRemove,
            this.toolStripSeparator3,
            this.tsSettings,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(822, 80);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsAddUrl
            // 
            this.tsAddUrl.AutoSize = false;
            this.tsAddUrl.Image = global::DownloadManager.Properties.Resources.iconAddUrl;
            this.tsAddUrl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAddUrl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddUrl.Name = "tsAddUrl";
            this.tsAddUrl.Size = new System.Drawing.Size(75, 75);
            this.tsAddUrl.Text = "Add URL";
            this.tsAddUrl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsAddUrl.Click += new System.EventHandler(this.tsAddUrl_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 80);
            // 
            // tsRemove
            // 
            this.tsRemove.AutoSize = false;
            this.tsRemove.Image = global::DownloadManager.Properties.Resources.iconRemove;
            this.tsRemove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRemove.Name = "tsRemove";
            this.tsRemove.Size = new System.Drawing.Size(75, 75);
            this.tsRemove.Text = "Remove";
            this.tsRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsRemove.Click += new System.EventHandler(this.tsRemove_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 80);
            // 
            // tsSettings
            // 
            this.tsSettings.AutoSize = false;
            this.tsSettings.Image = global::DownloadManager.Properties.Resources.iconSettings;
            this.tsSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSettings.Name = "tsSettings";
            this.tsSettings.Size = new System.Drawing.Size(75, 75);
            this.tsSettings.Text = "Settings";
            this.tsSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsSettings.Click += new System.EventHandler(this.tsSettings_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 80);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(822, 370);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 37;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "URL";
            this.columnHeader2.Width = 432;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File Name";
            this.columnHeader3.Width = 147;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            this.columnHeader4.Width = 74;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date Time";
            this.columnHeader5.Width = 120;
            // 
            // tsLogo
            // 
            this.tsLogo.BackColor = System.Drawing.Color.Transparent;
            this.tsLogo.Image = global::DownloadManager.Properties.Resources.logo;
            this.tsLogo.Location = new System.Drawing.Point(262, 0);
            this.tsLogo.Name = "tsLogo";
            this.tsLogo.Size = new System.Drawing.Size(548, 80);
            this.tsLogo.TabIndex = 2;
            this.tsLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tsLogo.UseVisualStyleBackColor = false;
            this.tsLogo.Click += new System.EventHandler(this.tsLogo_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.tsLogo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "formMain";
            this.Text = "DownloadManager";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton tsAddUrl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsSettings;
        private System.Windows.Forms.Button tsLogo;
    }
}

