using SistemKayit.Abstract;
using SistemKayit.Concrete;
using System;

namespace SistemKayit
{
    class Program
    {
        static void Main(string[] args)
        {
            GameDeveloper gameDeveloper1 = new GameDeveloper();
            gameDeveloper1.FirstName = "herhangi bir isim";
            gameDeveloper1.LastName = "herhangi bir soyad";
            gameDeveloper1.NickName = "Engin_Hoca_Fan_123";

            Game game1 = new Game();
            game1.GameName = "Flappy Bird";

            Campany campany1 = new Campany();
            campany1.CampanyName = "Kışa özel %50 indirim";

            GameDeveloperManager gameDeveloperManager = new GameDeveloperManager(new UserVerificationManager());
            gameDeveloperManager.Save(gameDeveloper1);

            CampanyManager campanyManager = new CampanyManager();
            campanyManager.Add(campany1);

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            SellManager sellManager = new SellManager();
            sellManager.ToSell(game1);
        }
    }
}
