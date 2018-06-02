using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneLib
{
    public class HemsireSorgu
    {
        public static List<Hemsire> hemsireSorgu(List<Hemsire> hemsireler, string bransi) 
        {
            List<Hemsire> uygunHemsireler = hemsireler.Where(x => Convert.ToString(x.Brans) ==bransi).ToList();
              
            return uygunHemsireler;
        }
    }
}
