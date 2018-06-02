using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneLib
{
    public class Saglik : Idari
    {
        private Brans _branş;

        public Brans Brans
        {
            get
            {
                return _branş;
            }

            set
            {
                _branş = value;
            }
        }
    }
    public enum Brans
    {
        Dahiliye, KulakBurunBoğaz, Göz, Diş
    }
}
