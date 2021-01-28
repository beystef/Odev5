using System;

namespace Odev5
{
    public class KampanyaManager:IKampanyaManager
    {
        public void Ekle(string kampanya)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine(kampanya + "kampanyası sisteme eklendi");
        }
        public void Sil(string kampanya)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine(kampanya + "kampanyası sistemden silindi");
        }
        public void Guncelle(string kampanya)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine(kampanya + "kampanyası güncellendi.");
        }
    }
}