using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersBilgileri
{
    public class Ders
    {
        public int Id { get; set; }
        public string Adi { get; set; }

        public KategoriEnum Kategorisi { get; set; }
        public string Icerigi { get; set; }
        public byte Kredisi { get; set; }

    }
}
