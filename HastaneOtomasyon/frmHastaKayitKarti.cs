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
    public partial class frmHastaKayitKarti : Form
    {
        public frmHastaKayitKarti()
        {
            InitializeComponent();
        }
        //form yüklendiğinde gerçekleşenler
        private void frmHastaKayitKarti_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            Kurumlar k = new Kurumlar();
            k.KurumTurleriGetir(cbxKurum);//coöbobox kurum adları ile doldurulur
            toolStrip2.Text = Genel.PersonelAdi + " " + Genel.PersonelSoyadi;//personel adı ve soyadını yazdırma
        }
       //bütün textboxlar temizleniyor
        private void Temizle()
        {
            txtHastaAd.Clear();
            txtHastaSoyad.Clear();
            txtTcKimlik.Clear();
            txtil.Clear();
            txtilce.Clear();
            mtxtCepTel.Clear();
            mtxtEvTel.Clear();
            mtxtCepTel.Clear();
            mtxtVergiNo.Clear();
            txtOnceki.Clear();
            txtAnneAdi.Clear();
            txtBabaAdi.Clear();
            txtAdres.Clear();
            txtHastaAd.Focus();
            txtDogumYeri.Clear();
            
            //bütün (*) labellar siyah doldurulurken
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
   //kurum adı seçme işlemi
        private void cbxKurum_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //kurum adlarını veri tabanından çek comboya at
            Kurumlar k = (Kurumlar)cbxKurum.SelectedItem;

            txtKurumTuru.Text = k.KurumAd;
            txtKurumNo.Text = Convert.ToString(k.KurumID);//ada göre numarasını text yaz
        }
        //adres ekleme
        private void txtAdres_TextChanged_1(object sender, EventArgs e)
        {
            txtAdres.ScrollBars = ScrollBars.Vertical;
            txtAdres.ScrollBars = ScrollBars.Both;
        }
        //kaydet butonunu tıklandığında
        private void tsbtnKaydet_Click(object sender, EventArgs e)
        {
            //hasta bilgileri boş değilse
            if (txtTcKimlik.Text.Trim() != "" && txtAnneAdi.Text.Trim() != "" && txtHastaAd.Text.Trim() != "" && txtBabaAdi.Text.Trim() != "" && txtDogumYeri.Text.Trim() != "" && txtHastaSoyad.Text.Trim() != "" && mtxtCepTel.Text.Trim() != "" && txtDogumYeri.Text.Trim() != "" && txtil.Text.Trim() != "" && txtilce.Text.Trim() != "" && txtBabaAdi.Text.Trim() != "")
            {
                Hastalar h = new Hastalar();
                if (h.KisiKontrol(txtTcKimlik.Text))//eğer hastanın tcsi daha önceden var ise bu hasta daha önceden kayıtlıdır
                {
                    MessageBox.Show("Bu Kişi Daha Önceden Kayıtlıdır");
                    txtTcKimlik.Focus();

                }
                else//hasta bilgilerini textden al h
                {

                    h.Ad = txtHastaAd.Text;
                    h.Soyad = txtHastaSoyad.Text;
                    h.TcKimlikNo = txtTcKimlik.Text;
                    h.Adres = txtAdres.Text;
                    h.Il = txtil.Text;
                    h.Ilce = txtilce.Text;
                    h.EvTel = mtxtEvTel.Text;
                    h.CepTel = mtxtCepTel.Text;
                    h.KanGrubu = cbxKanGrubu.Text;
                    h.BabaAd = txtBabaAdi.Text;
                    h.AnneAd = txtAnneAdi.Text;
                    h.DogumYeri = txtDogumYeri.Text;
                    h.DogumTarihi = Convert.ToDateTime(dtpDTarihi.Value);
                    h.Cinsiyet = cbxCinsiyet.Text;
                    h.MedeniHali = cbxMedeni.Text;
                    h.OncekiSoyad = txtOnceki.Text;
                    h.VergiNo = mtxtVergiNo.Text;
                    h.KayitTarihi = Convert.ToDateTime(dtpTarih.Value);
                    h.KurumID = Convert.ToInt32(txtKurumNo.Text);



                    //kaydedildiyse
                    if (h.KisiEkle(h))
                    {
                        MessageBox.Show("Kişi Bilgileri Kayıt Edildi");
                        Temizle();
                        tsbtnKaydet.Enabled = false;
                        frmHastaKayitSorgulama frm = new frmHastaKayitSorgulama();

                        frm.ShowDialog();


                    }//hasta kaydedilmediyse
                    else { MessageBox.Show("Kişi Kayıt İşlemi Gerçekleşmedi!"); }
                }
            }
            else//hasta bilgileri boşşsa
            {
                MessageBox.Show("Eksik Bilgi Girdiniz!,Dikkat Ediniz!");
                label17.ForeColor = System.Drawing.Color.Red;
   
                if (txtHastaAd.Text.Trim() == "")//hasta ad txt boşsa kenardaki lbl kırmızı yap
                {
                    label18.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label18.ForeColor = System.Drawing.Color.Black;//txt doluysa kenardaki lbl siyah
                if (txtHastaSoyad.Text.Trim() == "")//txt boşsa kenardaki lbl kırmızı yap
                {
                    label23.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label23.ForeColor = System.Drawing.Color.Black;//txt doluysa kenardaki lbl siyah
                }

                if (txtTcKimlik.Text.Trim() == "")//txt boşsa kenardaki lbl kırmızı yap
                {
                    label19.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label19.ForeColor = System.Drawing.Color.Black;

                }
                if (txtil.Text.Trim() == "")//txt boşsa kenardaki lbl kırmızı yap
                {
                    label22.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label22.ForeColor = System.Drawing.Color.Black;//txt doluysa kenardaki lbl siyah
                }
                if (txtilce.Text.Trim() == "")//txt boşsa kenardaki lbl kırmızı yap
                {
                    label21.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label22.ForeColor = System.Drawing.Color.Black;//txt doluysa kenardaki lbl siyah
                }
                if (mtxtEvTel.Text.Trim() == "")//txt boşsa kenardaki lbl kırmızı yap
                {
                    label20.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label20.ForeColor = System.Drawing.Color.Black;//txt doluysa kenardaki lbl siyah
                }
                if (mtxtCepTel.Text.Trim() == "")//txt boşsa kenardaki lbl kırmızı yap
                {
                    label17.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label17.ForeColor = System.Drawing.Color.Red;
                }
                if (cbxKanGrubu.SelectedText.Trim() == "")//txt boşsa kenardaki lbl kırmızı yap
                {
                    label16.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label16.ForeColor = System.Drawing.Color.Black;//txt doluysa kenardaki lbl siyah
                }
                if (txtAnneAdi.Text.Trim() == "")//txt boşsa kenardaki lbl kırmızı yap
                {
                    label25.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label25.ForeColor = System.Drawing.Color.Black;//txt doluysa kenardaki lbl siyah
                if (txtBabaAdi.Text.Trim() == "")//txt boşsa kenardaki lbl kırmızı yap
                {
                    label26.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label26.ForeColor = System.Drawing.Color.Black;//txt doluysa kenardaki lbl siyah
                if (txtDogumYeri.Text.Trim() == "")//txt boşsa kenardaki lbl kırmızı yap
                {
                    label24.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label24.ForeColor = System.Drawing.Color.Black;
                if (cbxCinsiyet.SelectedText.Trim() == "")//txt boşsa kenardaki lbl kırmızı yap
                {
                    label20.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label20.ForeColor = System.Drawing.Color.Black;//txt doluysa kenardaki lbl siyah
                }



            }
        }
        //yeni toolspript butonuna basıldığında text leri temizle
        private void tsbtnYeni_Click(object sender, EventArgs e)
        {
            tsbtnKaydet.Enabled = true;
            Temizle();
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
        //tooldan kapata basıldığında
        private void tsbtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //kurum isimlerini veritabanından çekiyor
        private void cbxKurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kurumlar k = (Kurumlar)cbxKurum.SelectedItem;//veritabanından kurumları getiriyor
            txtKurumTuru.Text = k.KurumAd;//kurum adını combodan cekip (k) ile text yazdırıyor
            txtKurumNo.Text = Convert.ToString(k.KurumID);//kurum idsini nosu olarak kaydediyor başına
        }
        //resim ekle butonu
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pbxResim.Image = Image.FromFile(openFileDialog2.FileName);
           
        }
    }
}

