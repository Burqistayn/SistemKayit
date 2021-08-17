using SistemKayit.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKayit.Concrete
{
    class UserVerificationManager : IUserVerificationService
    {
        public bool Verification(GameDeveloper gameDeveloper)
        {
            if (gameDeveloper.FirstName == "herhangi bir isim" && gameDeveloper.LastName == "herhangi bir soyad")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
