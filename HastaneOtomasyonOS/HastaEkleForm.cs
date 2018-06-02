using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneLib;

namespace HastaneOtomasyonOS
{
    public partial class HastaEkleForm : BaseForm
    {
        public HastaEkleForm()
        {
            InitializeComponent();
        }

        public List<Hasta> Hastalar = new List<Hasta>();
        Hasta secilihasta;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Hasta hasta = new Hasta()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Tckn = txtTckn.Text,
                    Mail = txtMail.Text,
                    Dgmtarihi = dtpDogumTarihi.Value,
                    Telefon = mtbTel.Text,
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler),cmbCinsiyet.SelectedItem.ToString())
                };
                Hastalar.Add(hasta);
                FormuTemizle();
                ListeyiDoldur();
                MessageBox.Show("Hasta Kaydı Eklendi.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void HastaEkleForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            ListeyiDoldur();
        }
        void ListeyiDoldur()
        {
            lstKayıtlar.Items.Clear();
            foreach (Hasta item in Hastalar)
            {
                lstKayıtlar.Items.Add(item);
            }
        }
        void FormuTemizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is MaskedTextBox)
                    (item as MaskedTextBox).Text = string.Empty;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = -1;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilihasta == null) return;
            secilihasta = lstKayıtlar.SelectedItem as Hasta;
            Hastalar.Remove(secilihasta);
            FormuTemizle();
            ListeyiDoldur();
            secilihasta = null;
            MessageBox.Show("Hasta Kaydı Silindi.");
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Hasta> aramaSonucu = AramaSorgusu<Hasta>.Ara(Hastalar, txtArama.Text);
            ListeyiDoldur(aramaSonucu);
        }

        private void lstKayıtlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKayıtlar.SelectedIndex == -1) return;
            secilihasta = lstKayıtlar.SelectedItem as Hasta;
            txtAd.Text = secilihasta.Ad;
            txtSoyad.Text = secilihasta.Soyad;
            txtTckn.Text = secilihasta.Tckn;
            txtMail.Text = secilihasta.Mail;
            mtbTel.Text = secilihasta.Telefon;
            cmbCinsiyet.SelectedIndex = (int)secilihasta.Cinsiyet;
            dtpDogumTarihi.Value = secilihasta.Dgmtarihi;
        }

        void ListeyiDoldur(List<Hasta> aramasonucu)
        {
            lstKayıtlar.Items.Clear();
            foreach (Hasta item in aramasonucu)
            {
                lstKayıtlar.Items.Add(item);
            }
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (secilihasta == null)
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!");
                return;
            }
            try
            {
                secilihasta = Hastalar.Where(item => item.Tckn == secilihasta.Tckn).FirstOrDefault();
                secilihasta.Ad = txtAd.Text;
                secilihasta.Soyad = txtSoyad.Text;
                secilihasta.Tckn = txtTckn.Text;
                secilihasta.Mail = txtMail.Text;
                secilihasta.Telefon = mtbTel.Text;
                secilihasta.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
                secilihasta.Dgmtarihi = dtpDogumTarihi.Value;
                FormuTemizle();
                ListeyiDoldur();
                secilihasta = null;
                MessageBox.Show("Hasta Bilgileri Güncellendi.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
