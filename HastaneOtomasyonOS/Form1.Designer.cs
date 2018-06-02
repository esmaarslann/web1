namespace HastaneOtomasyonOS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dışarıAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeriAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.hastaGirişiToolStripMenuItem,
            this.randevuToolStripMenuItem,
            this.personelGirişiToolStripMenuItem,
            this.doktorGirişiToolStripMenuItem,
            this.hemşireGirişiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1223, 121);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dışarıAktarToolStripMenuItem,
            this.içeriAktarToolStripMenuItem});
            this.dosyaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dosyaToolStripMenuItem.Image")));
            this.dosyaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dosyaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(76, 117);
            this.dosyaToolStripMenuItem.Text = "&Dosya";
            this.dosyaToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.dosyaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dışarıAktarToolStripMenuItem
            // 
            this.dışarıAktarToolStripMenuItem.Name = "dışarıAktarToolStripMenuItem";
            this.dışarıAktarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dışarıAktarToolStripMenuItem.Text = "&Dışarı Aktar";
            this.dışarıAktarToolStripMenuItem.Click += new System.EventHandler(this.dışarıAktarToolStripMenuItem_Click);
            // 
            // içeriAktarToolStripMenuItem
            // 
            this.içeriAktarToolStripMenuItem.Name = "içeriAktarToolStripMenuItem";
            this.içeriAktarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.içeriAktarToolStripMenuItem.Text = "&İçeri Aktar";
            this.içeriAktarToolStripMenuItem.Click += new System.EventHandler(this.içeriAktarToolStripMenuItem_Click);
            // 
            // hastaGirişiToolStripMenuItem
            // 
            this.hastaGirişiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hastaGirişiToolStripMenuItem.Image")));
            this.hastaGirişiToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hastaGirişiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hastaGirişiToolStripMenuItem.Name = "hastaGirişiToolStripMenuItem";
            this.hastaGirişiToolStripMenuItem.Size = new System.Drawing.Size(133, 117);
            this.hastaGirişiToolStripMenuItem.Text = "Hasta Girişi";
            this.hastaGirişiToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.hastaGirişiToolStripMenuItem.Click += new System.EventHandler(this.btnHastaGirisi_Click);
            // 
            // randevuToolStripMenuItem
            // 
            this.randevuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("randevuToolStripMenuItem.Image")));
            this.randevuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.randevuToolStripMenuItem.Name = "randevuToolStripMenuItem";
            this.randevuToolStripMenuItem.Size = new System.Drawing.Size(78, 117);
            this.randevuToolStripMenuItem.Text = "Randevu";
            this.randevuToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.randevuToolStripMenuItem.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // personelGirişiToolStripMenuItem
            // 
            this.personelGirişiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personelGirişiToolStripMenuItem.Image")));
            this.personelGirişiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personelGirişiToolStripMenuItem.Name = "personelGirişiToolStripMenuItem";
            this.personelGirişiToolStripMenuItem.Size = new System.Drawing.Size(113, 117);
            this.personelGirişiToolStripMenuItem.Text = "Personel Girişi";
            this.personelGirişiToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.personelGirişiToolStripMenuItem.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // doktorGirişiToolStripMenuItem
            // 
            this.doktorGirişiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("doktorGirişiToolStripMenuItem.Image")));
            this.doktorGirişiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.doktorGirişiToolStripMenuItem.Name = "doktorGirişiToolStripMenuItem";
            this.doktorGirişiToolStripMenuItem.Size = new System.Drawing.Size(104, 117);
            this.doktorGirişiToolStripMenuItem.Text = "Doktor Girişi";
            this.doktorGirişiToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.doktorGirişiToolStripMenuItem.Click += new System.EventHandler(this.btnDoktorGirisi_Click);
            // 
            // hemşireGirişiToolStripMenuItem
            // 
            this.hemşireGirişiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hemşireGirişiToolStripMenuItem.Image")));
            this.hemşireGirişiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hemşireGirişiToolStripMenuItem.Name = "hemşireGirişiToolStripMenuItem";
            this.hemşireGirişiToolStripMenuItem.Size = new System.Drawing.Size(113, 117);
            this.hemşireGirişiToolStripMenuItem.Text = "Hemşire Girişi";
            this.hemşireGirişiToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.hemşireGirişiToolStripMenuItem.Click += new System.EventHandler(this.btnHemsire_Click);
            // 
            // dosyaAc
            // 
            this.dosyaAc.FileName = "openFileDialog1";
            // 
            // dosyaAc
            // 
            this.dosyaAc.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1223, 734);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dışarıAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeriAktarToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dosyaKaydet;
        private System.Windows.Forms.OpenFileDialog dosyaAc;
        private System.Windows.Forms.ToolStripMenuItem hastaGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşireGirişiToolStripMenuItem;
    }
}

