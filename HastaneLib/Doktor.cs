using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneLib
{
    public class Doktor : Saglik
    {
        public string Saat { get; set; } = "";
        public List<Hemsire> hemsiresi { get; set; } = new List<Hemsire>();
        public override string ToString() => $"{Ad}-{Soyad}-{Cinsiyet}-{Tckn}-{Brans}";
    }
}
