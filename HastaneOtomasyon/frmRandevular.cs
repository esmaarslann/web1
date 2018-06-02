using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyon.Models;
using System.Globalization;

namespace HastaneOtomasyon
{
    public partial class frmRandevular : Form
    {
        public frmRandevular()
        {
            InitializeComponent();
        }
        //form yüklenince randevular taranır
        private void frmRandevular_Load(object sender, EventArgs e)
        {
            
            //tslblDoktorAdi.Text = frm.cbHekimler.SelectedItem.ToString();
            //tslblKlinikAdi.Text = frm.cbKlinikler.SelectedItem.ToString();


            RandevuTara();

        }
        //seçilen butonun içindeki saati gönder
        private void btnSaat9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn0.BackColor != Color.Red)
            {
                Randevular r = new Randevular();
                frmHastaKabul frm = new frmHastaKabul();
                r.HastaID = Convert.ToInt32(frm.txtHastaID.Text);
                r.PersonelID = Convert.ToInt32(frm.txtHekimID.Text);

                btn0.BackColor = Color.Red;
                btn0.Enabled = false;
                Genel.RandevuSaat = btn.Text;
            }
        }

        //eğer randevu verilen hasta aynı gün içinde ni kez daha alırsa uyarı verir
        private void tsbtnKaydet_Click(object sender, EventArgs e)
        { 
            Randevular r = new Randevular();  
            r.HastaID = Genel.SeciliHastaID;
            r.PersonelID = Genel.HekimID;
            r.Tarih = Convert.ToDateTime(Genel.RandevuTarih);
            r.Saat = Genel.RandevuSaat;
            //gün kontrolü
            if(r.RandevuAyniGunMu(r))
            {
                MessageBox.Show("Aynı gün içeriside sadece 1 randevu alınabilir...");
            }
            else
            {

                if (r.RandevuKaydet(r))
                {
                    MessageBox.Show("Randevu Bilgileri Kaydedildi..");
                    this.Close();
                }
            }
            RandevuTara();
        }
        
        private void dtpRandevuTarih_ValueChanged(object sender, EventArgs e)
        {
            Genel.RandevuTarih = dtpRandevuTarih.Value.ToShortDateString();
          
            RandevuTara();
        }
       
        public void RandevuTara()
        {
            Randevular r = new Randevular();

            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn0.Text))
            {
                btn0.BackColor = Color.Red;

            }
            else
            {
                btn0.BackColor = Color.LimeGreen;
                btn0.Enabled = true;
            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn1.Text))

            {
                btn1.BackColor = Color.Red;


            }
            else
            {
                btn1.BackColor = Color.LimeGreen;
                btn1.Enabled = true;

            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn2.Text))

            {
                btn2.BackColor = Color.Red;


            }
            else
            {
                btn2.BackColor = Color.LimeGreen;
                btn2.Enabled = true;
            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn3.Text))

            {
                btn3.BackColor = Color.Red;


            }
            else
            {
                btn3.BackColor = Color.LimeGreen;
                btn3.Enabled = true;
            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn4.Text))

            {
                btn4.BackColor = Color.Red;


            }
            else
            {
                btn4.BackColor = Color.LimeGreen;
                btn4.Enabled = true;
            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn5.Text))

            {
                btn5.BackColor = Color.Red;


            }
            else
            {
                btn5.BackColor = Color.LimeGreen;
                btn5.Enabled = true;
            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn6.Text))

            {
                btn6.BackColor = Color.Red;


            }
            else
            {
                btn6.BackColor = Color.LimeGreen;
                btn6.Enabled = true;
            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn7.Text))

            {
                btn7.BackColor = Color.Red;


            }
            else
            {
                btn7.BackColor = Color.LimeGreen;
                btn7.Enabled = true;
            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn8.Text))

            {
                btn8.BackColor = Color.Red;


            }
            else
            {
                btn8.BackColor = Color.LimeGreen;
                btn8.Enabled = true;
            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn9.Text))

            {
                btn9.BackColor = Color.Red;


            }
            else
            {
                btn9.BackColor = Color.LimeGreen;
                btn9.Enabled = true;
            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn10.Text))

            {
                btn10.BackColor = Color.Red;


            }
            else
            {
                btn10.BackColor = Color.LimeGreen;
                btn10.Enabled = true;
            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn11.Text))

            {
                btn11.BackColor = Color.Red;


            }
            else
            {
                btn11.BackColor = Color.LimeGreen;
                btn11.Enabled = true;
            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn12.Text))

            {
                btn12.BackColor = Color.Red;


            }
            else
            {
                btn12.BackColor = Color.LimeGreen;
                btn12.Enabled = true;
            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn13.Text))

            {
                btn13.BackColor = Color.Red;


            }
            else
            {
                btn13.BackColor = Color.LimeGreen;
                    btn13.Enabled = true; 
            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn14.Text))

            {
                btn14.BackColor = Color.Red;


            }
            else
            {
                btn14.BackColor = Color.LimeGreen;
                btn13.Enabled = true;
            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn15.Text))

            {
                btn15.BackColor = Color.Red;


            }
            else
            {
                btn15.BackColor = Color.LimeGreen;
                btn15.Enabled = true;
            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn16.Text))

            {
                btn16.BackColor = Color.Red;


            }
            else
            {
                btn16.BackColor = Color.LimeGreen;
                btn16.Enabled = true;
            }
            if (r.RandevuTara(Genel.HekimID, Genel.RandevuTarih, btn17.Text))

            {
                btn17.BackColor = Color.Red;


            }
            else
            {
                btn17.BackColor = Color.LimeGreen;
                btn17.Enabled = true;
            }


        }
        //buton rengi kırmızı ise randevu saatini al eğer rengi yeşilse sonucu dönder
        public bool KirmiziButon(Button btn)
        {
            bool Sonuc = false;
            if (btn.BackColor != Color.Red)
            {

                btn.BackColor = Color.Red;
                Genel.RandevuSaat = btn.Text;
                Sonuc = true;

            }
            else
            {

                btn.BackColor = Color.LimeGreen;
            }
            return Sonuc;


        }
        //randevu saati butonları seçili olan kırmızı seçili diğerleri seçilemez 
   
        #region Butonlar
        private void btn0_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn0))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;
            }
            else
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn13.Enabled = true;
                btn14.Enabled = true;
                btn15.Enabled = true;
                btn16.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn1))
            {
                btn0.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;
            }
            else
            {
                btn0.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn13.Enabled = true;
                btn14.Enabled = true;
                btn15.Enabled = true;
                btn16.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn2))
            {
                btn1.Enabled = false;
                btn0.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;
            }
            else
            {
                btn1.Enabled = true;
                btn0.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn13.Enabled = true;
                btn14.Enabled = true;
                btn15.Enabled = true;
                btn16.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn3))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn0.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;

            }
            else
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn0.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn13.Enabled = true;
                btn14.Enabled = true;
                btn15.Enabled = true;
                btn16.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn4))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn0.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;

            }
            else
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn0.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn13.Enabled = true;
                btn14.Enabled = true;
                btn15.Enabled = true;
                btn16.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn5))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn0.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;

            }
            else
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn0.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn13.Enabled = true;
                btn14.Enabled = true;
                btn15.Enabled = true;
                btn16.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn6))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn0.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;
            }
            else
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn0.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn13.Enabled = true;
                btn14.Enabled = true;
                btn15.Enabled = true;
                btn16.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn7))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn0.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;
            }
            else
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn0.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn13.Enabled = true;
                btn14.Enabled = true;
                btn15.Enabled = true;
                btn16.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn8))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn0.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;
            }
            else
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn0.Enabled = true;
                btn9.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn13.Enabled = true;
                btn14.Enabled = true;
                btn15.Enabled = true;
                btn16.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn9))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn0.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;
            }
            else
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn0.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn13.Enabled = true;
                btn14.Enabled = true;
                btn15.Enabled = true;
                btn16.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn10))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn0.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;
            }
            else
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn0.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn13.Enabled = true;
                btn14.Enabled = true;
                btn15.Enabled = true;
                btn16.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn11))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn0.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;
            }
            else
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn10.Enabled = true;
                btn0.Enabled = true;
                btn12.Enabled = true;
                btn13.Enabled = true;
                btn14.Enabled = true;
                btn15.Enabled = true;
                btn16.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn12))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn0.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;
            }
            else
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn0.Enabled = true;
                btn13.Enabled = true;
                btn14.Enabled = true;
                btn15.Enabled = true;
                btn16.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn13))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn0.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;
            }
            else
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn0.Enabled = true;
                btn14.Enabled = true;
                btn15.Enabled = true;
                btn16.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn14))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn0.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;
            }
            else
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn13.Enabled = true;
                btn0.Enabled = true;
                btn15.Enabled = true;
                btn16.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn15))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn0.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;
            }
            else
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn13.Enabled = true;
                btn14.Enabled = true;
                btn0.Enabled = true;
                btn16.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn16))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn0.Enabled = false;
                btn17.Enabled = false;
            }
            else
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn13.Enabled = true;
                btn14.Enabled = true;
                btn15.Enabled = true;
                btn0.Enabled = true;
                btn17.Enabled = true;
            }
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            if (KirmiziButon(btn17))
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn0.Enabled = false;
            }
            else
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn13.Enabled = true;
                btn14.Enabled = true;
                btn15.Enabled = true;
                btn16.Enabled = true;
                btn0.Enabled = true;
            }
        }
        #endregion
        //çıkış butonu
        private void tsbtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }      }