using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersBilgileri
{
    public class FileOperations : IOperations
    {
        string _path = "";
        public List<Ders> GetDersler()
        {
            List<Ders> dersler = new List<Ders>();
            _path = Application.StartupPath; // C:\Projelerim\DersBilgileri\DersBilgileri\bin\Debug  exe bu path i döner 
            _path = _path.Replace(@"\bin\Debug", @"\Files") + @"\Dersler.txt";
            IEnumerable<string> dersSatirlari = File.ReadLines(_path);
            Ders ders;
            foreach (var dersSatiri in dersSatirlari)
            {
                ders = new Ders();
                ders.Id = Convert.ToInt32(dersSatiri.Split(';')[0]);
                ders.Adi = dersSatiri.Split(';')[1];
                ders.Kategorisi = (KategoriEnum)Convert.ToInt32(dersSatiri.Split(';')[2]);
                ders.Icerigi = dersSatiri.Split(';')[3];
                ders.Kredisi = Convert.ToByte(dersSatiri.Split(';')[4]);
                dersler.Add(ders);
            }

            return dersler;
        }

        public void AddDers(Ders ders)
        {

        }

        public void AddDersler(Ders ders)
        {
            throw new NotImplementedException();
        }
    }
}
