using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKayit.Abstract
{
    public interface IGameDeveloperService
    {
        void Save(GameDeveloper gameDeveloper);
        void Update(GameDeveloper gameDeveloper);
        void Delete(GameDeveloper gameDeveloper);
    }
}
