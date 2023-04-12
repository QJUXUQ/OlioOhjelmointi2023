namespace Velka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Velka laina = new Velka(1000, 0.05); //tehtävän esimerkissä oli 5 eikä 0,05
            laina.TulostaSaldo();
            laina.OdotaVuosi();
            laina.TulostaSaldo();
        }
    }
}