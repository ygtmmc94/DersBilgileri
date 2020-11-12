using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersBilgileri
{
    public class DersService
    {
        
       readonly IOperations  _operations;

       public DersService(IOperations operations)
       {
           _operations = operations;
       }
        public List<Ders> List()
        {
            return _operations.GetDersler();
        }

        public void Add(Ders ders)
        {
            _operations.AddDersler(ders);
        }
    }
}
