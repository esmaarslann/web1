using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneLib
{
    public class Hasta : Insan
    {
        public string Saat { get; set; } = "";
        public override string ToString() => $"{Ad}-{Soyad}-{Cinsiyet}-{Tckn}";
    }
}
