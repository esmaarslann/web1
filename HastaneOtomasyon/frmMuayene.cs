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
    public partial class frmMuayene : Form
    {
        public frmMuayene()
        {
            InitializeComponent();
        }

       

        private void btnGecmisEkle_Click(object sender, EventArgs e)
        {
            HastaGecmisi hg = new HastaGecmisi();
            hg.HastaID = Convert.ToInt32(lblHastaID.Text);
            hg.Aciklama = txtHastaGecmis.Text;

            hg.HastaGecmisiEkle(hg);
        }

        private void btnGecmisSil_Click(object sender, EventArgs e)
        {
            HastaGecmisi hg = new HastaGecmisi();
          

            //hg.HastaGecmisiSil(Convert.ToInt32(lblGecmisID.Text));
        }

        private void btnGecmisDuzenle_Click(object sender, EventArgs e)
        {
            HastaGecmisi hg = new HastaGecmisi();
            hg.Aciklama = txtHastaGecmis.Text;
            //hg.GecmisID = Convert.ToInt32(lblGecmisID.Text);

            hg.HastaGecmisiDuzenle(hg);
        }

        private void frmMuayene_Load(object sender, EventArgs e)
        {
            HastaGecmisi hg = new HastaGecmisi();
            hg.HastaGecmisiGetir(lvHastaGecmisi);
            cbIstenilenTahliller.SelectedIndex = 0;
            cbIlaclar.SelectedIndex = 0;
            tslblMuayeneTarihi.Text = DateTime.Now.ToShortDateString();
            tslblDoktorAdi.Text = Genel.PersonelAdi+" "+Genel.PersonelSoyadi;
            tslblKlinikAdi.Text = Genel.KlinikAdi;

            frmMuayeneListesi frmML = new frmMuayeneListesi();
            lblTcNo.Text = frmML.lvMuayeneListesi.SelectedItems[0].SubItems[0].Text;
            lblHastaAd.Text = frmML.lvMuayeneListesi.SelectedItems[0].SubItems[1].Text + " " +frmML.lvMuayeneListesi.SelectedItems[0].SubItems[2].Text;
            lblDogTarihi.Text = frmML.lvMuayeneListesi.SelectedItems[0].SubItems[3].Text;
            lblCinsiyet.Text = frmML.lvMuayeneListesi.SelectedItems[0].SubItems[4].Text;
            lblDoktorID.Text = Genel.PersonelID.ToString();
            lblKabulID.Text = frmML.lvMuayeneListesi.SelectedItems[0].SubItems[5].Text;
            lblHastaID.Text = frmML.lvMuayeneListesi.SelectedItems[0].SubItems[6].Text;
            lblKurumID.Text = frmML.lvMuayeneListesi.SelectedItems[0].SubItems[7].Text;
           

        }

        private void btnTahlilEkle_Click(object sender, EventArgs e)
        {
            lbIstenilenTahliller.Items.Add(cbIstenilenTahliller.SelectedItem);

            Tahliller th = new Tahliller();
            th.KabulID = Convert.ToInt32(lblKabulID.Text);
            th.Aciklama = cbIstenilenTahliller.SelectedItem.ToString();

            th.TahlilEkle(th);
        }

        private void btnIlacEkle_Click(object sender, EventArgs e)
        {
            lbRecete.Items.Add(cbIlaclar.SelectedItem);

            Receteler r = new Receteler();
            r.HastaID = Convert.ToInt32(lblHastaID.Text);
            r.KabulID = Convert.ToInt32(lblKabulID.Text);
            r.KurumID = Convert.ToInt32(lblKurumID.Text);
            r.PersonelID = Convert.ToInt32(lblDoktorID.Text);
            r.IlacAd = cbIlaclar.SelectedItem.ToString();

            r.ReceteEkle(r);



        }

        private void btnMuayeneBitir_Click(object sender, EventArgs e)
        {
            HastaSikayetleri hs = new HastaSikayetleri();
            hs.HastaID = Convert.ToInt32(lblHastaID.Text);
            hs.KabulID = Convert.ToInt32(lblKabulID.Text);
            hs.Aciklama = txtHastaSikayetleri.Text;

            if(hs.HastaSikayetleriEkle(hs))
            {

                Teshisler t = new Teshisler();
                t.DoktorID = Convert.ToInt32(lblDoktorID.Text);
                t.KabulID = Convert.ToInt32(lblKabulID.Text);
                t.Teshis = txtTeshis.Text;
                if (t.TeshisEkle(t))
                {

                    MessageBox.Show("Muayene bilgileri başarıyla kaydedildi.");


                }

                else
                    MessageBox.Show("Bilgileri Kontrol ediniz.");
            }
  


        }

       


    }
}
