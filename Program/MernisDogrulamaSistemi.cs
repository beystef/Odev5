namespace Odev5
{
    public class MernisDogrulamaSistemi : IKimlikDogrulamaServisi
    {
        public bool Dogrula(Oyuncu oyuncu)
        {
            if (oyuncu.DOB > 1500)
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