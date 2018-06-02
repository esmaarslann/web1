using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entity
{
    public class Randevu
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public DateTime RandevuAlmaZamani { get; set; } = DateTime.Now;
        public int SiraNumarasi { get; set; }
        public Hasta Hasta { get; set; }
        public Doktor Doktor { get; set; }
        public Birimler Birim { get; set; }
    }
}
