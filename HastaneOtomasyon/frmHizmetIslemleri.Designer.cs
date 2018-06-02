namespace HastaneOtomasyon
{
    partial class frmHizmetIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHizmetIslemleri));
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHizmetAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHizmetID = new System.Windows.Forms.TextBox();
            this.lblHizmetID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnDuzenle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnKapat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtKlinikNo = new System.Windows.Forms.TextBox();
            this.cbKlinikAdlari = new System.Windows.Forms.ComboBox();
            this.txtKlinikAd = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUcret
            // 
            this.txtUcret.BackColor = System.Drawing.Color.Wheat;
            this.txtUcret.Location = new System.Drawing.Point(156, 182);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(159, 20);
            this.txtUcret.TabIndex = 28;
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.Wheat;
            this.txtAciklama.Location = new System.Drawing.Point(156, 210);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(159, 110);
            this.txtAciklama.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ücret";
            // 
            // txtHizmetAd
            // 
            this.txtHizmetAd.BackColor = System.Drawing.Color.Wheat;
            this.txtHizmetAd.Location = new System.Drawing.Point(156, 130);
            this.txtHizmetAd.Name = "txtHizmetAd";
            this.txtHizmetAd.Size = new System.Drawing.Size(159, 20);
            this.txtHizmetAd.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hizmet Adi=Ameliyat";
            // 
            // txtHizmetID
            // 
            this.txtHizmetID.BackColor = System.Drawing.Color.Wheat;
            this.txtHizmetID.Location = new System.Drawing.Point(156, 58);
            this.txtHizmetID.Name = "txtHizmetID";
            this.txtHizmetID.ReadOnly = true;
            this.txtHizmetID.Size = new System.Drawing.Size(159, 20);
            this.txtHizmetID.TabIndex = 22;
            // 
            // lblHizmetID
            // 
            this.lblHizmetID.AutoSize = true;
            this.lblHizmetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHizmetID.Location = new System.Drawing.Point(35, 59);
            this.lblHizmetID.Name = "lblHizmetID";
            this.lblHizmetID.Size = new System.Drawing.Size(74, 15);
            this.lblHizmetID.TabIndex = 21;
            this.lblHizmetID.Text = "Hizmet No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Klinik Adı";
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(377, 37);
            this.toolStrip1.TabIndex = 31;
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
            this.tsbtnDuzenle.Click += new System.EventHandler(this.tsbtnDuzenle_Click);
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
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 37);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(377, 3);
            this.splitter1.TabIndex = 32;
            this.splitter1.TabStop = false;
            // 
            // txtKlinikNo
            // 
            this.txtKlinikNo.Location = new System.Drawing.Point(321, 158);
            this.txtKlinikNo.Name = "txtKlinikNo";
            this.txtKlinikNo.Size = new System.Drawing.Size(20, 20);
            this.txtKlinikNo.TabIndex = 34;
            this.txtKlinikNo.Visible = false;
            // 
            // cbKlinikAdlari
            // 
            this.cbKlinikAdlari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKlinikAdlari.FormattingEnabled = true;
            this.cbKlinikAdlari.Location = new System.Drawing.Point(156, 157);
            this.cbKlinikAdlari.Name = "cbKlinikAdlari";
            this.cbKlinikAdlari.Size = new System.Drawing.Size(159, 21);
            this.cbKlinikAdlari.TabIndex = 35;
            this.cbKlinikAdlari.SelectedIndexChanged += new System.EventHandler(this.cbKlinikAdlari_SelectedIndexChanged);
            // 
            // txtKlinikAd
            // 
            this.txtKlinikAd.Location = new System.Drawing.Point(186, 104);
            this.txtKlinikAd.Name = "txtKlinikAd";
            this.txtKlinikAd.Size = new System.Drawing.Size(100, 20);
            this.txtKlinikAd.TabIndex = 36;
            this.txtKlinikAd.Visible = false;
            // 
            // frmHizmetIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(377, 365);
            this.Controls.Add(this.txtKlinikAd);
            this.Controls.Add(this.cbKlinikAdlari);
            this.Controls.Add(this.txtKlinikNo);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHizmetAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHizmetID);
            this.Controls.Add(this.lblHizmetID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHizmetIslemleri";
            this.Text = "Hizmet İşlemleri";
            this.Load += new System.EventHandler(this.frmHizmetIslemleri_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtUcret;
        public System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtHizmetAd;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtHizmetID;
        public System.Windows.Forms.Label lblHizmetID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsbtnEkle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton tsbtnDuzenle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton tsbtnKapat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.TextBox txtKlinikNo;
        public System.Windows.Forms.ComboBox cbKlinikAdlari;
        public System.Windows.Forms.TextBox txtKlinikAd;
    }
}