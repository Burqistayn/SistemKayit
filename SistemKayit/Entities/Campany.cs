using SistemKayit.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKayit
{
    public class Campany:IEntity
    {
        public string CampanyName { get; set; }
        public string CampanyPrice { get; set; }
    }
}
