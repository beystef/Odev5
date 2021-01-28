using System;

namespace Odev5
{
    public class OyuncuManager : IOyuncuManager
    {
        IKimlikDogrulamaServisi _mernisDogrulamaSistemi;
        public OyuncuManager(IKimlikDogrulamaServisi mernisDogrulamaSistemi)
        {
            _mernisDogrulamaSistemi = mernisDogrulamaSistemi;
        }
        public void Guncelle(Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.FName + " adlı oyuncumuzun bilgileri güncellendi.");
        }

        public void KayıtOl(Oyuncu oyuncu)
        {
            if (_mernisDogrulamaSistemi.Dogrula(oyuncu))
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Kayıt Başarılı");
            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Kayıt Başarısız -Doğrulama Sağlanamadı-");
            }
        }

        public void OyunAl(Oyuncu oyuncu, string OyunAdi)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Satın alma işlemi gerçekleştirildi.\n" + oyuncu.FName + " adlı oyuncumuzun hesabına " + OyunAdi + " oyunu eklendi");
        }

        public void Sil(Oyuncu oyuncu)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine(oyuncu.FName + " adlı oyuncumuzun silme işlemi gerçekleştirişdi.");
        }
    }
}