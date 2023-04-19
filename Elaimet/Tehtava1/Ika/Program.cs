using ElainLuokat;
using System.Security.Cryptography.X509Certificates;

namespace Ika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Random random = new Random();
            
            do 
            {
                Koira koira = new Koira();
                koira.AsetaKoiranIka(random.Next(15));
                Kissa kissa=new Kissa();
                kissa.AsetaKissanIka(random.Next(10));

                Console.WriteLine("Koira on: " + koira.PalautaKoiranIka() + " vuotta, Kissa on: " + kissa.PalautaKissanIka() + " vuotta");

                if (koira.PalautaKoiranIka() > kissa.PalautaKissanIka())
                {
                    Console.WriteLine("Koira on vanhempi");
                }
                else if(koira.PalautaKoiranIka() < kissa.PalautaKissanIka())
                     
                {
                    Console.WriteLine("Kissa on vanhempi");
                }


                x++;
            }

            while (x < 10);
            

        }
    }
}