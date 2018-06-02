using Hastane.Entity;
using Hastane.WFA.BaseForms;
using Hastane.WFA.DoktorForms;
using Hastane.WFA.HastaForms;
using Hastane.WFA.HemsireForms;
using Hastane.WFA.PersonelForms;
using Hastane.WFA.RandevuForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.WFA
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyContext Context = new MyContext();
        HastaEkleForm frmHastaEkle;
        private void hastaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHastaEkle == null || frmHastaEkle.IsDisposed)
                frmHastaEkle = new HastaEkleForm();
            frmHastaEkle.MdiParent = this;
            frmHastaEkle.Text = "Hasta Ekleme Formu";
            frmHastaEkle.Hastalar = this.Context.Hastalar;
            frmHastaEkle.Show();

        }
        HastaListeleForm frmHastaListele;
        private void hastaListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHastaListele == null || frmHastaListele.IsDisposed)
                frmHastaListele = new HastaListeleForm();
            frmHastaListele.MdiParent = this;
            frmHastaListele.Text = "Hasta Listeleme Formu";
            frmHastaListele.Listem = this.Context.Hastalar;
            frmHastaListele.Show();
        }
        PersonelEkleForm frmPersonelEkle;
        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPersonelEkle == null || frmPersonelEkle.IsDisposed)
                frmPersonelEkle = new PersonelEkleForm();
            frmPersonelEkle.MdiParent = this;
            frmPersonelEkle.Text = "Personel Ekleme Formu";
            frmPersonelEkle.Personeller = this.Context.Personeller;
            frmPersonelEkle.Show();
        }
        HemsireEkleForm frmHemsireEkle;
        private void hemşireEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHemsireEkle == null || frmHemsireEkle.IsDisposed)
                frmHemsireEkle = new HemsireEkleForm();
            frmHemsireEkle.MdiParent = this;
            frmHemsireEkle.Text = "Hemsire Ekleme Formu";
            frmHemsireEkle.Hemsireler = this.Context.Hemsireler;
            frmHemsireEkle.Show();
        }
        HemsireListeleForm frmHemsireListele;
        private void hemşireListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHemsireListele == null || frmHemsireListele.IsDisposed)
                frmHemsireListele = new HemsireListeleForm();
            frmHemsireListele.MdiParent = this;
            frmHemsireListele.Text = "Hemsireler Listeleme Formu";
            frmHemsireListele.Listem = this.Context.Hemsireler;
            frmHemsireListele.Show();
        }
        DoktorEkleForm frmDoktorEkle;
        private void doktorEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDoktorEkle == null || frmDoktorEkle.IsDisposed)
                frmDoktorEkle = new DoktorEkleForm();
            frmDoktorEkle.MdiParent = this;
            frmDoktorEkle.Text = "Doktor Ekleme Formu";
            frmDoktorEkle.Hemsireler = this.Context.Hemsireler;
            frmDoktorEkle.Doktorlar = this.Context.Doktorlar;
            frmDoktorEkle.Show();
        }
        DoktorListeleForm frmDoktorListele;
        private void doktorListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDoktorListele == null || frmDoktorListele.IsDisposed)
                frmDoktorListele = new DoktorListeleForm();
            frmDoktorListele.MdiParent = this;
            frmDoktorListele.Text = "Doktor Ekleme Formu";
            frmDoktorListele.Hemsireler = this.Context.Hemsireler;
            frmDoktorListele.Listem = this.Context.Doktorlar;
            frmDoktorListele.Show();
        }

        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MyTool.JSon<MyContext>(Context, new SaveFileDialog());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MyTool.JSon<MyContext>(ref Context, new OpenFileDialog());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        RandevuEkleForm frmRandevuEkle;
        private void randevuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRandevuEkle == null || frmRandevuEkle.IsDisposed)
                frmRandevuEkle = new RandevuEkleForm();
            frmRandevuEkle.MdiParent = this;
            frmRandevuEkle.Text = "Doktor Ekleme Formu";
            frmRandevuEkle.Doktorlar = this.Context.Doktorlar;
            frmRandevuEkle.Listem = this.Context.Hastalar;
            frmRandevuEkle.Randevular = this.Context.Randevular;
            frmRandevuEkle.Show();
        }
    }
}
