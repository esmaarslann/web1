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
using System.Xml.Serialization;
using System.IO;

namespace HastaneOtomasyonOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Context context = new Context();

        HastaEkleForm hastaEkleForm;

        private void btnHastaGirisi_Click(object sender, EventArgs e)
        {
            if (hastaEkleForm == null || hastaEkleForm.IsDisposed)
            {
                hastaEkleForm = new HastaEkleForm();
                hastaEkleForm.MdiParent = this;
                hastaEkleForm.Hastalar = context.Hastalar;
                hastaEkleForm.Show();
            }
        }

        DoktorEkleForm doktorEkleForm;

        private void btnDoktorGirisi_Click(object sender, EventArgs e)
        {
            if (doktorEkleForm == null || doktorEkleForm.IsDisposed)
            {
                doktorEkleForm = new DoktorEkleForm();
                doktorEkleForm.MdiParent = this;
                doktorEkleForm.Doktorlar = context.Doktorlar;
                doktorEkleForm.hemsireler = context.Hemsireler;
                doktorEkleForm.randevular = context.Randevular;
                doktorEkleForm.Show();
            }
        }

        HemsireEkleForm hemsireEkleForm;

        private void btnHemsire_Click(object sender, EventArgs e)
        {
            if (hemsireEkleForm == null || hemsireEkleForm.IsDisposed)
            {
                hemsireEkleForm = new HemsireEkleForm();
                hemsireEkleForm.MdiParent = this;
                hemsireEkleForm.hemsireler = context.Hemsireler;
                hemsireEkleForm.Show();
            }
        }

        PersonelEkleForm personelEkleForm;

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            if (personelEkleForm == null || personelEkleForm.IsDisposed)
            {
                personelEkleForm = new PersonelEkleForm();
                personelEkleForm.MdiParent = this;
                personelEkleForm.Personeller = context.Personeller;
                personelEkleForm.Show();
            }
        }

        RandevuEkleForm randevu;

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            if (randevu == null || randevu.IsDisposed)
            {
                randevu = new RandevuEkleForm();
                randevu.MdiParent = this;
                randevu.Hastalar = context.Hastalar;
                randevu.doktorlar = context.Doktorlar;
                randevu.randevular = context.Randevular;
                randevu.Show();
            }
        }

        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Hastane Otomasyonu Verileri Dışarı Aktarılacak";
            dosyaKaydet.Filter = "XML Format | *.xml";
            dosyaKaydet.FileName = string.Empty;
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlContextSerializer = new XmlSerializer(typeof(Context));
                TextWriter writer = new StreamWriter(dosyaKaydet.FileName);
                xmlContextSerializer.Serialize(writer, context);
                writer.Close();
                writer.Dispose();
                MessageBox.Show("Veriler Dışarı Aktarıldı.");
            }
        }

        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "İçe Aktarılacak XML Dosyası Seçiniz";
            dosyaAc.Filter = "XML Format | *.xml";
            dosyaAc.Multiselect = false;
            dosyaAc.FileName = string.Empty;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlContextSerializer = new XmlSerializer(typeof(Context));
                TextReader reader = new StreamReader(dosyaAc.FileName);
                context = (Context)xmlContextSerializer.Deserialize(reader);
                reader.Close();
                reader.Dispose();
                MessageBox.Show("Dosya Aktarıldı");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Uygulamanızın verilerini dışarı kaydetmek ister misiniz?", "Kaydet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                XmlSerializer xmlContextSerializer = new XmlSerializer(typeof(Context));
                TextWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\HastaneOtomasyon\hop.xml");
                //TextWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\HastaneOtomasyon\hop{DateTime.Now.Hour.ToString()}{DateTime.Now.Minute.ToString()}.xml");
                xmlContextSerializer.Serialize(writer, context);
                writer.Close();
                writer.Dispose();
                MessageBox.Show($"Veriler 'hop.xml' ismiyle masaüstündeki 'HastaneOtomasyon' klasörüne kaydedildi.");
                //MessageBox.Show($"Veriler 'hop{DateTime.Now.Hour.ToString()}{DateTime.Now.Minute.ToString()}.xml' ismiyle masaüstündeki 'HastaneOtomasyon' klasörüne kaydedildi.");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Uygulamanıza dışarıdan veri eklemek ister misiniz?", "İçeri aktar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                XmlSerializer xmlContextSerializer = new XmlSerializer(typeof(Context));
                TextReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\HastaneOtomasyon\hop.xml");
                context = (Context)xmlContextSerializer.Deserialize(reader);
                reader.Close();
                reader.Dispose();
                MessageBox.Show("Veriler İçeri Aktarıldı.");
            }
        }

        private void hastaGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void randevuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personelGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doktorGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hemşireGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
