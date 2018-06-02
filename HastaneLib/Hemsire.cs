using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneLib
{
    public class Hemsire : Saglik
    {
        public bool atanmısMı { get; set; } = false;
        public Doktor atananDoktor { get; set; }
        public override string ToString() => $"{Ad}-{Soyad}-{Cinsiyet}-{Tckn}-{Brans}";
    }
}