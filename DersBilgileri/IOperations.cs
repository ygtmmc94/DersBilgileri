using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersBilgileri
{
    public interface IOperations
    {
        List<Ders> GetDersler();
        void AddDers(Ders ders);
        void AddDersler(Ders ders);
    }
}
