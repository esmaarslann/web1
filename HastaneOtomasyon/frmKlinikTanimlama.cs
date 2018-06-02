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
    public partial class frmKlinikTanimlama : Form
    {
        public frmKlinikTanimlama()
        {
            InitializeComponent();
        }

        private void frmKlinikTanimlama_Load(object sender, EventArgs e)
        {
            //gride klinikler verilerini yükler(klinikno, klinik adı,randevu süresi,açıklama)
            Klinikler k = new Klinikler();
            k.KlinikleriGetir(lvKlinikler);

        }
        //klinik ekleme işlemleri
        private void tsbtnEkle_Click(object sender, EventArgs e)
        {
            //klinik ekleme formunu getirir
            frmKlinikIslemleri frm = new frmKlinikIslemleri();
            frm.Text = "Klinik Ekleme İşlemleri";
            //form düzenlemeleri
            frm.Top = 0;
            frm.Left = 0;
            
            frm.lblKlinikNo.Visible = false;
            frm.txtKlinikNo.Visible= false;
            frm.tsbtnDuzenle.Visible = false;
            frm.tsbtnEkle.Visible = true;
            frm.ShowDialog();
            Klinikler k = new Klinikler();
            k.KlinikleriGetir(lvKlinikler);
        }
        //seçilen klinkte düzenlemeler yapma
        private void tsbtnDuzenle_Click(object sender, EventArgs e)
        {
            if (lvKlinikler.SelectedItems.Count==0)//gridden satır seçilmezse
            {
                MessageBox.Show("Klinik bilgisi seçilmedi!!");
            }
            else//seçilen verileri klinik işlemleri formuna yükleme
            {
                frmKlinikIslemleri frm = new frmKlinikIslemleri();
                frm.Text = "Klinik Düzenleme İşlemleri";
                //form düzenlemesi
                frm.Top = 0;
                frm.Left = 0;
                //verileri getir
                frm.tsbtnEkle.Visible = false;//ekle butonu çalışmaz
                //seçilen verileri txtye yazar
                frm.txtKlinikNo.Text = lvKlinikler.SelectedItems[0].SubItems[0].Text;
                frm.txtKlinikAd.Text = lvKlinikler.SelectedItems[0].SubItems[1].Text;
                frm.txtRandevuSure.Text = lvKlinikler.SelectedItems[0].SubItems[2].Text;
                frm.txtAciklama.Text = lvKlinikler.SelectedItems[0].SubItems[3].Text;


                frm.ShowDialog();
            }
            //ekleme işleminden sonra gride ekleme
            Klinikler k = new Klinikler();
            k.KlinikleriGetir(lvKlinikler);
            
        }
        //seçilen klinik bilgileriyle satırı silme
        private void tsbtnSil_Click(object sender, EventArgs e)
        {
            if (lvKlinikler.SelectedItems.Count == 0)//klinik seçilmesse 
            {
                MessageBox.Show("Klinik bilgisi seçilmedi!!");


            }
            else
            {
                if (MessageBox.Show("Klinik bilgisini silmek istediğinize emin misiniz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //klinik seçildikten sonra verileri Vt den al
                    Klinikler k = new Klinikler();
                    k.KlinikNo = Convert.ToInt32(lvKlinikler.SelectedItems[0].SubItems[0].Text);
                    k.KlinikAd = lvKlinikler.SelectedItems[0].SubItems[1].Text;
                    k.RandevuSure = Convert.ToInt32(lvKlinikler.SelectedItems[0].SubItems[2].Text);
                    k.Aciklama = lvKlinikler.SelectedItems[0].SubItems[3].Text;
                    if (k.KlinikSil(k))
                    {

                        MessageBox.Show("Klinik bilgileri silindi.");
                        k.KlinikleriGetir(lvKlinikler);

                    }


                }

            }
        }
        //klinik adına göre arama yapma
        private void tstxtAdaGore_TextChanged(object sender, EventArgs e)
        {
            Klinikler k = new Klinikler();
            k.AdaGoreArama(tstxtAdaGore.Text, lvKlinikler);
        }
        //kapat butonu formu kapatır
        private void tsbtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
