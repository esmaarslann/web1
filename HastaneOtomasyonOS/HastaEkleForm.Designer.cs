namespace HastaneOtomasyonOS
{
    partial class HastaEkleForm
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
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.TabIndex = 9;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.TabIndex = 11;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // lstKayıtlar
            // 
            this.lstKayıtlar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lstKayıtlar.TabIndex = 8;
            this.lstKayıtlar.Click += new System.EventHandler(this.lstKayıtlar_SelectedIndexChanged);
            // 
            // txtArama
            // 
            this.txtArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArama.TabIndex = 10;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // HastaEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 494);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HastaEkleForm";
            this.Text = "HastaEkleForm";
            this.Load += new System.EventHandler(this.HastaEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}