namespace HastaneOtomasyon
{
    partial class frmKlinikIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKlinikIslemleri));
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKlinikAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKlinikNo = new System.Windows.Forms.TextBox();
            this.lblKlinikNo = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtRandevuSure = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnDuzenle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnKapat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.Wheat;
            this.txtAciklama.Location = new System.Drawing.Point(144, 215);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(159, 110);
            this.txtAciklama.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(23, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Randevu Süresi";
            // 
            // txtKlinikAd
            // 
            this.txtKlinikAd.BackColor = System.Drawing.Color.Wheat;
            this.txtKlinikAd.Location = new System.Drawing.Point(144, 161);
            this.txtKlinikAd.Name = "txtKlinikAd";
            this.txtKlinikAd.Size = new System.Drawing.Size(159, 20);
            this.txtKlinikAd.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Klinik Adı";
            // 
            // txtKlinikNo
            // 
            this.txtKlinikNo.BackColor = System.Drawing.Color.Wheat;
            this.txtKlinikNo.Location = new System.Drawing.Point(144, 89);
            this.txtKlinikNo.Name = "txtKlinikNo";
            this.txtKlinikNo.ReadOnly = true;
            this.txtKlinikNo.Size = new System.Drawing.Size(159, 20);
            this.txtKlinikNo.TabIndex = 10;
            // 
            // lblKlinikNo
            // 
            this.lblKlinikNo.AutoSize = true;
            this.lblKlinikNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKlinikNo.Location = new System.Drawing.Point(23, 90);
            this.lblKlinikNo.Name = "lblKlinikNo";
            this.lblKlinikNo.Size = new System.Drawing.Size(65, 15);
            this.lblKlinikNo.TabIndex = 9;
            this.lblKlinikNo.Text = "Klinik No";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(354, 3);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // txtRandevuSure
            // 
            this.txtRandevuSure.BackColor = System.Drawing.Color.Wheat;
            this.txtRandevuSure.Location = new System.Drawing.Point(144, 187);
            this.txtRandevuSure.Name = "txtRandevuSure";
            this.txtRandevuSure.Size = new System.Drawing.Size(159, 20);
            this.txtRandevuSure.TabIndex = 20;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnEkle,
            this.toolStripSeparator1,
            this.tsbtnDuzenle,
            this.toolStripSeparator2,
            this.tsbtnKapat,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(354, 37);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnEkle
            // 
            this.tsbtnEkle.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEkle.Image")));
            this.tsbtnEkle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEkle.Name = "tsbtnEkle";
            this.tsbtnEkle.Size = new System.Drawing.Size(62, 34);
            this.tsbtnEkle.Text = "Ekle";
            this.tsbtnEkle.Click += new System.EventHandler(this.tsbtnEkle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbtnDuzenle
            // 
            this.tsbtnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDuzenle.Image")));
            this.tsbtnDuzenle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDuzenle.Name = "tsbtnDuzenle";
            this.tsbtnDuzenle.Size = new System.Drawing.Size(83, 34);
            this.tsbtnDuzenle.Text = "Düzenle";
            this.tsbtnDuzenle.Click += new System.EventHandler(this.tsbtnDuzenle_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbtnKapat
            // 
            this.tsbtnKapat.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnKapat.Image")));
            this.tsbtnKapat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnKapat.Name = "tsbtnKapat";
            this.tsbtnKapat.Size = new System.Drawing.Size(64, 34);
            this.tsbtnKapat.Text = "İptal";
            this.tsbtnKapat.Click += new System.EventHandler(this.tsbtnKapat_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 37);
            // 
            // frmKlinikIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(354, 348);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtRandevuSure);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKlinikAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKlinikNo);
            this.Controls.Add(this.lblKlinikNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKlinikIslemleri";
            this.Text = "Klinik Düzenle";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtAciklama;
        public System.Windows.Forms.TextBox txtKlinikAd;
        public System.Windows.Forms.TextBox txtKlinikNo;
        private System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.TextBox txtRandevuSure;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsbtnEkle;
        public System.Windows.Forms.ToolStripButton tsbtnKapat;
        public System.Windows.Forms.ToolStripButton tsbtnDuzenle;
        public System.Windows.Forms.Label lblKlinikNo;
    }
}