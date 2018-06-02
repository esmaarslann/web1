namespace HastaneOtomasyonOS
{
    partial class HemsireEkleForm
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
            this.cmbDoktorSecim = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.btnEkle.Location = new System.Drawing.Point(32, 513);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(157, 513);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.TabIndex = 12;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(283, 513);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGüncelle.TabIndex = 14;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // lstKayıtlar
            // 
            this.lstKayıtlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstKayıtlar.Size = new System.Drawing.Size(268, 388);
            this.lstKayıtlar.TabIndex = 11;
            this.lstKayıtlar.SelectedIndexChanged += new System.EventHandler(this.lstKayıtlar_SelectedIndexChanged);
            // 
            // txtArama
            // 
            this.txtArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArama.TabIndex = 13;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(29, 465);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Branş :";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(169, 462);
            this.cmbBrans.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(132, 24);
            this.cmbBrans.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(29, 412);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Maaş :";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(169, 409);
            this.txtMaas.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(132, 22);
            this.txtMaas.TabIndex = 7;
            // 
            // cmbDoktorSecim
            // 
            this.cmbDoktorSecim.FormattingEnabled = true;
            this.cmbDoktorSecim.Location = new System.Drawing.Point(169, 513);
            this.cmbDoktorSecim.Name = "cmbDoktorSecim";
            this.cmbDoktorSecim.Size = new System.Drawing.Size(185, 24);
            this.cmbDoktorSecim.TabIndex = 34;
            this.cmbDoktorSecim.Text = "Hata değil visibleı kapalı";
            this.cmbDoktorSecim.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(29, 513);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Atandığı Doktor:";
            this.label10.Visible = false;
            // 
            // HemsireEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 603);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbDoktorSecim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HemsireEkleForm";
            this.Text = "HemsireEkleForm";
            this.Load += new System.EventHandler(this.HemsireEkleForm_Load);
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
            this.Controls.SetChildIndex(this.cmbDoktorSecim, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.ComboBox cmbDoktorSecim;
        private System.Windows.Forms.Label label10;
    }
}