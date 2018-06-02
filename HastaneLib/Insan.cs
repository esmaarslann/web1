using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HastaneLib
{
   public abstract class Insan
    {
        private string _ad,_soyad,_tckn,_telefon,_mail;
        private DateTime _dgmtarihi;
        private Cinsiyetler _cinsiyet;

        public string Ad
        {
            get
            {
                return _ad;
            }

            set
            {
                _ad =AdSoyadHazirla(value);
            }
        }

        public string Soyad
        {
            get
            {
                return _soyad;
            }

            set
            {
                _soyad = AdSoyadHazirla(value);
            }
        }

        public string Tckn
        {
            get
            {
                return _tckn;
            }

            set
            {
                if(!(value.Length==11))
                { throw new Exception("Tc bilgisi hatalı"); }
                foreach (char item in value)
                {
                    if (!char.IsDigit(item))
                        throw new Exception("Tckn bilgisi hatalı");
                }
                _tckn = value;
            }
        }

        public string Telefon
        {
            get
            {
                return _telefon;
            }

            set
            {
                if (!(value.Length == 10) && value.StartsWith("0")&&!(value.StartsWith("5")))
                    throw new Exception("Eksik veya Hatalı giriş yaptınız");
                /*foreach (char item in value)
                {
                    if (!char.IsDigit(item))
                        throw new Exception("Rakam dışında bir şey girilemez");
                }*/
                    
                _telefon = value.Replace("(", "").Replace(")", "").Replace(" ", "");
            }
        }

        public string Mail
        {
            get
            {
                return _mail;
            }

            set
            { Regex rgx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = rgx.Match(value);
                if(!match.Success)
                 throw new Exception("Hatalı formatta mail girdiniz"); 
                _mail = value;

                
            }
        }

        public DateTime Dgmtarihi
        {
            get
            {
                return _dgmtarihi;
            }

            set
            {
                _dgmtarihi = value;
            }
        }

        public Cinsiyetler Cinsiyet
        {
            get
            {
                return _cinsiyet;
            }

            set
            {
                _cinsiyet = value;
            }
        }

       

        private string AdSoyadHazirla(string ad)
        {
            string name = string.Empty;
            string[] adlar = ad.Split(' ');
            if (adlar.Length > 3)
                throw new Exception("Üçten fazla isim kaydedemzsiniz");
            foreach(var item in adlar)
            {
                foreach (var harf in item)
                {
                    if(!char.IsLetter(harf))
                        throw new Exception("İsimlerinizde sayı ya da özel karakter bulunamaz.");
                }
                name += ad.Substring(0, 1).ToUpper() + ad.Substring(1).ToLower() + " ";
            }
            name = name.Trim();
            return name;
        }

       
    }
    
    public enum Cinsiyetler
    {
        Erkek,Kadin
    }
}