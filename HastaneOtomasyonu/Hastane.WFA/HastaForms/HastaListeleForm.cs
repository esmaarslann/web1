using Hastane.Entity;
using Hastane.WFA.BaseForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.WFA.HastaForms
{
    public partial class HastaListeleForm : HastaListeleFormIntermediate
    {
        public HastaListeleForm()
        {
            InitializeComponent();
        }
        public List<Hasta> Hastalar { get; set; }

        private void HastaListeleForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbKanGrubu.Items.AddRange(Enum.GetNames(typeof(KanGruplari)));
            Listem.ForEach(x => lstListe.Items.Add(x));
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            List<Hasta> sonuc = MyTool.Arama<Hasta>(txtAra.Text, Listem);
            lstListe.Items.Clear();
            sonuc.ForEach(x => lstListe.Items.Add(x));
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null) return;
            SeciliNesne = lstListe.SelectedItem as Hasta;
            txtAd.Text = SeciliNesne.Ad;
            txtSoyad.Text = SeciliNesne.Soyad;
            txtTCKN.Text = SeciliNesne.TCKN;
            dtpDogumTarihi.Value = SeciliNesne.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)SeciliNesne.Cinsiyet;
            cmbKanGrubu.SelectedIndex = (int)SeciliNesne.KanGrubu;
        }
    }
}
