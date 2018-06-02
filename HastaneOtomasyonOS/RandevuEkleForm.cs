using HastaneLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonOS
{
    public partial class RandevuEkleForm : Form
    {
        public List<Hasta> Hastalar = new List<Hasta>();
        public List<Doktor> doktorlar = new List<Doktor>();
        public List<Randevu> randevular = new List<Randevu>();
        public Randevu randevu = new Randevu();

        public RandevuEkleForm()
        {
            InitializeComponent();
        }

        #region Methods
        void butonRenklendirme()
        {
            foreach (var item in pnlSaatler.Controls)
            {
                if (item is Button)
                {
                    if (randevu.Hasta.Saat.Contains((item as Button).Text) && randevu.Hasta.Saat != null || randevu.Doktor.Saat != null && randevu.Doktor.Saat.Contains((item as Button).Text))
                    {
                        (item as Button).BackColor = Color.Silver;
                        (item as Button).Enabled = true;
                    }
                    else
                    {
                        (item as Button).BackColor = Color.Lime;
                        (item as Button).Enabled = true;
                    }
                }
            }

        }
        #endregion

        #region EventMethods
        private void Randevu_Load(object sender, EventArgs e)
        {
            foreach (var item in Hastalar)
                lstHastalar.Items.Add(item);
            cmbBranslar.Items.AddRange(Enum.GetNames(typeof(Brans)));
            cmbBranslar.Enabled = false;
            cmbDoktorlar.Visible = false;
            lblDoktorSecimi.Visible = false;
            pnlSaatler.Visible = false;
            btnRandevuOnayla.Enabled = false;
        }

        private void lstHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHastalar.SelectedIndex == -1) return;

            pnlSaatler.Visible = false;
            cmbDoktorlar.SelectedIndex = -1;
            cmbDoktorlar.Items.Clear();
            cmbDoktorlar.Visible = false;
            lblDoktorSecimi.Visible = false;
            cmbBranslar.SelectedIndex = -1;

            cmbBranslar.Enabled = true;
            randevu.Hasta = lstHastalar.SelectedItem as Hasta;
        }

        private void cmbBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBranslar.SelectedIndex == -1) return;

            pnlSaatler.Visible = false;
            cmbDoktorlar.SelectedIndex = -1;

            cmbDoktorlar.Visible = true;
            lblDoktorSecimi.Visible = true;
            cmbDoktorlar.Items.Clear();
            foreach (var doktor in doktorlar)
            {
                if (cmbBranslar.SelectedItem.ToString() == doktor.Brans.ToString())
                    cmbDoktorlar.Items.Add(doktor/*.ToString()*/);//ToString burada override randevu classında yapılabilir mi_____________???????????????????????
            }
        }

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoktorlar.SelectedIndex == -1) return;

            if ((cmbDoktorlar.SelectedItem as Doktor).Saat.Contains(randevu.Hasta.Tckn)/*randevu.Doktor.Saat.Contains(randevu.Hasta.Tckn)*/)
            {
                MessageBox.Show("Aynı doktora birden fazla randevu alınamaz.");
                cmbDoktorlar.SelectedIndex = -1;
                return;
            }

            randevu.Doktor = cmbDoktorlar.SelectedItem as Doktor;//yukardaki to string açılınca atmıyor neden atamdı____________________________??????
            saat = null;
            pnlSaatler.Visible = true;
            butonRenklendirme();
        }

        string saat;
        private void btn1345_Click(object sender, EventArgs e)
        {
            butonRenklendirme();
            if (randevu.Hasta.Saat.Contains((sender as Button).Text) && randevu.Hasta.Saat != null || randevu.Doktor.Saat != null && randevu.Doktor.Saat.Contains((sender as Button).Text))
            {
                MessageBox.Show($"{saat} saatinde başka randevunuz var.");
                return;
            }
            else
            {
                (sender as Button).BackColor = Color.Salmon;
                saat = (sender as Button).Text;
                btnRandevuOnayla.Enabled = true;
            }
        }

        private void btnRandevuOnayla_Click(object sender, EventArgs e)
        {
            if (cmbDoktorlar.SelectedIndex == -1)
            {
                MessageBox.Show("Arkadaşım doktor seçsene!");
                return;
            }
            if (saat == null || randevu.Hasta.Saat.Contains(saat))
            {
                MessageBox.Show("Randevunuzu onaylamadan önce saat seçmelisiniz.");
                return;
            }
            randevu.Saat = saat;
            randevu.Doktor.Saat += ("Randevu Saati: "+saat+" - "+"Hasta Adi: "+randevu.Hasta.Ad+ " - " + "Hasta Soyadi : "+randevu.Hasta.Soyad+ " - " +"Hasta Tc Numarasi: " + randevu.Hasta.Tckn+"\n");
            randevu.Hasta.Saat += saat;
            randevular.Add(randevu);

            pnlSaatler.Visible = false;
            cmbDoktorlar.SelectedIndex = -1;
            cmbDoktorlar.Items.Clear();
            cmbDoktorlar.Visible = false;
            lblDoktorSecimi.Visible = false;
            cmbBranslar.SelectedIndex = -1;
            cmbBranslar.Enabled = false;
            lstHastalar.SelectedIndex = -1;
            btnRandevuOnayla.Enabled = false;

            MessageBox.Show($"{randevu.Doktor.Ad} {randevu.Doktor.Soyad} isimli doktora {saat} saatinde randevunuz alınmıştır.\nLütfen randevu saatinden önce poliklinik sekreterliğine başvurunuz.");
        }
        #endregion
        
    }
}
