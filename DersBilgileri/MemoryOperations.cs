using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersBilgileri
{
    public class MemoryOperations : IOperations
    {
        static List<Ders> dersler = new List<Ders>()
        {
            new Ders()
            {
                Id = 1,
                Adi = "Matematik",
                Kategorisi = KategoriEnum.sayısal,
                Icerigi = "Dört İşlem",
                Kredisi = 5
            },

            new Ders()
            {
                Id = 2,
                Adi = "Tarih",
                Kategorisi = KategoriEnum.Sosyal,
                Icerigi = "Cumhuriyet",
                Kredisi = 4
            },

            new Ders()
            {
                Id = 1,
                Adi = "İngilizce",
                Kategorisi = KategoriEnum.Sosyal,
                Icerigi = "Gramer",
                Kredisi = 3
            }
        };
        public List<Ders> GetDersler()
        {
           
            return dersler;


        }


        public void AddDersler(Ders ders)
        {
            dersler.Add(ders);
        }

        public void AddDers(Ders ders)
        {
            throw new NotImplementedException();
        }
    }
}
