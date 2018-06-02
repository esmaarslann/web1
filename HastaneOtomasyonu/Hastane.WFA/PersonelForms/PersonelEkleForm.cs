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

namespace Hastane.WFA.PersonelForms
{
    public partial class PersonelEkleForm : EkleBaseForm
    {
        public PersonelEkleForm()
        {
            InitializeComponent();
        }
        public List<Personel> Personeller { get; set; }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Personeller.Add(new Personel()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    TCKN = txtTCKN.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                    KanGrubu = (KanGruplari)Enum.Parse(typeof(KanGruplari), cmbKanGrubu.SelectedItem.ToString()),
                    Gorevi = (Gorevler)Enum.Parse(typeof(Gorevler), cmbGorev.SelectedItem.ToString()),
                    Maas = nMaas.Value,
                });
                MyTool.FormTemizle(this.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
