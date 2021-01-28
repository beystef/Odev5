using System;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            OyuncuManager oyuncuManager = new OyuncuManager(new MernisDogrulamaSistemi());
            Oyuncu oyuncu1 = new Oyuncu()
            {
                IN = "123456",
                FName = "Enes",
                LName = "Pul",
                DOB = 2000
            };
            oyuncuManager.KayıtOl(oyuncu1);
            oyuncuManager.Guncelle(oyuncu1);
            oyuncuManager.Sil(oyuncu1);
            oyuncuManager.OyunAl(oyuncu1, "PUBG");
            Console.ReadLine();
            Oyuncu oyuncu2 = new Oyuncu()
            {
                IN = "1234567",
                FName = "Ahmet",
                LName = "Sarı",
                DOB = 1000
            };
            oyuncuManager.KayıtOl(oyuncu2);
            Console.ReadLine();
            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.Ekle("Savaş oyunlarında %50 indirim");
            kampanyaManager.Guncelle("Savaş oyunlarında %50 indirim");
            kampanyaManager.Sil("Savaş oyunlarında %50 indirim");
            Console.ReadLine();
        }
    }
}
