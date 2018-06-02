using Hastane.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.WFA.BaseForms
{
    public partial class ListeleBaseForm<T> : EkleBaseForm
        where T : HastaneBC
    {
        protected T BaseClass;
        public ListeleBaseForm()
        {
            InitializeComponent();
        }
        public List<T> Listem { get; set; }
        public T SeciliNesne { get; set; }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (SeciliNesne != null)
            {
                Listem.Remove(SeciliNesne);
                SeciliNesne = null;
                lstListe.Items.Clear();
                Listem.ForEach(x => lstListe.Items.Add(x));
            }
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
            lstListe.Items.Clear();
            Listem.ForEach(x => lstListe.Items.Add(x));
        }
    }
}
