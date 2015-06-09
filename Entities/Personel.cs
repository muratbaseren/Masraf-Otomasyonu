using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Personel
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string EPosta { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public bool AktifMi { get; set; }
        public int? SorumlusuId { get; set; }
        public byte PersonelTurId { get; set; }
        
    }
}
