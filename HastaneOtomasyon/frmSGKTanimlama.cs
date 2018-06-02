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
    public partial class frmSGKTanimlama : Form
    {
        public frmSGKTanimlama()
        {
            InitializeComponent();
        }

        private void frmSGKTanimlama_Load(object sender, EventArgs e)
        {
            Kurumlar k = new Kurumlar();
            k.KurumlariGetir(lvKurumlar);
        }

        private void tsbtnAdaGore_TextChanged(object sender, EventArgs e)
        {
            Kurumlar k = new Kurumlar();
            k.AdaGoreArama(tstxtAdaGore.Text, lvKurumlar);
        }
        //kurum eklemek için işlem formuna yönlendirir verileri alır listviewe ekler
        private void tsbtnEkle_Click(object sender, EventArgs e)
        {
            frmSGKIslemleri frm = new frmSGKIslemleri();
            frm.Text = "Kurum Ekleme İşlemleri";

            frm.Top = 0;
            frm.Left = 0;
            frm.lblKurumNo.Visible = false;
            frm.txtKurumNo.Visible = false;
            frm.tsbtnDuzenle.Visible = false;
            frm.tsbtnEkle.Visible = true;
            frm.ShowDialog();
            Kurumlar k = new Kurumlar();
            k.KurumlariGetir(lvKurumlar);
        }
        //seçili kurum düzenlemesi için bilgileri alır sgk işlem formuna yönlendirir 
        private void tsbtnDuzenle_Click(object sender, EventArgs e)
        {
            if (lvKurumlar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Kurum bilgisi seçilmedi!!");
            }
            else
            {
                frmSGKIslemleri frm = new frmSGKIslemleri();
                frm.Text = "Kurum Düzenleme İşlemleri";
                frm.Top = 0;
                frm.Left = 0;
                frm.tsbtnEkle.Visible = false;
                frm.txtKurumNo.Text = lvKurumlar.SelectedItems[0].SubItems[0].Text;
                frm.txtKurumAd.Text = lvKurumlar.SelectedItems[0].SubItems[1].Text;
                frm.txtIskonto.Text = lvKurumlar.SelectedItems[0].SubItems[2].Text;


                frm.ShowDialog();
            }
            Kurumlar k = new Kurumlar();
            k.KurumlariGetir(lvKurumlar);
        }
        //sil butonu ile seçili kurum silinmek üzere sorulur
        private void tsbtnSil_Click(object sender, EventArgs e)
        {

            if (lvKurumlar.SelectedItems.Count == 0)//kurum seçilmediyse
            {
                MessageBox.Show("Kurum bilgisi seçilmedi!!");
            }
            else
            {
                if (MessageBox.Show("Kurum bilgisini silmek istediğinize emin misiniz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Kurumlar k = new Kurumlar();
                    k.KurumID = Convert.ToInt32(lvKurumlar.SelectedItems[0].SubItems[0].Text);
                    k.KurumAd = lvKurumlar.SelectedItems[0].SubItems[1].Text;
                    k.Iskonto = Convert.ToInt32(lvKurumlar.SelectedItems[0].SubItems[2].Text);
                    
                    if (k.KurumSil(k))
                    {

                        MessageBox.Show("Kurum bilgileri silindi.");
                        k.KurumlariGetir(lvKurumlar);

                    }


                }

            }
        }
        //kapat butonu ile form kapatılır
        private void tsbtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
