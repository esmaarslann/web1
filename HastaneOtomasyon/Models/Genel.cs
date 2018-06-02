using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon.Models
{
    class Genel
    {
       
        public static string connStr = "Server =DESKTOP-AO7HTN4\\SQLEXPRESS; initial Catalog = HastaneOtomasyon; Trusted_Connection=True; ";
        //public static int SeciliKlinikNo;
        //public static string SeciliKlinikAd;
        //public static int  SeciliRandevuSure;
        //public static string SeciliAciklama;
        //public static string[] SeciliNesne;
        public static string SeciliTcKimlikNo;
        public static string SeciliHastaAd;
        public static string SeciliHastaSoyad;
        //public static string SeciliKlinik;
       // public static string SeciliHekim;
        public static string SeciliCinsiyet;
        public static DateTime SeciliDogumTarihi;
        public static int SeciliHastaID;

        
        public static string RandevuTarih;
        public static string RandevuSaat;

        public static string PersonelAdi;
        public static string PersonelSoyadi;
        public static string KlinikAdi;
        public static int KlinikID;
        public static int PersonelID;
        public static int UnvanID;
        public static int HekimID;
        internal static int sicilNo;
        internal static string unvanad;
        internal static string klinikad;
        internal static int diploma;
        internal static string adres;
        internal static string evTel;
        internal static string cepTel;
        internal static string dogumYeri;
        internal static DateTime dogumTarihi;
        internal static string kullaniciad;
        internal static string sifre;
    }
}
