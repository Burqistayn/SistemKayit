using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKayit.Abstract
{
    public interface IUserVerificationService
    {
        bool Verification(GameDeveloper gameDeveloper);
    }
}
