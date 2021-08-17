using SistemKayit.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKayit.Concrete
{
    public class CampanyManager:ICampanyService
    {
        public void Add(Campany campany)
        {
            Console.WriteLine("{0} adlı kampanya oluşturuldu.",campany.CampanyName);
        }
        public void Update(Campany campany)
        {
            Console.WriteLine("{0} adlı kampanya güncellendi.", campany.CampanyName);
        }
        public void Delete(Campany campany)
        {
            Console.WriteLine("{0} adlı kampanya silindi.", campany.CampanyName);
        }
    }
}
