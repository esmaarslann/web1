namespace HastaneOtomasyon
{
    partial class frmRandevuIptal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRandevuIptal));
            this.label1 = new System.Windows.Forms.Label();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.txtHastaSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHekimler = new System.Windows.Forms.ComboBox();
            this.cbKlinikler = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbRandevuTarih = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRandevuSaat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRandevuIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Ad :";
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.BackColor = System.Drawing.Color.Khaki;
            this.txtHastaAdi.Location = new System.Drawing.Point(151, 85);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.ReadOnly = true;
            this.txtHastaAdi.Size = new System.Drawing.Size(136, 20);
            this.txtHastaAdi.TabIndex = 1;
            // 
            // txtHastaSoyadi
            // 
            this.txtHastaSoyadi.BackColor = System.Drawing.Color.Khaki;
            this.txtHastaSoyadi.Location = new System.Drawing.Point(151, 125);
            this.txtHastaSoyadi.Name = "txtHastaSoyadi";
            this.txtHastaSoyadi.ReadOnly = true;
            this.txtHastaSoyadi.Size = new System.Drawing.Size(136, 20);
            this.txtHastaSoyadi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta Soyad :";
            // 
            // cbHekimler
            // 
            this.cbHekimler.FormattingEnabled = true;
            this.cbHekimler.Location = new System.Drawing.Point(151, 215);
            this.cbHekimler.Name = "cbHekimler";
            this.cbHekimler.Size = new System.Drawing.Size(136, 21);
            this.cbHekimler.TabIndex = 175;
            this.cbHekimler.SelectedIndexChanged += new System.EventHandler(this.cbHekimler_SelectedIndexChanged);
            // 
            // cbKlinikler
            // 
            this.cbKlinikler.FormattingEnabled = true;
            this.cbKlinikler.Location = new System.Drawing.Point(151, 172);
            this.cbKlinikler.Name = "cbKlinikler";
            this.cbKlinikler.Size = new System.Drawing.Size(136, 21);
            this.cbKlinikler.TabIndex = 174;
            this.cbKlinikler.SelectedIndexChanged += new System.EventHandler(this.cbKlinikler_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(50, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 172;
            this.label9.Text = "Klinik:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(50, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 173;
            this.label10.Text = "Hekim:";
            // 
            // cbRandevuTarih
            // 
            this.cbRandevuTarih.FormattingEnabled = true;
            this.cbRandevuTarih.Location = new System.Drawing.Point(151, 258);
            this.cbRandevuTarih.Name = "cbRandevuTarih";
            this.cbRandevuTarih.Size = new System.Drawing.Size(136, 21);
            this.cbRandevuTarih.TabIndex = 177;
            this.cbRandevuTarih.SelectedIndexChanged += new System.EventHandler(this.cbRandevuTarih_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 176;
            this.label3.Text = "Tarih";
            // 
            // cbRandevuSaat
            // 
            this.cbRandevuSaat.FormattingEnabled = true;
            this.cbRandevuSaat.Location = new System.Drawing.Point(151, 299);
            this.cbRandevuSaat.Name = "cbRandevuSaat";
            this.cbRandevuSaat.Size = new System.Drawing.Size(136, 21);
            this.cbRandevuSaat.TabIndex = 179;
//            this.cbRandevuSaat.SelectedIndexChanged += new System.EventHandler(this.cbRandevuSaat_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(50, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 178;
            this.label4.Text = "Saat";
            // 
            // btnRandevuIptal
            // 
            this.btnRandevuIptal.BackColor = System.Drawing.Color.Red;
            this.btnRandevuIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuIptal.Location = new System.Drawing.Point(111, 355);
            this.btnRandevuIptal.Name = "btnRandevuIptal";
            this.btnRandevuIptal.Size = new System.Drawing.Size(195, 51);
            this.btnRandevuIptal.TabIndex = 180;
            this.btnRandevuIptal.Text = "Randevu İptal";
            this.btnRandevuIptal.UseVisualStyleBackColor = false;
            this.btnRandevuIptal.Click += new System.EventHandler(this.btnRandevuIptal_Click);
            // 
            // frmRandevuIptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(399, 453);
            this.Controls.Add(this.btnRandevuIptal);
            this.Controls.Add(this.cbRandevuSaat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbRandevuTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbHekimler);
            this.Controls.Add(this.cbKlinikler);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHastaSoyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHastaAdi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRandevuIptal";
            this.Text = "Randevu İptali";
            this.Load += new System.EventHandler(this.frmRandevuIptal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.TextBox txtHastaSoyadi;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbHekimler;
        public System.Windows.Forms.ComboBox cbKlinikler;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cbRandevuTarih;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbRandevuSaat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRandevuIptal;
    }
}