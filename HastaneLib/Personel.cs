using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneLib
{
    public class Personel : Idari
    {
        private Gorev _gorev;

        public Gorev Gorev
        {
            get
            {
                return _gorev;
            }

            set
            {
                _gorev = value;
            }
        }
        public override string ToString() => $"{Ad}-{Soyad}-{Cinsiyet}-{Tckn}-{Gorev}";
    }
    public enum Gorev
    {
        Muhasebe, Güvenlik, Temizlik, Yemek
    }
}
