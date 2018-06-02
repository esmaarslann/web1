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
    public partial class frmHastaKayitSorgulama : Form
    {
        public frmHastaKayitSorgulama()
        {
            InitializeComponent();
        }
        //datagridview hastalar ile doldur
        private void frmHastaKayitSorgulama_Load(object sender, EventArgs e)
        {
            Hastalar h = new Hastalar();
            h.HastaGetir(lvHastalar);
            tslblPersonelAdi.Text = Genel.PersonelAdi + " " + Genel.PersonelSoyadi;//personel adı ve soyadını yazdırma

        }
        //griddeki hasta tıklandığında seçilecek sütunlar
        private void lvHastalar_DoubleClick(object sender, EventArgs e)
        {
            Genel.SeciliHastaAd = lvHastalar.SelectedItems[0].SubItems[0].Text;
            Genel.SeciliHastaSoyad = lvHastalar.SelectedItems[0].SubItems[1].Text;
            Genel.SeciliTcKimlikNo = lvHastalar.SelectedItems[0].SubItems[2].Text;
            Genel.SeciliDogumTarihi = Convert.ToDateTime(lvHastalar.SelectedItems[0].SubItems[4].Text);
            Genel.SeciliCinsiyet = (lvHastalar.SelectedItems[0].SubItems[8].Text);
            Genel.SeciliHastaID = Convert.ToInt32(lvHastalar.SelectedItems[0].SubItems[9].Text);
        }
                        
        //ada göre arama yapma
        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            Hastalar h = new Hastalar();
            //h.AdaGoreAra(txtAdaGore.Text,lvHastalar);
            h.HastalariGetirBySorgulama(txtAdaGore.Text, txtSoyAdaGore.Text, txtTcyeGore.Text, lvHastalar);//ada göre ara ve istenilen sütunları getir
        }
        //soyada göre arama yapma
        private void txtSoyAdaGore_TextChanged(object sender, EventArgs e)
        {
            Hastalar h = new Hastalar();
            h.HastalariGetirBySorgulama(txtAdaGore.Text, txtSoyAdaGore.Text, txtTcyeGore.Text, lvHastalar);//soyada göre ara ve istenilen sütunları getir
        }
        //tcye göre arama yapma
        private void txtTcyeGore_TextChanged(object sender, EventArgs e)
        {
            Hastalar h = new Hastalar();
            h.HastalariGetirBySorgulama(txtAdaGore.Text, txtSoyAdaGore.Text, txtTcyeGore.Text, lvHastalar);//tcye göre ara ve istenilen sütunları getir
        }
        //hasta ekle butonuna tıklandığında hasta kayıt formunu açar
        private void tsbtnEkle_Click(object sender, EventArgs e)
        {
            frmHastaKayitKarti frm = new frmHastaKayitKarti();
            //form düzenlemeleri
            frm.Top = 0;
            frm.Left = 0;
            frm.ShowDialog();
            Hastalar H = new Hastalar();
            H.HastaGetir(lvHastalar);
        }
        //hasta kabul butonuna tıklandığında
        private void tsbtnHastaKabul_Click(object sender, EventArgs e)
        {
            if (lvHastalar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hasta bilgisi seçilmedi!!");
            }
            else//hasta bilgilerini txt lere girili olarak ekrana bastırır
            {
                frmHastaKabul frm = new frmHastaKabul();

                frm.Top = 0;
                frm.Left = 0;

                frm.txtHastaAd.Text = lvHastalar.SelectedItems[0].SubItems[0].Text;
                frm.txtHastaSoyad.Text = lvHastalar.SelectedItems[0].SubItems[1].Text;
                frm.txtTcKimlikNo.Text = lvHastalar.SelectedItems[0].SubItems[2].Text;
                frm.txtDogumTarihi.Text = lvHastalar.SelectedItems[0].SubItems[4].Text;
                frm.txtCinsiyet.Text = lvHastalar.SelectedItems[0].SubItems[8].Text;
                Genel.SeciliHastaID = Convert.ToInt32(lvHastalar.SelectedItems[0].SubItems[9].Text);
                frm.ShowDialog();
            }
            Hastalar h = new Hastalar();
            h.HastaGetir(lvHastalar);
        }

      
        //kapat butonu
        private void tsbtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //hasta sil butonu
        private void tsbtnSil_Click(object sender, EventArgs e)
        {
            if (lvHastalar.SelectedItems.Count == 0)//hasta seçili değilse
            {
                MessageBox.Show("Hasta bilgisi seçilmedi!!");


            }
            else//hasta seçili ise sil
            {
                if (MessageBox.Show("Bu Hastayı silmek istediğinize emin misiniz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {//aşağıda ye alan verileri sil
                    Hastalar h = new Hastalar();
                    h.Ad = lvHastalar.SelectedItems[0].SubItems[0].Text;
                    h.Soyad = lvHastalar.SelectedItems[0].SubItems[1].Text;
                    h.TcKimlikNo = lvHastalar.SelectedItems[0].SubItems[2].Text;
                    h.Adres = lvHastalar.SelectedItems[0].SubItems[3].Text;
                    h.DogumTarihi = Convert.ToDateTime(lvHastalar.SelectedItems[0].SubItems[4].Text);
                    h.EvTel = lvHastalar.SelectedItems[0].SubItems[5].Text;
                    h.CepTel = lvHastalar.SelectedItems[0].SubItems[6].Text;
                    h.KanGrubu = lvHastalar.SelectedItems[0].SubItems[7].Text;
                    h.Cinsiyet = lvHastalar.SelectedItems[0].SubItems[8].Text;
                    h.HastaID=Convert.ToInt32(lvHastalar.SelectedItems[0].SubItems[9].Text);
                    if (h.HastaSil(h))
                    {

                        MessageBox.Show("Hasta bilgileri silindi.");
                        h.HastaGetir(lvHastalar);

                    }
                }
            }
        }
        //randevu iptal butonu
        private void tsbtnRandevuIptal_Click(object sender, EventArgs e)
        {
            if(lvHastalar.SelectedItems.Count<1)//seçili hasta yoksa
            {

                MessageBox.Show("Seçili Hasta Bilgisi Yok!");

            }
            else//seçilen hasta randevusunu iptal et
            {
                frmRandevuIptal frm = new frmRandevuIptal();
                frm.Show();

            }
        }
        
    }
}
