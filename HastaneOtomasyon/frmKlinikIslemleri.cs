using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyon.Models;

namespace HastaneOtomasyon
{
    public partial class frmKlinikIslemleri : Form
    {
        public frmKlinikIslemleri()
        {
            InitializeComponent();
        }

        private void tsbtnEkle_Click(object sender, EventArgs e)
        {
            //verileri txt ye gir
            Klinikler k = new Klinikler();
            k.KlinikAd = txtKlinikAd.Text;
            k.RandevuSure = Convert.ToInt32(txtRandevuSure.Text);
            k.Aciklama = txtAciklama.Text;

            if (k.KlinikVarmi(txtKlinikAd.Text))//eğer klinik txt de yazmıyorsa
            {
                MessageBox.Show("Klinik zaten var.", "UYARI");
            }
            else//txt ye yazılan klinik bilgileri
            {
                if (k.KlinikEkle(k))
                {//ekleme işlemi başarılıysa

                    MessageBox.Show("Klinik bilgileri başarıyla eklendi.");
                    //k.KlinikleriGetir(Genel.lvKlinikler);
                }
                else
                {//ekleme işlemi başarısızsa
                    MessageBox.Show("Klinik bilgileri eklenemedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            Temizle();
        }
        //klinik eklendikten sonra txtleri temizler
        public void Temizle()
        {


            txtKlinikAd.Clear();
            txtAciklama.Clear();
            txtRandevuSure.Clear();
            txtKlinikAd.Focus();
        }
        //kapat butonu
        private void tsbtnKapat_Click(object sender, EventArgs e)
        {
            Klinikler k = new Klinikler();
            frmKlinikTanimlama frm = new frmKlinikTanimlama();
            this.Close();
       }
        //düzenle butonu
        private void tsbtnDuzenle_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Klinik bilgilerini değiştirmek istediğinize emin misiniz?", "Düzenlensin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //seçilen verileri ekrana bazar düzeltilince k ya atar
                Klinikler k = new Klinikler();
                k.KlinikNo = Convert.ToInt32(txtKlinikNo.Text);
                k.KlinikAd = txtKlinikAd.Text;
                k.RandevuSure = Convert.ToInt32(txtRandevuSure.Text);
                k.Aciklama = txtAciklama.Text;

                if (k.KlinikDuzenle(k))
                {
                    //veriler eskisiyle değiştirilir
                    MessageBox.Show("Klinik Bilgileri değiştirildi..");
                    this.Close();
                }
                else
                {
                    //veriler değiştirilmezse
                    MessageBox.Show("Bilgileri kontrol ediniz..");
                }
            }
        }
    }
}
