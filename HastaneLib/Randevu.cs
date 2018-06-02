using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneLib
{
    public class Randevu:Insan
    {
        private Doktor _doktor;
        private Hasta _hasta;
        private string _saat;

        public Doktor Doktor
        {
            get
            {
                return _doktor;
            }

            set
            {
                _doktor = value;
            }
        }

        public Hasta Hasta
        {
            get
            {
                return _hasta;
            }

            set
            {
                _hasta = value;
            }
        }

        public string Saat
        {
            get
            {
                return _saat;
            }

            set
            {
                _saat = value;
            }
        }

        //public override string ToString() => $"{Ad}-{Soyad}";

    }
    
}
