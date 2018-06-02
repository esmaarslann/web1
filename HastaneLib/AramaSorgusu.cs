using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneLib
{
   public static class AramaSorgusu<T>where T:Insan

    {
        public static List<T> Ara(List<T> kisiler, string kelime)
        {
            List<T> sonuclar = new List<T>();
            sonuclar = kisiler.Where(item => item.Ad.ToLower().Contains(kelime.ToLower()) || item.Soyad.ToLower().Contains(kelime.ToLower()) || item.Tckn.Contains(kelime)).ToList();
            return sonuclar;
        }
    }
}
