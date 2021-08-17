using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKayit.Concrete
{
    public class GameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} adlı oyun yüklendi.", game.GameName);
        }
        public void Update(Game game)
        {
            Console.WriteLine("{0} adlı oyun güncellendi.", game.GameName);
        }
        public void Delete(Game game)
        {
            Console.WriteLine("{0} adlı oyun silindi.", game.GameName);
        }
    }
}
