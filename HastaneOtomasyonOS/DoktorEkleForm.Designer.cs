namespace HastaneOtomasyonOS
{
    partial class DoktorEkleForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lstSecilecekHemsireler = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lstSeciliHemsireler = new System.Windows.Forms.ListBox();
            this.rndYazdır = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // txtTckn
            // 
            this.txtTckn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // txtMail
            // 
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCinsiyet.Size = new System.Drawing.Size(132, 24);
            // 
            // mtbTel
            // 
            this.mtbTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbTel.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(15, 537);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(120, 537);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.TabIndex = 12;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(225, 537);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGüncelle.TabIndex = 15;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // lstKayıtlar
            // 
            this.lstKayıtlar.Location = new System.Drawing.Point(419, 96);
            this.lstKayıtlar.Margin = new System.Windows.Forms.Padding(5);
            this.lstKayıtlar.Size = new System.Drawing.Size(268, 292);
            this.lstKayıtlar.TabIndex = 11;
            this.lstKayıtlar.SelectedIndexChanged += new System.EventHandler(this.lstKayıtlar_SelectedIndexChanged);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(419, 47);
            this.txtArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArama.TabIndex = 14;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(29, 459);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Branş :";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(169, 455);
            this.cmbBrans.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(132, 24);
            this.cmbBrans.TabIndex = 8;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(29, 406);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Maaş :";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(169, 402);
            this.txtMaas.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(132, 22);
            this.txtMaas.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(365, 450);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Hemşire Seçimi ";
            // 
            // lstSecilecekHemsireler
            // 
            this.lstSecilecekHemsireler.FormattingEnabled = true;
            this.lstSecilecekHemsireler.ItemHeight = 16;
            this.lstSecilecekHemsireler.Location = new System.Drawing.Point(368, 470);
            this.lstSecilecekHemsireler.Margin = new System.Windows.Forms.Padding(4);
            this.lstSecilecekHemsireler.Name = "lstSecilecekHemsireler";
            this.lstSecilecekHemsireler.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSecilecekHemsireler.Size = new System.Drawing.Size(159, 132);
            this.lstSecilecekHemsireler.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(550, 450);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Atanmış Hemşireler";
            // 
            // lstSeciliHemsireler
            // 
            this.lstSeciliHemsireler.FormattingEnabled = true;
            this.lstSeciliHemsireler.ItemHeight = 16;
            this.lstSeciliHemsireler.Location = new System.Drawing.Point(553, 470);
            this.lstSeciliHemsireler.Margin = new System.Windows.Forms.Padding(4);
            this.lstSeciliHemsireler.Name = "lstSeciliHemsireler";
            this.lstSeciliHemsireler.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSeciliHemsireler.Size = new System.Drawing.Size(159, 132);
            this.lstSeciliHemsireler.TabIndex = 13;
            // 
            // rndYazdır
            // 
            this.rndYazdır.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.rndYazdır.Location = new System.Drawing.Point(368, 402);
            this.rndYazdır.Name = "rndYazdır";
            this.rndYazdır.Size = new System.Drawing.Size(344, 39);
            this.rndYazdır.TabIndex = 33;
            this.rndYazdır.Text = "Randevu Yazdır (PDF)";
            this.rndYazdır.UseVisualStyleBackColor = true;
            this.rndYazdır.Click += new System.EventHandler(this.rndYazdır_Click);
            // 
            // DoktorEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(763, 621);
            this.Controls.Add(this.rndYazdır);
            this.Controls.Add(this.lstSeciliHemsireler);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lstSecilecekHemsireler);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DoktorEkleForm";
            this.Text = "DoktorEkleForm";
            this.Load += new System.EventHandler(this.DoktorEkleForm_Load);
            this.Controls.SetChildIndex(this.txtAd, 0);
            this.Controls.SetChildIndex(this.txtSoyad, 0);
            this.Controls.SetChildIndex(this.txtTckn, 0);
            this.Controls.SetChildIndex(this.txtMail, 0);
            this.Controls.SetChildIndex(this.dtpDogumTarihi, 0);
            this.Controls.SetChildIndex(this.cmbCinsiyet, 0);
            this.Controls.SetChildIndex(this.mtbTel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnEkle, 0);
            this.Controls.SetChildIndex(this.btnSil, 0);
            this.Controls.SetChildIndex(this.btnGüncelle, 0);
            this.Controls.SetChildIndex(this.lstKayıtlar, 0);
            this.Controls.SetChildIndex(this.txtArama, 0);
            this.Controls.SetChildIndex(this.txtMaas, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.cmbBrans, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.lstSecilecekHemsireler, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.lstSeciliHemsireler, 0);
            this.Controls.SetChildIndex(this.rndYazdır, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstSecilecekHemsireler;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstSeciliHemsireler;
        private System.Windows.Forms.Button rndYazdır;
    }
}