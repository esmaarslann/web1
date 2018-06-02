using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.Entity;

namespace Hastane.WFA.DoktorForms
{
    public partial class DoktorListeleForm : DoktorListeleFormIntermediate
    {
        public DoktorListeleForm()
        {
            InitializeComponent();
        }
        public List<Hemsire> Hemsireler { get; set; }
        public List<Hemsire> DoktorunHemsireleri { get; set; } = new List<Hemsire>();

        private void DoktorListeleForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbKanGrubu.Items.AddRange(Enum.GetNames(typeof(KanGruplari)));
            cmbBirim.Items.AddRange(Enum.GetNames(typeof(Birimler))); ;
            cmbUnvan.Items.AddRange(Enum.GetNames(typeof(Unvanlar)));
            Listem.OrderBy(x => x.Ad).ToList().ForEach(x => lstListe.Items.Add(x));
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            var sonuc = MyTool.Arama<Doktor>(txtAra.Text, Listem);
            lstListe.Items.Clear();
            sonuc.ForEach(x => lstListe.Items.Add(x));
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null) return;

            SeciliNesne = lstListe.SelectedItem as Doktor;

            txtAd.Text = SeciliNesne.Ad;
            txtSoyad.Text = SeciliNesne.Soyad;
            txtTCKN.Text = SeciliNesne.TCKN;
            dtpDogumTarihi.Value = SeciliNesne.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)SeciliNesne.Cinsiyet;
            cmbKanGrubu.SelectedIndex = (int)SeciliNesne.KanGrubu;
            cmbBirim.SelectedIndex = (int)SeciliNesne.Birimi;
            cmbUnvan.SelectedIndex = (int)SeciliNesne.Unvan;
            nMaas.Value = SeciliNesne.Maas;

            DoktorunHemsireleri = SeciliNesne.Hemsireler;
            clstHemsireler.Items.Clear();
            DoktorunHemsireleri.ForEach(x => clstHemsireler.Items.Add(x));
            for (int i = 0; i < clstHemsireler.Items.Count; i++)
            {
                clstHemsireler.SetItemChecked(i, true);
            }
            var atanmayanHemsireler = Hemsireler.Where(x => x.Birimi == SeciliNesne.Birimi && x.AtandiMi == false).ToList();
            atanmayanHemsireler.ForEach(x => clstHemsireler.Items.Add(x));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (SeciliNesne == null) return;

            SeciliNesne.Ad = txtAd.Text;
            SeciliNesne.Soyad = txtSoyad.Text;
            SeciliNesne.TCKN = txtTCKN.Text;
            SeciliNesne.DogumTarihi = dtpDogumTarihi.Value;
            SeciliNesne.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
            SeciliNesne.KanGrubu = (KanGruplari)Enum.Parse(typeof(KanGruplari), cmbKanGrubu.SelectedItem.ToString());
            SeciliNesne.Maas = nMaas.Value;
            SeciliNesne.Birimi = (Birimler)Enum.Parse(typeof(Birimler), cmbBirim.SelectedItem.ToString());
            SeciliNesne.Unvan = (Unvanlar)Enum.Parse(typeof(Unvanlar), cmbUnvan.SelectedItem.ToString());

            DoktorunHemsireleri = new List<Hemsire>();
            for (int i = 0; i < clstHemsireler.Items.Count; i++)
            {
                if (clstHemsireler.GetItemCheckState(i) == CheckState.Checked)
                {
                    var seciliHemsire= clstHemsireler.Items[i] as Hemsire;
                    seciliHemsire.AtandiMi = true;
                    DoktorunHemsireleri.Add(seciliHemsire);
                }
                else if(clstHemsireler.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    var secilmemisHemsire= clstHemsireler.Items[i] as Hemsire;
                    Hemsireler.Where(x => x.ID == secilmemisHemsire.ID).FirstOrDefault().AtandiMi = false;
                }
            }
            SeciliNesne.Hemsireler = DoktorunHemsireleri;
            lstListe.Items.Clear();
            Listem.ForEach(x => lstListe.Items.Add(x));
        }
    }
}
