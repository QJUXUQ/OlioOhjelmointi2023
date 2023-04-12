namespace Tuote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuote Banaani = new Tuote();
            Banaani.TulostaTuote();
            
            // Tässä tarkastan että koodi toimii myös jos lisää tuotteita kauppaan ihan vain huvikseni

            Tuote Omena = new Tuote("Omena",2.5,45);
            Omena.TulostaTuote();
            Console.ReadLine();
        }
    }
}