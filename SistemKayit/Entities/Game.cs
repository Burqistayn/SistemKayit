using SistemKayit.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKayit
{
    public class Game:IEntity
    {
        public string GameName { get; set; }
        public double GamePrice { get; set; }
        public string GameCategory { get; set; }
    }
}
