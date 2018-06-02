using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Models
{
    class Odemeler
    {
        private int _odemeID;
        private int _kabulID;
        private DateTime _tarih;
        private int _odemeTuru;
        private double _toplam;
        private double _indirim;
        private double _net;
        private string _aciklama;

        #region Properties
        public int OdemeID
        {
            get
            {
                return _odemeID;
            }

            set
            {
                _odemeID = value;
            }
        }

        public int KabulID
        {
            get
            {
                return _kabulID;
            }

            set
            {
                _kabulID = value;
            }
        }

        public DateTime Tarih
        {
            get
            {
                return _tarih;
            }

            set
            {
                _tarih = value;
            }
        }

        public int OdemeTuru
        {
            get
            {
                return _odemeTuru;
            }

            set
            {
                _odemeTuru = value;
            }
        }

        public double Toplam
        {
            get
            {
                return _toplam;
            }

            set
            {
                _toplam = value;
            }
        }

        public double Indirim
        {
            get
            {
                return _indirim;
            }

            set
            {
                _indirim = value;
            }
        }

        public double Net
        {
            get
            {
                return _net;
            }

            set
            {
                _net = value;
            }
        }

        public string Aciklama
        {
            get
            {
                return _aciklama;
            }

            set
            {
                _aciklama = value;
            }
        } 
        #endregion
    }
}
