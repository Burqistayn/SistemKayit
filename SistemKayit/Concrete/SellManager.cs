using SistemKayit.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKayit.Concrete
{
    class SellManager : ISellService
    {
        public void ToSell(Game game)
        {
            Console.WriteLine("{0} adlı oyunun satışı yapıldı.",game.GameName);
        }
    }
}
