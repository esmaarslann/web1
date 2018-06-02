namespace Hastane.WFA.PersonelForms
{
    partial class PersonelEkleForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.nMaas = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGorev = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(11, 218);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 189);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(206, 244);
            this.btnTemizle.TabIndex = 9;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(106, 244);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.Location = new System.Drawing.Point(106, 215);
            this.cmbKanGrubu.Size = new System.Drawing.Size(178, 26);
            this.cmbKanGrubu.TabIndex = 7;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Location = new System.Drawing.Point(106, 186);
            this.cmbCinsiyet.Size = new System.Drawing.Size(178, 26);
            this.cmbCinsiyet.TabIndex = 6;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.TabIndex = 3;
            // 
            // txtTCKN
            // 
            this.txtTCKN.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "Maaş";
            // 
            // nMaas
            // 
            this.nMaas.DecimalPlaces = 2;
            this.nMaas.Location = new System.Drawing.Point(107, 124);
            this.nMaas.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nMaas.Name = "nMaas";
            this.nMaas.Size = new System.Drawing.Size(177, 23);
            this.nMaas.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Görev";
            // 
            // cmbGorev
            // 
            this.cmbGorev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGorev.FormattingEnabled = true;
            this.cmbGorev.Location = new System.Drawing.Point(106, 154);
            this.cmbGorev.Name = "cmbGorev";
            this.cmbGorev.Size = new System.Drawing.Size(177, 26);
            this.cmbGorev.TabIndex = 5;
            // 
            // PersonelEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 385);
            this.Controls.Add(this.cmbGorev);
            this.Controls.Add(this.nMaas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "PersonelEkleForm";
            this.Text = "PersonelEkleForm";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtAd, 0);
            this.Controls.SetChildIndex(this.txtSoyad, 0);
            this.Controls.SetChildIndex(this.txtTCKN, 0);
            this.Controls.SetChildIndex(this.dtpDogumTarihi, 0);
            this.Controls.SetChildIndex(this.cmbCinsiyet, 0);
            this.Controls.SetChildIndex(this.cmbKanGrubu, 0);
            this.Controls.SetChildIndex(this.btnKaydet, 0);
            this.Controls.SetChildIndex(this.btnTemizle, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.nMaas, 0);
            this.Controls.SetChildIndex(this.cmbGorev, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nMaas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGorev;
    }
}