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
    public partial class frmPersonelSorgulama : Form
    {
        public frmPersonelSorgulama()
        {
            InitializeComponent();
        }
        //personel işlemlerine tıklandığında sorgulama formunu ekrana bas
        private void frmPersonelSorgulama_Load(object sender, EventArgs e)
        {
            //personelleri veritabanından çek getir
            Personeller p = new Personeller();
            p.PersonelGetir(lvPersonel);
            tslblPersonelAdi.Text = Genel.PersonelAdi + " " + Genel.PersonelSoyadi;//personel adı ve soyadını yazdırma
        }

        private void lvPersonel_DoubleClick(object sender, EventArgs e)
        {
            frmPersoneller frm = new frmPersoneller();

            //frm.mtxtsicilNo.Text = lvPersonel.SelectedItems[0].SubItems[0].Text;
            //frm.txtPersonelAd.Text =lvPersonel.SelectedItems[0].SubItems[1].Text;
            // frm.txtPersonelSoyad.Text =lvPersonel.SelectedItems[0].SubItems[2].Text;
            // frm.txtunvanad.Text= lvPersonel.SelectedItems[0].SubItems[3].Text;
            // frm.txtklinikad.Text= lvPersonel.SelectedItems[0].SubItems[4].Text;
            // frm.mtxtdiploma.Text= lvPersonel.SelectedItems[0].SubItems[5].Text;
            // frm.txtAdres.Text= lvPersonel.SelectedItems[0].SubItems[6].Text;
            // frm.mtxtEvTel.Text= lvPersonel.SelectedItems[0].SubItems[7].Text;
            // frm.mtxtCepTel.Text= lvPersonel.SelectedItems[0].SubItems[8].Text;
            // frm.txtDogumYeri.Text= lvPersonel.SelectedItems[0].SubItems[9].Text;
            // frm.dtpDTarihi.Text= lvPersonel.SelectedItems[0].SubItems[10].Text;
            // frm.txtkullaniciad.Text= lvPersonel.SelectedItems[0].SubItems[11].Text;
            // frm.txtsifre.Text= lvPersonel.SelectedItems[0].SubItems[12].Text;
            // frm.txtpersonelid.Text= lvPersonel.SelectedItems[0].SubItems[13].Text;



            Genel.sicilNo = Convert.ToInt32(lvPersonel.SelectedItems[0].SubItems[0].Text);
            Genel.PersonelAdi = lvPersonel.SelectedItems[0].SubItems[1].Text;
            Genel.PersonelSoyadi = lvPersonel.SelectedItems[0].SubItems[2].Text;
            Genel.unvanad = lvPersonel.SelectedItems[0].SubItems[3].Text;
            Genel.klinikad = lvPersonel.SelectedItems[0].SubItems[4].Text;
            Genel.diploma = Convert.ToInt32(lvPersonel.SelectedItems[0].SubItems[5].Text);
            Genel.adres = lvPersonel.SelectedItems[0].SubItems[6].Text;
            Genel.evTel = lvPersonel.SelectedItems[0].SubItems[7].Text;
            Genel.cepTel = lvPersonel.SelectedItems[0].SubItems[8].Text;
            Genel.dogumYeri = lvPersonel.SelectedItems[0].SubItems[9].Text;
            Genel.dogumTarihi = Convert.ToDateTime(lvPersonel.SelectedItems[0].SubItems[10].Text);
            Genel.kullaniciad = lvPersonel.SelectedItems[0].SubItems[11].Text;
            Genel.sifre = lvPersonel.SelectedItems[0].SubItems[12].Text;
            Genel.PersonelID = Convert.ToInt32(lvPersonel.SelectedItems[0].SubItems[13].Text);

        }
        //veriyi seçtikten sonra Güncelle Butonuna Tıklandığında
        private void tsbtnGuncelle_Click(object sender, EventArgs e)
        {

            if (lvPersonel.SelectedItems.Count == 0)
            {
                MessageBox.Show("Personel bilgisi seçilmedi!!");
            }
            else
            {
                frmPersoneller frm = new frmPersoneller();
                //form düzenlemeleri
                frm.Top = 0;
                frm.Left = 0;
                //düzenlenecek verileri nesnelere yaz
                frm.mtxtsicilNo.Text = lvPersonel.SelectedItems[0].SubItems[0].Text;
                frm.txtPersonelAd.Text = lvPersonel.SelectedItems[0].SubItems[1].Text;
                frm.txtPersonelSoyad.Text = lvPersonel.SelectedItems[0].SubItems[2].Text;
                frm.txtunvanad.Text = lvPersonel.SelectedItems[0].SubItems[3].Text;
                frm.txtklinikad.Text = lvPersonel.SelectedItems[0].SubItems[4].Text;
                frm.mtxtdiploma.Text = lvPersonel.SelectedItems[0].SubItems[5].Text;
                frm.txtAdres.Text = lvPersonel.SelectedItems[0].SubItems[6].Text;
                frm.mtxtEvTel.Text = lvPersonel.SelectedItems[0].SubItems[7].Text;
                frm.mtxtCepTel.Text = lvPersonel.SelectedItems[0].SubItems[8].Text;
                frm.txtDogumYeri.Text = lvPersonel.SelectedItems[0].SubItems[9].Text;
                frm.dtpDTarihi.Text = lvPersonel.SelectedItems[0].SubItems[10].Text;
                frm.txtkullaniciad.Text = lvPersonel.SelectedItems[0].SubItems[11].Text;
                frm.txtsifre.Text = lvPersonel.SelectedItems[0].SubItems[12].Text;
                frm.txtpersonelid.Text = lvPersonel.SelectedItems[0].SubItems[13].Text;

                frm.ShowDialog();
            }
            //düzenlenen veriyi tabloya ekle
            Personeller p = new Personeller();
            p.PersonelGetir(lvPersonel);
        }

        Personeller p = new Personeller();
        //ada göre personel araması
        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            p.PersonelGetirBySorgulama(txtAdaGore.Text, txtSoyAdaGore.Text, lvPersonel);
        }
        //soyada göre personel araması
        private void txtSoyAdaGore_TextChanged(object sender, EventArgs e)
        {
            p.PersonelGetirBySorgulama(txtSoyAdaGore.Text, txtSoyAdaGore.Text, lvPersonel);
        }
        //kapat butonu
        private void tsbtnKapat_Click(object sender, EventArgs e)
        {
            frmPersonelSorgulama frm = new frmPersonelSorgulama();
            this.Close();
        }
        //seçilen personeli silme
        private void tsbtnSil_Click(object sender, EventArgs e)
        {
            if (lvPersonel.SelectedItems.Count == 0)
            {
                MessageBox.Show("Personel bilgisi seçilmedi!!");
            }
            else
            {
                if (MessageBox.Show("Bu Personeli silmek istediğinize emin misiniz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Personeller p = new Personeller();

                    p.SicilNo = Convert.ToInt32(lvPersonel.SelectedItems[0].SubItems[0].Text);
                    p.Ad = lvPersonel.SelectedItems[0].SubItems[1].Text;
                    p.Soyad = lvPersonel.SelectedItems[0].SubItems[2].Text;
                    Genel.unvanad = lvPersonel.SelectedItems[0].SubItems[3].Text;
                    Genel.klinikad = lvPersonel.SelectedItems[0].SubItems[4].Text;
                    p.DiplomaNo = Convert.ToInt32(lvPersonel.SelectedItems[0].SubItems[5].Text);
                    p.Adres = lvPersonel.SelectedItems[0].SubItems[6].Text;
                    p.EvTel = lvPersonel.SelectedItems[0].SubItems[7].Text;
                    p.CepTel = lvPersonel.SelectedItems[0].SubItems[8].Text;
                    p.DogumYeri = lvPersonel.SelectedItems[0].SubItems[9].Text;
                    p.DogumTarihi = Convert.ToDateTime(lvPersonel.SelectedItems[0].SubItems[10].Text);
                    p.KullaniciAdi = lvPersonel.SelectedItems[0].SubItems[11].Text;
                    p.Sifre = lvPersonel.SelectedItems[0].SubItems[12].Text;
                    p.PersonelID = Convert.ToInt32(lvPersonel.SelectedItems[0].SubItems[13].Text);
                    if (p.PersonelSil(p))
                    {
                        MessageBox.Show("Personel bilgileri silindi.");
                        p.PersonelGetir(lvPersonel);

                    }
                }
            }
        }

        private void tsbtnEkle_Click(object sender, EventArgs e)
        {
            frmPersoneller frm = new frmPersoneller();
            //form düzenlemeleri
            frm.Top = 0;
            frm.Left = 0;
            frm.ShowDialog();
            Personeller pi = new Personeller();
            p.PersonelGetir(lvPersonel);
        }
    }
}
