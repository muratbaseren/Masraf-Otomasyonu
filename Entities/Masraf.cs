using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Masraf
    {
        public Guid Id { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; }
        public int PersonelId { get; set; }
        public byte DurumId { get; set; }
    }
}
