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
    public partial class PersonelEkleForm : BaseForm
    {
        public PersonelEkleForm()
        {
            InitializeComponent();
        }
        public List<Personel> Personeller = new List<Personel>();
        Personel secilipersonel;

        private void PersonelEkleForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbGorev.Items.AddRange(Enum.GetNames(typeof(Gorev)));
            ListeyiDoldur();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Personel yenipersonel = new Personel()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Tckn = txtTckn.Text,
                    Telefon = mtbTel.Text,
                    Mail = txtMail.Text,
                    Maas = Convert.ToDecimal(txtMaas.Text),
                    Dgmtarihi = dtpDogumTarihi.Value,
                    Gorev = (Gorev)Enum.Parse(typeof(Gorev),cmbGorev.SelectedItem.ToString()),
                    Cinsiyet=(Cinsiyetler)Enum.Parse(typeof(Cinsiyetler),cmbCinsiyet.SelectedItem.ToString())
                };
                Personeller.Add(yenipersonel);
                FormuTemizle();
                ListeyiDoldur();
                MessageBox.Show("Personel Kaydı Eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ListeyiDoldur()
        {
            lstKayıtlar.Items.Clear();
            foreach (Personel item in Personeller)
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
            secilipersonel = lstKayıtlar.SelectedItem as Personel;
            if (secilipersonel == null) return;
            
            Personeller.Remove(secilipersonel);
            FormuTemizle();
            ListeyiDoldur();
            secilipersonel = null;
            MessageBox.Show("Personel Kaydı Silindi.");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (secilipersonel == null)
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!");
                return;
            }
            try
            {
                secilipersonel = Personeller.Where(item => item.Tckn == secilipersonel.Tckn).FirstOrDefault();
                secilipersonel.Ad = txtAd.Text;
                secilipersonel.Soyad = txtSoyad.Text;
                secilipersonel.Cinsiyet= (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
                secilipersonel.Dgmtarihi = dtpDogumTarihi.Value;
                secilipersonel.Gorev= (Gorev)Enum.Parse(typeof(Gorev), cmbGorev.SelectedItem.ToString());
                secilipersonel.Maas = Convert.ToDecimal(txtMaas.Text);
                secilipersonel.Mail = txtMail.Text;
                secilipersonel.Tckn = txtTckn.Text;
                secilipersonel.Telefon = mtbTel.Text;
                FormuTemizle();
                ListeyiDoldur();
                secilipersonel = null;
                MessageBox.Show("Personel Bilgileri Güncellendi.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lstKayıtlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKayıtlar.SelectedIndex==-1) return;
            secilipersonel = lstKayıtlar.SelectedItem as Personel;
            txtAd.Text=secilipersonel.Ad;
            txtMaas.Text=secilipersonel.Maas.ToString();
            txtMail.Text=secilipersonel.Mail;
            txtSoyad.Text=secilipersonel.Soyad;
            txtTckn.Text=secilipersonel.Tckn;
            mtbTel.Text=secilipersonel.Telefon;
            cmbCinsiyet.SelectedIndex=(int)secilipersonel.Cinsiyet;
            cmbGorev.SelectedIndex=(int)secilipersonel.Gorev;
            dtpDogumTarihi.Value=secilipersonel.Dgmtarihi;
        }
        void ListeyiDoldur(List<Personel> aramasonucu)
        {
            lstKayıtlar.Items.Clear();
            foreach (Personel item in aramasonucu)
            {
                lstKayıtlar.Items.Add(item);
            }
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Personel> aramaSonucu = AramaSorgusu<Personel>.Ara(Personeller, txtArama.Text);
            ListeyiDoldur(aramaSonucu);
        }
    }
}
