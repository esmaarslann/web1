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
    public partial class frmHizmetIslemleri : Form
    {
        public frmHizmetIslemleri()
        {
            InitializeComponent();
        }
        private void frmHizmetIslemleri_Load(object sender, EventArgs e)
        {
            Klinikler k = new Klinikler();
            frmHizmetTanimlama frm = new frmHizmetTanimlama();
            k.KlinikAdiGetir(cbKlinikAdlari);
            int index = cbKlinikAdlari.FindString(txtKlinikAd.Text);//txt de aradı klinik adlarını
            cbKlinikAdlari.SelectedIndex = index;//daha sonra klinik adlarını comboya attı
        }
        //Hizmet ekleme
        private void tsbtnEkle_Click(object sender, EventArgs e)
        {
            //tct yazılkı olanları al
            Hizmetler h = new Hizmetler();
            h.HizmetAdi = txtHizmetAd.Text;
            h.Ucret = Convert.ToInt32(txtUcret.Text);
            h.Aciklama = txtAciklama.Text;

            //klinik id eşleştir
            Klinikler k = new Klinikler();
            h.KlinikID=k.KlinikIDBul(cbKlinikAdlari.SelectedItem.ToString());

            if (h.HizmetVarmi(txtHizmetAd.Text))
            {
                MessageBox.Show("Hizmet zaten var.", "UYARI");
            }
            else
            {
                if (h.HizmetEkle(h))
                {

                    MessageBox.Show("Hizmet bilgileri başarıyla eklendi.");
                    //k.KlinikleriGetir(Genel.lvKlinikler);

                }
                else//hizmet bilgileri yanlış ise
                {
                    MessageBox.Show("Hizmet bilgileri eklenemedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            Temizle();
        }

       

        private void tsbtnDuzenle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hizmet bilgilerini değiştirmek istediğinize emin misiniz?", "Düzenlensin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Hizmetler h = new Hizmetler();
                h.HizmetID = Convert.ToInt32(txtHizmetID.Text);
                h.HizmetAdi = txtHizmetAd.Text;
                h.Ucret = Convert.ToDouble(txtUcret.Text);
                h.Aciklama = txtAciklama.Text;

                Klinikler k = new Klinikler();
                
                h.KlinikID = k.KlinikIDBul(cbKlinikAdlari.SelectedItem.ToString());

                if (h.HizmetDuzenle(h))
                {

                    MessageBox.Show("Hizmet Bilgileri değiştirildi..");
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Bilgileri kontrol ediniz..");
                }
            }
        }
        //eklenen hizmetten sonra txtyi temizler
        public void Temizle()
        {
            txtHizmetAd.Clear();
            txtAciklama.Clear();
            txtUcret.Clear();
            cbKlinikAdlari.SelectedIndex = 0;
            txtHizmetAd.Focus();
        }
        //kapat butonu
        private void tsbtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //kinik adlarını getirir
        private void cbKlinikAdlari_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hizmetler h = new Hizmetler();
            //txtKlinikAdi.Text = cbKlinikAdlari.SelectedItem.ToString();
        }
    }
}
