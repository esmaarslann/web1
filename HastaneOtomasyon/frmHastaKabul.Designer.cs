namespace HastaneOtomasyon
{
    partial class frmHastaKabul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaKabul));
            this.txtKlinikID = new System.Windows.Forms.TextBox();
            this.txtHekimID = new System.Windows.Forms.TextBox();
            this.txtHastaID = new System.Windows.Forms.TextBox();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCinsiyet = new System.Windows.Forms.TextBox();
            this.btnRandevuVer = new System.Windows.Forms.Button();
            this.txtDogumTarihi = new System.Windows.Forms.TextBox();
            this.txtHastaSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHastaAd = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblPersonelAd = new System.Windows.Forms.ToolStripLabel();
            this.cbKlinikler = new System.Windows.Forms.ComboBox();
            this.cbHekimler = new System.Windows.Forms.ComboBox();
            this.gbxRandevu = new System.Windows.Forms.GroupBox();
            this.txtRandevuSaat = new System.Windows.Forms.TextBox();
            this.txtRandevuGün = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.gbxRandevu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKlinikID
            // 
            this.txtKlinikID.Location = new System.Drawing.Point(35, 227);
            this.txtKlinikID.Name = "txtKlinikID";
            this.txtKlinikID.Size = new System.Drawing.Size(32, 20);
            this.txtKlinikID.TabIndex = 167;
            this.txtKlinikID.Visible = false;
            // 
            // txtHekimID
            // 
            this.txtHekimID.Location = new System.Drawing.Point(35, 273);
            this.txtHekimID.Name = "txtHekimID";
            this.txtHekimID.Size = new System.Drawing.Size(32, 20);
            this.txtHekimID.TabIndex = 166;
            this.txtHekimID.Visible = false;
            // 
            // txtHastaID
            // 
            this.txtHastaID.Location = new System.Drawing.Point(24, 97);
            this.txtHastaID.Name = "txtHastaID";
            this.txtHastaID.Size = new System.Drawing.Size(32, 20);
            this.txtHastaID.TabIndex = 165;
            this.txtHastaID.Visible = false;
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Location = new System.Drawing.Point(172, 98);
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(100, 20);
            this.txtTcKimlikNo.TabIndex = 162;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(73, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 153;
            this.label9.Text = "Klinik:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(73, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 155;
            this.label10.Text = "Hekim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(73, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 156;
            this.label2.Text = "Hasta Soyad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(73, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 154;
            this.label8.Text = "Hasta Ad:";
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.Location = new System.Drawing.Point(172, 362);
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(100, 20);
            this.txtCinsiyet.TabIndex = 160;
            // 
            // btnRandevuVer
            // 
            this.btnRandevuVer.Location = new System.Drawing.Point(113, 442);
            this.btnRandevuVer.Name = "btnRandevuVer";
            this.btnRandevuVer.Size = new System.Drawing.Size(120, 23);
            this.btnRandevuVer.TabIndex = 159;
            this.btnRandevuVer.Text = "Randevu Ver";
            this.btnRandevuVer.UseVisualStyleBackColor = true;
            this.btnRandevuVer.Click += new System.EventHandler(this.btnRandevuVer_Click);
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.Location = new System.Drawing.Point(172, 312);
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtDogumTarihi.TabIndex = 157;
            // 
            // txtHastaSoyad
            // 
            this.txtHastaSoyad.Location = new System.Drawing.Point(172, 180);
            this.txtHastaSoyad.Name = "txtHastaSoyad";
            this.txtHastaSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtHastaSoyad.TabIndex = 152;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(73, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 150;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 149;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(73, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 148;
            this.label13.Text = "Cinsiyet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 147;
            this.label3.Text = "TC Kimlik No:";
            // 
            // txtHastaAd
            // 
            this.txtHastaAd.Location = new System.Drawing.Point(172, 146);
            this.txtHastaAd.Name = "txtHastaAd";
            this.txtHastaAd.Size = new System.Drawing.Size(100, 20);
            this.txtHastaAd.TabIndex = 151;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.tslblPersonelAd});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(846, 25);
            this.toolStrip1.TabIndex = 169;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(79, 22);
            this.toolStripLabel1.Text = "Personel Adı :";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslblPersonelAd
            // 
            this.tslblPersonelAd.Name = "tslblPersonelAd";
            this.tslblPersonelAd.Size = new System.Drawing.Size(86, 22);
            this.tslblPersonelAd.Text = "toolStripLabel2";
            // 
            // cbKlinikler
            // 
            this.cbKlinikler.FormattingEnabled = true;
            this.cbKlinikler.Location = new System.Drawing.Point(172, 225);
            this.cbKlinikler.Name = "cbKlinikler";
            this.cbKlinikler.Size = new System.Drawing.Size(100, 21);
            this.cbKlinikler.TabIndex = 170;
            this.cbKlinikler.SelectedIndexChanged += new System.EventHandler(this.cbKlinikler_SelectedIndexChanged);
            // 
            // cbHekimler
            // 
            this.cbHekimler.FormattingEnabled = true;
            this.cbHekimler.Location = new System.Drawing.Point(172, 269);
            this.cbHekimler.Name = "cbHekimler";
            this.cbHekimler.Size = new System.Drawing.Size(100, 21);
            this.cbHekimler.TabIndex = 171;
            // 
            // gbxRandevu
            // 
            this.gbxRandevu.Controls.Add(this.txtRandevuSaat);
            this.gbxRandevu.Controls.Add(this.txtRandevuGün);
            this.gbxRandevu.Controls.Add(this.label11);
            this.gbxRandevu.Controls.Add(this.label1);
            this.gbxRandevu.Location = new System.Drawing.Point(320, 146);
            this.gbxRandevu.Name = "gbxRandevu";
            this.gbxRandevu.Size = new System.Drawing.Size(500, 178);
            this.gbxRandevu.TabIndex = 173;
            this.gbxRandevu.TabStop = false;
            this.gbxRandevu.Text = "Randevu Bilgileri";
            // 
            // txtRandevuSaat
            // 
            this.txtRandevuSaat.Location = new System.Drawing.Point(185, 99);
            this.txtRandevuSaat.Name = "txtRandevuSaat";
            this.txtRandevuSaat.Size = new System.Drawing.Size(134, 20);
            this.txtRandevuSaat.TabIndex = 131;
            // 
            // txtRandevuGün
            // 
            this.txtRandevuGün.Location = new System.Drawing.Point(185, 51);
            this.txtRandevuGün.Name = "txtRandevuGün";
            this.txtRandevuGün.Size = new System.Drawing.Size(134, 20);
            this.txtRandevuGün.TabIndex = 130;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(48, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 127;
            this.label11.Text = "Randevu Saati";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 126;
            this.label1.Text = "Randevu Günü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 172;
            // 
            // frmHastaKabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(846, 493);
            this.Controls.Add(this.gbxRandevu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbHekimler);
            this.Controls.Add(this.cbKlinikler);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtKlinikID);
            this.Controls.Add(this.txtHekimID);
            this.Controls.Add(this.txtHastaID);
            this.Controls.Add(this.txtTcKimlikNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCinsiyet);
            this.Controls.Add(this.btnRandevuVer);
            this.Controls.Add(this.txtDogumTarihi);
            this.Controls.Add(this.txtHastaSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHastaAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHastaKabul";
            this.Text = "Hasta Kabul";
            this.Load += new System.EventHandler(this.frmHastaKabul_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbxRandevu.ResumeLayout(false);
            this.gbxRandevu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtKlinikID;
        public System.Windows.Forms.TextBox txtHekimID;
        public System.Windows.Forms.TextBox txtHastaID;
        public System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtCinsiyet;
        private System.Windows.Forms.Button btnRandevuVer;
        public System.Windows.Forms.TextBox txtDogumTarihi;
        public System.Windows.Forms.TextBox txtHastaSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtHastaAd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslblPersonelAd;
        public System.Windows.Forms.ComboBox cbKlinikler;
        public System.Windows.Forms.ComboBox cbHekimler;
        public System.Windows.Forms.GroupBox gbxRandevu;
        public System.Windows.Forms.TextBox txtRandevuSaat;
        public System.Windows.Forms.TextBox txtRandevuGün;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}