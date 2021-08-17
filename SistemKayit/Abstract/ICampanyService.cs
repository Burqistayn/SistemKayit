using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKayit.Abstract
{
    public interface ICampanyService
    {
        public void Add(Campany campany);
        public void Update(Campany campany);
        public void Delete(Campany campany);
    }
}
