using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Models
{
    class HastaHizmetHareketler
    {
        private int _hareketID;
        private int _kabulID;
        private int _tahlilID;
        private int _hizmetID;
        private DateTime _tarih;
        private double _tutar;
        private string _aciklama;

        #region Properties
        public int HareketID
        {
            get
            {
                return _hareketID;
            }

            set
            {
                _hareketID = value;
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

        public int TahlilID
        {
            get
            {
                return _tahlilID;
            }

            set
            {
                _tahlilID = value;
            }
        }

        public int HizmetID
        {
            get
            {
                return _hizmetID;
            }

            set
            {
                _hizmetID = value;
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

        public double Tutar
        {
            get
            {
                return _tutar;
            }

            set
            {
                _tutar = value;
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
