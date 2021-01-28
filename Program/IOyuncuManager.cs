namespace Odev5
{
    public interface IOyuncuManager
    {
        public void KayıtOl(Oyuncu oyuncu);
        public void Sil(Oyuncu oyuncu);
        public void Guncelle(Oyuncu oyuncu);
        public void OyunAl(Oyuncu oyuncu, string OyunAdi);
    }
}