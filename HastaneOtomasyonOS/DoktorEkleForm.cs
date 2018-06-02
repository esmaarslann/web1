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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace HastaneOtomasyonOS
{
    public partial class DoktorEkleForm : BaseForm
    {
        public DoktorEkleForm()
        {
            InitializeComponent();
        }
      
        public List<Doktor> Doktorlar = new List<Doktor>();
        public List<Hemsire> hemsireler = new List<Hemsire>();
        public List<Randevu> randevular = new List<Randevu>();
        public List<Randevu> doktorunRandevulari = new List<Randevu>();
        Doktor secilidoktor;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Doktor doktor = new Doktor()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Tckn = txtTckn.Text,
                    Mail = txtMail.Text,
                    Dgmtarihi = dtpDogumTarihi.Value,
                    Telefon = mtbTel.Text.Replace("(", "").Replace(")", "").Replace(" ", ""),
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                    Brans = (Brans)Enum.Parse(typeof(Brans), cmbBrans.SelectedItem.ToString()),
                    Maas = Convert.ToDecimal(txtMaas.Text)
                };
                
                    foreach (Hemsire item in lstSecilecekHemsireler.SelectedItems)
                {
                    doktor.hemsiresi.Add(item);
                    item.atanmısMı = true;
                }
                Doktorlar.Add(doktor);
                FormuTemizle();
                ListeyiDoldur();
                MessageBox.Show("Doktor Kaydı Eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoktorEkleForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbBrans.Items.AddRange(Enum.GetNames(typeof(Brans)));
            /*foreach (var item in secilecekHemsireler)
            {
                if(item.atananDoktor==null)
                    cmbHemsireSecim.Items.Add(item);
            }*/
            ListeyiDoldur();
        }

        public void ListeyiDoldur()
        {
            lstKayıtlar.Items.Clear();
            foreach (Doktor item in Doktorlar)
            {
                lstKayıtlar.Items.Add(item);
            }
        }

        public void FormuTemizle()
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
            if (secilidoktor == null) return;
            secilidoktor = lstKayıtlar.SelectedItem as Doktor;
            Doktorlar.Remove(secilidoktor);
            FormuTemizle();
            ListeyiDoldur();
            secilidoktor = null;
            foreach (Hemsire item in lstSeciliHemsireler.Items)
            {
                item.atanmısMı = false;
            }
            MessageBox.Show("Doktor Kaydı Silindi.");
        }

        private void lstKayıtlar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstKayıtlar.SelectedIndex == -1) return;

            secilidoktor = lstKayıtlar.SelectedItem as Doktor;
            txtAd.Text = secilidoktor.Ad;
            txtSoyad.Text = secilidoktor.Soyad;
            txtTckn.Text = secilidoktor.Tckn;
            txtMail.Text = secilidoktor.Mail;
            mtbTel.Text = secilidoktor.Telefon;
            cmbCinsiyet.SelectedIndex = (int)secilidoktor.Cinsiyet;
            dtpDogumTarihi.Value = secilidoktor.Dgmtarihi;
            cmbBrans.SelectedIndex = (int)secilidoktor.Brans;
            txtMaas.Text = secilidoktor.Maas.ToString();
            lstSeciliHemsireler.Items.Clear();
            foreach ( Hemsire item in secilidoktor.hemsiresi)
            {
                if (item.atanmısMı == true)
                lstSeciliHemsireler.Items.Add(item);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (secilidoktor == null)
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!");
                return;
            }
            try
            {
                secilidoktor = Doktorlar.Where(item => item.Tckn == secilidoktor.Tckn).FirstOrDefault();
                secilidoktor.Ad = txtAd.Text;
                secilidoktor.Soyad = txtSoyad.Text;
                secilidoktor.Tckn = txtTckn.Text;
                secilidoktor.Mail = txtMail.Text;
                secilidoktor.Telefon = mtbTel.Text;
                secilidoktor.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
                secilidoktor.Dgmtarihi = dtpDogumTarihi.Value;
                secilidoktor.Maas = Convert.ToDecimal(txtMaas.Text);
                //secilidoktor.Brans = (Brans)Enum.Parse(typeof(Brans), cmbBrans.SelectedItem.ToString());//Doktorun branşı değişmediği için yorum satırında.

                foreach (Hemsire item in lstSecilecekHemsireler.SelectedItems)
                {
                    secilidoktor.hemsiresi.Add(item);
                    item.atanmısMı = true;
                }
                foreach (Hemsire item in lstSeciliHemsireler.SelectedItems)
                {
                    secilidoktor.hemsiresi.Remove(item);
                    item.atanmısMı = false;
                }

                FormuTemizle();
                ListeyiDoldur();
                secilidoktor = null;
                MessageBox.Show("Doktor Bilgileri Güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ListeyiDoldur(List<Doktor> aramasonucu)
        {
            lstKayıtlar.Items.Clear();
            foreach (Doktor item in aramasonucu)
            {
                lstKayıtlar.Items.Add(item);
            }
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Doktor> aramaSonucu = AramaSorgusu<Doktor>.Ara(Doktorlar, txtArama.Text);
            ListeyiDoldur(aramaSonucu);
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSecilecekHemsireler.Items.Clear();
            lstSeciliHemsireler.Items.Clear();
            lstSecilecekHemsireler.Items.AddRange((HemsireSorgu.hemsireSorgu((hemsireler.Where(x => x.atanmısMı == false).ToList()), Convert.ToString(cmbBrans.SelectedItem))).ToArray());
            lstSeciliHemsireler.Items.AddRange((HemsireSorgu.hemsireSorgu((hemsireler.Where(x => x.atanmısMı == true).ToList()), Convert.ToString(cmbBrans.SelectedItem))).ToArray());
        }

        private void rndYazdır_Click(object sender, EventArgs e)
        {
            if (secilidoktor == null)
            {
                MessageBox.Show("Lütfen randevuları yazdırılacak doktoru seçiniz.");
                return;
            }
            if (secilidoktor.Saat.Length<1)
            {
                MessageBox.Show($"{secilidoktor.Ad} adlı doktorun hiç randevusu yok.");
                return;
            }
            foreach (Randevu item in randevular)
            {
                if (item.Doktor.ToString() == secilidoktor.ToString())
                    doktorunRandevulari.Add(item);
            }
            //doktorunRandevulari.Sort();
            
            Document doc = new Document(iTextSharp.text.PageSize.LETTER,25,15,30,10);
            PdfWriter pdfWrt = PdfWriter.GetInstance(doc, new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\HastaneOtomasyon\{secilidoktor.Ad} {secilidoktor.Soyad}'adlı_doktorun_Randevuları.pdf", FileMode.Create));
            doc.Open();
            Paragraph prg = new Paragraph($"{secilidoktor.Ad} {secilidoktor.Soyad} Adlı Doktorun Randevulari\n{secilidoktor.Saat}");
            doc.Add(prg);

            //PdfPTable table = new PdfPTable(3);

            //PdfPCell cell = new PdfPCell(new Phrase($"{secilidoktor.Ad} {secilidoktor.Soyad}"));
            //cell.Colspan = 3;
            //cell.HorizontalAlignment = 1;
            //table.AddCell(cell);

            ////foreach (Randevu item in doktorunRandevulari)
            ////{

            ////}

            //for (int i = 0; i < doktorunRandevulari.Count; i++)
            //{
            //    table.AddCell($"{doktorunRandevulari[i].Saat}");
            //    table.AddCell($"{doktorunRandevulari[i].Hasta.Tckn}");
            //    table.AddCell($"{doktorunRandevulari[i].Hasta.Ad} {doktorunRandevulari[i].Hasta.Soyad}");
            //}

            //doc.Add(table);

            doc.Close();
            doc.Dispose();
            MessageBox.Show($"{secilidoktor.Ad} {secilidoktor.Soyad} adlı dokturun randevuları yazdırıldı.");

        }
    }
}