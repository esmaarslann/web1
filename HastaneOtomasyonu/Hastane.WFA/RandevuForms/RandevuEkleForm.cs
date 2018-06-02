using Hastane.Entity;
using Hastane.WFA.HastaForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.WFA.RandevuForms
{
    public partial class RandevuEkleForm : HastaListeleFormIntermediate
    {
        public RandevuEkleForm()
        {
            InitializeComponent();
        }
        public List<Doktor> Doktorlar { get; set; } = new List<Doktor>();
        public List<Randevu> Randevular { get; set; } = new List<Randevu>();
        public Birimler SeciliBirim { get; set; }
        public Doktor SeciliDoktor { get; set; }
        public List<string> Saatler { get; set; } = MyTool.SaatleriGetir();
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null)
            {
                SeciliNesne = null;
                gpRandevu.Visible = false;
                return;
            }

            SeciliNesne = lstListe.SelectedItem as Hasta;

            txtAd.Text = SeciliNesne.Ad;
            txtSoyad.Text = SeciliNesne.Soyad;
            txtTCKN.Text = SeciliNesne.TCKN;
            dtpDogumTarihi.Value = SeciliNesne.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)SeciliNesne.Cinsiyet;
            cmbKanGrubu.SelectedIndex = (int)SeciliNesne.KanGrubu;
            gpRandevu.Visible = true;
        }

        private void RandevuEkleForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbKanGrubu.Items.AddRange(Enum.GetNames(typeof(KanGruplari)));
            cmbBirim.Items.AddRange(Enum.GetNames(typeof(Birimler)));
            Listem.ForEach(x => lstListe.Items.Add(x));
        }

        private void cmbBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBirim.SelectedItem == null) return;

            SeciliBirim = (Birimler)Enum.Parse(typeof(Birimler), cmbBirim.SelectedItem.ToString());
            cmbDoktor.DataSource = Doktorlar.Where(x => x.Birimi == SeciliBirim).OrderBy(x => x.Ad).ToList();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            lstListe.DataSource = MyTool.Arama<Hasta>(txtAra.Text, Listem);
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoktor.SelectedItem == null)
            {
                SeciliDoktor = null;
                flpSaatler.Visible = false;
                btnRandevuKaydet.Enabled = false;
            }
            SeciliDoktor = cmbDoktor.SelectedItem as Doktor;
            flpSaatler.Visible = true;
            btnRandevuKaydet.Enabled = true;
            ButtonlariDoldur();
            SeciliButon = null;
            List<Randevu> doktorunRandevulari = Randevular.Where(x => x.Doktor.ID == SeciliDoktor.ID).ToList();
            doktorunRandevulari.ForEach(item => ButtonKapat(Saatler[item.SiraNumarasi]));

            List<Randevu> hastaninRandevulari = Randevular.Where(x => x.Hasta.ID == SeciliNesne.ID).ToList();
            hastaninRandevulari.ForEach(item => ButtonKapat(Saatler[item.SiraNumarasi]));
        }

        private void ButtonKapat(string text)
        {
            foreach (Button item in flpSaatler.Controls)
            {
                if(item.Text==text && item.Enabled == true)
                {
                    item.Enabled = false;
                    item.BackColor = secilemezRenk;
                }
            }
        }

        Color seciliRenk = Color.FromArgb(0x3B, 0xC4, 0x48);
        Color secilmemisRenk = Color.DarkOrange;
        Color secilemezRenk = Color.DimGray;
        private void ButtonlariDoldur()
        {
            flpSaatler.Controls.Clear();
            for (int i = 0; i < Saatler.Count; i++)
            {
                Button saatButton = new Button()
                {
                    BackColor = secilmemisRenk,
                    Text = Saatler[i],
                    Name = "btnSaat_" + i,
                    Size = new Size(69, 44),
                    Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)))
                };
                saatButton.Click += SaatButton_Click;
                flpSaatler.Controls.Add(saatButton);
            }
        }
        Button SeciliButon;
        private void SaatButton_Click(object sender, EventArgs e)
        {
            SeciliButon = sender as Button;
            ButonSec(SeciliButon);
        }
        private void ButonSec(Button seciliButon)
        {
            foreach (Button item in flpSaatler.Controls)
            {
                if (item.Name == SeciliButon.Name)
                    SeciliButon.BackColor = seciliRenk;
                else if (item.Enabled)
                    item.BackColor = secilmemisRenk;
            }
        }
        private void btnRandevuKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (SeciliButon == null)
                    throw new Exception("Önce Randevu Saatini Seçiniz");

                List<Randevu> hastaninRandevulari = Randevular.Where(x => x.Hasta.ID == SeciliNesne.ID).ToList();
                foreach (var item in hastaninRandevulari)
                {
                    if (item.SiraNumarasi == Saatler.IndexOf(SeciliButon.Text))
                        throw new Exception($"Hastanın {SeciliButon.Text} saatinde {item.Birim} biriminde randevusu bulunuyor.");
                }

                Randevular.Add(new Randevu()
                {
                    Birim = SeciliBirim,
                    Doktor = SeciliDoktor,
                    Hasta = SeciliNesne,
                    SiraNumarasi = Saatler.IndexOf(SeciliButon.Text)
                });
                lstListe.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
