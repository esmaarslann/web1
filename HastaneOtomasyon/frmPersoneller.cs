using HastaneOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class frmPersoneller : Form
    {
        public frmPersoneller()
        {
            InitializeComponent();
        }

        private void frmPersoneller_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Unvanla u = new Unvanla();
            u.UnvanTurGetir(cbxunvan);
            Klinikler kk = new Klinikler();
            kk.KlinikTurGetir(cbxklinik);
            tslblPersonelAdi.Text = Genel.PersonelAdi + " " + Genel.PersonelSoyadi;//personel adı ve soyadını yazdırma
        }


        private void Temizle()
        {

            txtPersonelAd.Clear();
            txtPersonelSoyad.Clear();
            mtxtsicilNo.Clear();

            mtxtCepTel.Clear();
            mtxtEvTel.Clear();
            mtxtCepTel.Clear();
            mtxtdiploma.Clear();
            txtkullaniciad.Clear();
            txtsifre.Clear();
            txtsifretekrar.Clear();
            txtAdres.Clear();
            txtDogumYeri.Clear();
            txtPersonelAd.Focus();


            label17.ForeColor = System.Drawing.Color.Black;
            label23.ForeColor = System.Drawing.Color.Black;
            label19.ForeColor = System.Drawing.Color.Black;
            label22.ForeColor = System.Drawing.Color.Black;
            label21.ForeColor = System.Drawing.Color.Black;
            label20.ForeColor = System.Drawing.Color.Black;
            label17.ForeColor = System.Drawing.Color.Black;
            label16.ForeColor = System.Drawing.Color.Black;
            label25.ForeColor = System.Drawing.Color.Black;
            label26.ForeColor = System.Drawing.Color.Black;
            label18.ForeColor = System.Drawing.Color.Black;
            label24.ForeColor = System.Drawing.Color.Black;







        }

        private void txtunvanad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxunvan_SelectedIndexChanged(object sender, EventArgs e)
        {

            Unvanlar u = (Unvanlar)cbxunvan.SelectedItem;

            txtunvanad.Text = u.PersonelUnvan;
            txtunvanID.Text = Convert.ToString(u.UnvanID);
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            txtAdres.ScrollBars = ScrollBars.Vertical;
            txtAdres.ScrollBars = ScrollBars.Both;
        }

        private void tsbtnKaydet_Click(object sender, EventArgs e)
        {
            if (mtxtsicilNo.Text.Trim() != "" && txtkullaniciad.Text.Trim() != "" && txtPersonelAd.Text.Trim() != "" && txtsifre.Text.Trim() != "" && txtDogumYeri.Text.Trim() != "" && txtPersonelSoyad.Text.Trim() != "" && mtxtdiploma.Text.Trim() != "" && txtDogumYeri.Text.Trim() != "" && txtunvanad.Text.Trim() != "" && txtklinikad.Text.Trim() != "")
            {
                Personeller p = new Personeller();
                if (p.PersonelKontrol(txtPersonelAd.Text, txtPersonelSoyad.Text, Convert.ToInt32(txtpersonelid.Text)))
                {
                    MessageBox.Show("Bu Kişi Daha Önceden Kayıtlıdır");
                    mtxtsicilNo.Focus();

                }
                else
                {
                    p.SicilNo = Convert.ToInt32(mtxtsicilNo.Text);
                    p.UnvanID = Convert.ToInt32(txtunvanID.Text);
                    p.KlinikID = Convert.ToInt32(txtklinikid.Text);
                    p.DiplomaNo = Convert.ToInt32(mtxtdiploma.Text);
                    p.DogumTarihi = Convert.ToDateTime(dtpDTarihi.Value);
                    p.DogumYeri = txtDogumYeri.Text;
                    p.Ad = txtPersonelAd.Text;
                    p.Soyad = txtPersonelSoyad.Text;
                    p.Adres = txtAdres.Text;
                    p.EvTel = mtxtEvTel.Text;
                    p.CepTel = mtxtCepTel.Text;
                    p.KullaniciAdi = txtkullaniciad.Text;
                    p.Sifre = txtsifre.Text;



                    if (p.KisiEkle(p))
                    {
                        MessageBox.Show("Kişi Bilgileri Kayıt Edildi");
                        Temizle();
                        tsbtnKaydet.Enabled = false;



                    }
                    else { MessageBox.Show("Kişi Kayıt İşlemi Gerçekleşmedi!"); }

                }
            }


            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz!,Dikkat Ediniz!");

                label17.ForeColor = System.Drawing.Color.Red;
                label23.ForeColor = System.Drawing.Color.Red;
                label19.ForeColor = System.Drawing.Color.Red;
                label22.ForeColor = System.Drawing.Color.Red;
                label21.ForeColor = System.Drawing.Color.Red;
                label20.ForeColor = System.Drawing.Color.Red;
                label17.ForeColor = System.Drawing.Color.Red;
                label16.ForeColor = System.Drawing.Color.Red;
                label25.ForeColor = System.Drawing.Color.Red;
                label26.ForeColor = System.Drawing.Color.Red;
                label18.ForeColor = System.Drawing.Color.Red;
                label24.ForeColor = System.Drawing.Color.Red;



            }
        }

        private void cbxklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            Klinikler kk = (Klinikler)cbxklinik.SelectedItem;

            txtklinikad.Text = kk.KlinikAd;
            txtklinikid.Text = Convert.ToString(kk.KlinikNo);
        }

        private void tsbtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnYeni_Click(object sender, EventArgs e)
        {
            tsbtnKaydet.Enabled = true;


            Temizle();
        }

        private void tsbtnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtPersonelAd.Text.Trim() != "" && txtPersonelSoyad.Text.Trim() != "")
            {
                Personeller p = new Personeller();
                if (p.PersonelKontrol(txtPersonelAd.Text, txtPersonelSoyad.Text, Convert.ToInt32(txtpersonelid.Text)))
                {
                    MessageBox.Show("Bu Personel önceden kayıtlı!");
                    txtPersonelAd.Focus();
                }

                else
                {
                    p.SicilNo = Convert.ToInt32(mtxtsicilNo.Text);
                    p.UnvanID = Convert.ToInt32(txtunvanID.Text);
                    p.KlinikID = Convert.ToInt32(txtklinikid.Text);
                    p.DiplomaNo = Convert.ToInt32(mtxtdiploma.Text);
                    p.DogumTarihi = Convert.ToDateTime(dtpDTarihi.Value);
                    p.DogumYeri = txtDogumYeri.Text;
                    p.Ad = txtPersonelAd.Text;
                    p.Soyad = txtPersonelSoyad.Text;
                    p.Adres = txtAdres.Text;
                    p.EvTel = mtxtEvTel.Text;
                    p.CepTel = mtxtCepTel.Text;
                    p.KullaniciAdi = txtkullaniciad.Text;
                    p.Sifre = txtsifre.Text;
                    p.PersonelID = Convert.ToInt32(txtpersonelid.Text);
                    if (p.PersonelGuncelle(p))
                    {
                        MessageBox.Show("Personel Bilgileri değiştirildi.");

                        Temizle();

                    }
                    else { MessageBox.Show("Personel güncelleme işlemi gerçekleşmedi!"); }
                }
            }
        }

        private void tslblPersonelAdi_Click(object sender, EventArgs e)
        {

        }
    }
}
