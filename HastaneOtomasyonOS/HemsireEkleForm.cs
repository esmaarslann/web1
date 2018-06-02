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
    public partial class HemsireEkleForm : BaseForm
    {
        public HemsireEkleForm()
        {
            InitializeComponent();
        }
        public List<Hemsire> hemsireler = new List<Hemsire>();
        Hemsire secilihemsire;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Hemsire hemsire = new Hemsire()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Tckn = txtTckn.Text,
                    Mail = txtMail.Text,
                    Dgmtarihi = dtpDogumTarihi.Value,
                    Telefon = mtbTel.Text,
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                    Maas = Convert.ToDecimal(txtMaas.Text),
                    atanmısMı = false,
                    Brans = (Brans)Enum.Parse(typeof(Brans), cmbBrans.SelectedItem.ToString())
                    //atananDoktor=Doktor()

                };
                hemsireler.Add(hemsire);
                FormuTemizle();
                ListeyiDoldur();
                MessageBox.Show("Hemşire Kaydı Eklendi.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void HemsireEkleForm_Load(object sender, EventArgs e)
        {
            cmbBrans.Items.AddRange(Enum.GetNames(typeof(Brans)));
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            ListeyiDoldur();
        }
        void ListeyiDoldur()
        {
            lstKayıtlar.Items.Clear();
            foreach (Hemsire item in hemsireler)
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
            secilihemsire = lstKayıtlar.SelectedItem as Hemsire;
            if (secilihemsire == null) return;
            hemsireler.Remove(secilihemsire);
            secilihemsire.atanmısMı = false;
            secilihemsire = null;
            ListeyiDoldur();
            FormuTemizle();
            MessageBox.Show("Hemşire Kaydı Silindi.");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            secilihemsire = lstKayıtlar.SelectedItem as Hemsire;
            if (secilihemsire == null)
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!");
                return;
            }
            try
            {
                secilihemsire = hemsireler.Where(item => item.Tckn == secilihemsire.Tckn).FirstOrDefault();
                secilihemsire.Ad = txtAd.Text;
                secilihemsire.Soyad = txtSoyad.Text;
                secilihemsire.Tckn = txtTckn.Text;
                secilihemsire.Mail = txtMail.Text;
                secilihemsire.Telefon = mtbTel.Text;
                secilihemsire.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
                secilihemsire.Dgmtarihi = dtpDogumTarihi.Value;
                secilihemsire.Maas = Convert.ToDecimal(txtMaas.Text);
                if (secilihemsire.Brans.ToString() != cmbBrans.SelectedItem.ToString())
                    secilihemsire.atanmısMı = false;
                secilihemsire.Brans = (Brans)Enum.Parse(typeof(Brans), cmbBrans.SelectedItem.ToString());
                
               
                FormuTemizle();
                ListeyiDoldur();
                secilihemsire = null;
                MessageBox.Show("Hemşire Bilgileri Güncellendi.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        void ListeyiDoldur(List<Hemsire> aramasonucu)
        {
            lstKayıtlar.Items.Clear();
            foreach (Hemsire item in aramasonucu)
            {
                lstKayıtlar.Items.Add(item);
            }
        }
        private void lstKayıtlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilihemsire = lstKayıtlar.SelectedItem as Hemsire;
            txtAd.Text = secilihemsire.Ad;
            txtSoyad.Text = secilihemsire.Soyad;
            txtTckn.Text = secilihemsire.Tckn;
            txtMail.Text = secilihemsire.Mail;
            txtMaas.Text = secilihemsire.Maas.ToString();
            dtpDogumTarihi.Value = secilihemsire.Dgmtarihi;
            cmbBrans.SelectedIndex = (int)secilihemsire.Brans;
            cmbCinsiyet.SelectedIndex = (int)secilihemsire.Cinsiyet;
            mtbTel.Text = secilihemsire.Telefon;
            if (!(secilihemsire.atananDoktor == null))
                cmbDoktorSecim.Items.Add(secilihemsire.atananDoktor);
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Hemsire> aramaSonucu = AramaSorgusu<Hemsire>.Ara(hemsireler, txtArama.Text);
            ListeyiDoldur(aramaSonucu);
        }
    }
}
