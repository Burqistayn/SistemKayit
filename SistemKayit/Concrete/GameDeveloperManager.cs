using SistemKayit.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKayit
{
    public class GameDeveloperManager:IGameDeveloperService
    {
        IUserVerificationService _userVerificationService;
        public GameDeveloperManager(IUserVerificationService userVerificationService)
        {
            _userVerificationService = userVerificationService;
        }
        public void Save(GameDeveloper gameDeveloper)
        {
            if (_userVerificationService.Verification(gameDeveloper)==true)
            {
                Console.WriteLine("{0} takma adlı oyun yapımcısının kaydı yapıldı",gameDeveloper.NickName);
            }
            else
            {
                Console.WriteLine("Girilmiş olan insan gerçek değil");
            }
        }

        public void Update(GameDeveloper gameDeveloper)
        {
            Console.WriteLine("{0} takma adlı oyun yapımcısının kaydı güncellendi", gameDeveloper.NickName);
        }

        public void Delete(GameDeveloper gameDeveloper)
        {
            Console.WriteLine("{0} takma adlı oyun yapımcısının kaydı silindi", gameDeveloper.NickName);
        }
    }
}
