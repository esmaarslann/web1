namespace HastaneOtomasyon
{
    partial class frmTahlilTanimlama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTahlilTanimlama));
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabKlinikler = new System.Windows.Forms.TabControl();
            this.tsbtnEkle = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDuzenle = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSil = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRapor = new System.Windows.Forms.ToolStripButton();
            this.tsbtnKapat = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabKlinikler.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnEkle,
            this.toolStripSeparator1,
            this.tsbtnDuzenle,
            this.toolStripSeparator2,
            this.tsbtnSil,
            this.toolStripSeparator3,
            this.tsbtnRapor,
            this.toolStripSeparator4,
            this.tsbtnKapat,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(721, 37);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Açıklama";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 419;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ünvan Adı";
            this.columnHeader2.Width = 114;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Unvan No";
            this.columnHeader1.Width = 78;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Khaki;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(707, 397);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unvanlar";
            // 
            // tabKlinikler
            // 
            this.tabKlinikler.Controls.Add(this.tabPage1);
            this.tabKlinikler.Location = new System.Drawing.Point(0, 40);
            this.tabKlinikler.Name = "tabKlinikler";
            this.tabKlinikler.SelectedIndex = 0;
            this.tabKlinikler.Size = new System.Drawing.Size(721, 429);
            this.tabKlinikler.TabIndex = 5;
            // 
            // tsbtnEkle
            // 
            this.tsbtnEkle.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEkle.Image")));
            this.tsbtnEkle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEkle.Name = "tsbtnEkle";
            this.tsbtnEkle.Size = new System.Drawing.Size(62, 34);
            this.tsbtnEkle.Text = "Ekle";
            // 
            // tsbtnDuzenle
            // 
            this.tsbtnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDuzenle.Image")));
            this.tsbtnDuzenle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDuzenle.Name = "tsbtnDuzenle";
            this.tsbtnDuzenle.Size = new System.Drawing.Size(83, 34);
            this.tsbtnDuzenle.Text = "Düzenle";
            this.tsbtnDuzenle.Click += new System.EventHandler(this.tsbtnDuzenle_Click);
            // 
            // tsbtnSil
            // 
            this.tsbtnSil.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSil.Image")));
            this.tsbtnSil.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSil.Name = "tsbtnSil";
            this.tsbtnSil.Size = new System.Drawing.Size(53, 34);
            this.tsbtnSil.Text = "Sil";
            this.tsbtnSil.Click += new System.EventHandler(this.tsbtnSil_Click);
            // 
            // tsbtnRapor
            // 
            this.tsbtnRapor.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRapor.Image")));
            this.tsbtnRapor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnRapor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRapor.Name = "tsbtnRapor";
            this.tsbtnRapor.Size = new System.Drawing.Size(72, 34);
            this.tsbtnRapor.Text = "Rapor";
            // 
            // tsbtnKapat
            // 
            this.tsbtnKapat.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnKapat.Image")));
            this.tsbtnKapat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnKapat.Name = "tsbtnKapat";
            this.tsbtnKapat.Size = new System.Drawing.Size(71, 34);
            this.tsbtnKapat.Text = "Kapat";
            // 
            // frmTahlilTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 530);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabKlinikler);
            this.Name = "frmTahlilTanimlama";
            this.Text = "Ünvan Tanimlama";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabKlinikler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnRapor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnDuzenle;
        private System.Windows.Forms.ToolStripButton tsbtnKapat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnEkle;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabKlinikler;
    }
}