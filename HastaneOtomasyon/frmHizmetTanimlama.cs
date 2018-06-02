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
    public partial class frmHizmetTanimlama : Form
    {
        public frmHizmetTanimlama()
        {
            InitializeComponent();
        }
        //Hizmet tanımlama formu açıldığında verileri gride yükle(veritabanından)
        private void frmHizmetTanimlama_Load(object sender, EventArgs e)
        {
            Hizmetler h = new Hizmetler();
            h.HizmetleriGetir(lvHizmetler);
        }
        //hizmet adına göre arama
        private void tsbtnAdaGore_TextChanged(object sender, EventArgs e)
        {
            Hizmetler h = new Hizmetler();
            h.AdaGoreArama(tstxtAdaGore.Text, lvHizmetler);
        }
        //klinik adına göre arama
        private void tstxtKlinikAdinaGore_TextChanged(object sender, EventArgs e)
        {
            Hizmetler h = new Hizmetler();
            h.KlinikAdinaGoreArama(tstxtKlinikAdinaGore.Text, lvHizmetler);
        }
        //Hizmet ekleme
        private void tsbtnEkle_Click(object sender, EventArgs e)
        {
            
            frmHizmetIslemleri frm = new frmHizmetIslemleri();//hizmet işlemleri formu ekrana basılır
            frm.Text = "Hizmet Ekleme İşlemleri";

            frm.Top = 0;
            frm.Left = 0;
            //veriler
            frm.lblHizmetID.Visible = false;
            frm.txtHizmetID.Visible = false;
            frm.tsbtnDuzenle.Visible = false;
            frm.tsbtnEkle.Visible = true;
            //comboya klinikleri getirir
            Klinikler k = new Klinikler();
            k.KlinikAdiGetir(frm.cbKlinikAdlari);
            frm.ShowDialog();
            Hizmetler h = new Hizmetler();
            h.HizmetleriGetir(lvHizmetler);

        }
        //düzenle butonu seçilen verileri getirip düzenle
        private void tsbtnDuzenle_Click(object sender, EventArgs e)
        {
            //gridden veri seçilmezse
            if (lvHizmetler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hizmet bilgisi seçilmedi!!");
            }
            //gridden seçilen veriyi düzenleme işlemi
            else
            {
                //verileri txt comboya dolduruyor ki düzenleyebilelim
                frmHizmetIslemleri frm = new frmHizmetIslemleri();
                frm.Text = "Hizmet Düzenleme İşlemleri";
                frm.Top = 0;
                frm.Left = 0;
                frm.tsbtnEkle.Visible = false;//ekle butonu o anda çalışmaz
                //seçilen verileri txtye yazar
                frm.txtHizmetID.Text = lvHizmetler.SelectedItems[0].SubItems[0].Text;
                frm.txtHizmetAd.Text = lvHizmetler.SelectedItems[0].SubItems[1].Text;
                frm.txtAciklama.Text = lvHizmetler.SelectedItems[0].SubItems[2].Text;
                frm.txtKlinikAd.Text= lvHizmetler.SelectedItems[0].SubItems[3].Text;
                frm.txtKlinikNo.Text = lvHizmetler.SelectedItems[0].SubItems[5].Text;
                frm.txtUcret.Text = lvHizmetler.SelectedItems[0].SubItems[4].Text;
                frm.ShowDialog();
            }
        //düzenlenen veriyi gride ekler
        Hizmetler h = new Hizmetler();
        h.HizmetleriGetir(lvHizmetler);
        }
        //seçilen hizmet verisini siler
        private void tsbtnSil_Click(object sender, EventArgs e)
        {
            //eğer veri seçilmediyse
            if (lvHizmetler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hizmet bilgisi seçilmedi!!");


            }

            else//hizmeti verilerini sil
            {
                if (MessageBox.Show("Hizmet bilgisini silmek istediğinize emin misiniz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Hizmetler h = new Hizmetler();
                    //gridden verileri silme işlemi h ye atar
                    h.HizmetID = Convert.ToInt32(lvHizmetler.SelectedItems[0].SubItems[0].Text);
                    h.HizmetAdi = lvHizmetler.SelectedItems[0].SubItems[1].Text;
                    h.Ucret = Convert.ToDouble(lvHizmetler.SelectedItems[0].SubItems[4].Text);
                    h.KlinikID = Convert.ToInt32(lvHizmetler.SelectedItems[0].SubItems[5].Text);
                    h.Aciklama = lvHizmetler.SelectedItems[0].SubItems[2].Text;
                    //h bilgileri silindikten sonra 
                    if (h.HizmetSil(h))
                    {

                        MessageBox.Show("Hizmet bilgileri silindi.");
                        h.HizmetleriGetir(lvHizmetler);

                    }

                }

            }
        }
        //kapatma butonu
        private void tsbtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
