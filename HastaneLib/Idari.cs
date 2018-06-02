using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneLib
{
    public class Idari : Insan, IMaasAlabilir
    {
        private decimal _maas;

        public decimal Maas
        {
            get
            {
                return _maas;
            }

            set
            {
                _maas = value;
            }
        }
    }
}