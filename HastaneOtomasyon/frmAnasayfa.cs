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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        //çıkış toolsprit
        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //çıkış butonu resmine basıldığında
        private void tsbCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //hasta kayıt kartı formu açma
        private void hastaKayitmitm_Click(object sender, EventArgs e)
        {
            frmHastaKayitKarti frm = new frmHastaKayitKarti();
            frm.Show();
        }
        //klinik tanımlama formu açma//1003 admin girebilir
        private void klinikTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKlinikTanimlama frm = new frmKlinikTanimlama();
            frm.ShowDialog();
        }
        
        //personel adı ve soyadını yazdırma
        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            tslblPersonelAdi.Text = Genel.PersonelAdi + " " + Genel.PersonelSoyadi;
        } 
        //1002 danışman veya 1003 admin ise yetkilendirme hasta kayıt sorgulamayı aç
        //değilse yetki verme
        private void tsbHastaKabul_Click(object sender, EventArgs e)
        {
            if (Genel.UnvanID==1002 || Genel.UnvanID==1003)
            {
                frmHastaKayitSorgulama frm = new frmHastaKayitSorgulama();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bu Alana giriş yetkiniz yok!!");
            }
           
        }
        //ünvanı doktor değilse muayeneye giremez yetki verme
        private void tsbMuayene_Click(object sender, EventArgs e)
        {
            if(Genel.UnvanID !=1)
            {
                MessageBox.Show("Bu sayfaya giriş yetkiniz yok !","YETKİ YOK",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }

            else
            {//ünvanı doktor ise muayene listesini görebilir

                frmMuayeneListesi frm = new frmMuayeneListesi();
                frm.ShowDialog();
            }

        }
        //danışman değilse vezneye girmez yetkisi yok
        private void tsbVezne_Click(object sender, EventArgs e)
        {
            if(Genel.UnvanID !=1002)
            {

                MessageBox.Show("Bu sayfaya giriş yetkiniz yok !", "YETKİ YOK", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {

                //Vezne Sayfası Açılacak 

            }
        }
      
        
        
        //sosyal güvenlik kurumu tanımlama---sgk tanımlama formu açma//admin 1003 girebilir
        private void sosyalGüvenlikKurumuTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSGKTanimlama frm = new frmSGKTanimlama();
            frm.ShowDialog();
        }
       
        //hasta kayıt(hasta ekle hasta kabul randevu iptal) sorgulama formu açma
        private void tsbRandevu_Click(object sender, EventArgs e)
        {
            frmHastaKayitSorgulama frm = new frmHastaKayitSorgulama();
            frm.ShowDialog();
        }
        //hasta kabul--hasta kayıt sorgulama formu açma 
        private void hastaKabulmitm_Click(object sender, EventArgs e)
        {
            frmHastaKabul frm = new frmHastaKabul();
            frm.ShowDialog();
        }

        
       
        //private void UnvanTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmTahlilTanimlama frm = new frmTahlilTanimlama();
        //    frm.ShowDialog();
        //}
        private void teshisEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHizmetTanimlama frm = new frmHizmetTanimlama();
              frm.ShowDialog();
        }

        private void isToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //admin 1003 değilse parametrelere yetkisi yok
            if (Genel.UnvanID != 1003)
            {
                MessageBox.Show("Bu bölüme giriş yetkiniz yok !", "YETKİ YOK", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {//ünvanı admin ise personel listesini görebilir

                frmPersonelSorgulama frm = new frmPersonelSorgulama();
                frm.ShowDialog();
            }
        }
        //unvan tanımlama formu açma---hizmet işlemleri formu açma//admin 1003 girebilir
        private void ünvanTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTahlilTanimlama frm = new frmTahlilTanimlama();
            frm.ShowDialog();
        }
    }
}
