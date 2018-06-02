using HastaneOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class frmMuayeneListesi : Form
    {
        public frmMuayeneListesi()
        {
            InitializeComponent();
        }

        private void tsbtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMuayeneListesi_Load(object sender, EventArgs e)
        {
            HastaKabul hk = new HastaKabul();
            hk.MuayeneListesiniGetir(Genel.PersonelID, lvMuayeneListesi);
            //label doktor adı ve kliniği yazdırır
            tslblDoktorAdi.Text = Genel.PersonelAdi+" "+Genel.PersonelSoyadi;
            tslblKlinikAdi.Text = Genel.KlinikAdi;

          
            
        }

        private void tsbtnMuayeneBasla_Click(object sender, EventArgs e)
        {
            if(lvMuayeneListesi.SelectedItems.Count<1)
            {

                MessageBox.Show("Hasta Seçimi yapılmadı!!","Hasta Seçiniz",MessageBoxButtons.OK,MessageBoxIcon.Stop);

            }

            else
            {
                frmMuayene frm = new frmMuayene();
                frm.ShowDialog();
            }


        }

        private void lvMuayeneListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
