using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
  
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio Main -metodissa
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5. Tulosta olion tiedot nyt näytölle.
  
   
**/
namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tässä luot luokasta olion
            Hevonen Hevonen1 = new Hevonen();
            Hevonen1.Nimi = "Histamiini";
            Hevonen1.Paino = 89;
            //Tulosta olion nimi ja paino
            Console.WriteLine(Hevonen1.Nimi + " " + Hevonen1.Paino);
            
            //Muuta olion nimeä ja painoa
            Hevonen1.Nimi = "Kars";
            Hevonen1.Paino = 79;
            //Tulosta nyt olion nimi ja paino, jotta varmistat että muutos tapahtui
            Console.WriteLine(Hevonen1.Nimi);
            Console.WriteLine(Hevonen1.Paino);
            

            Kissa Cat1 = new Kissa();
            Cat1.Name = "Inni";
            Console.WriteLine(Cat1.Name);
            
            Cat1.AsetaKissanNimi("Lunu");
            Console.WriteLine(Cat1.PalautaKissanNimi());
            
            Cat1.AsetaKissanIka(13);
            Console.WriteLine(Cat1.PalautaKissanIka());
            Console.ReadLine();
            
            Kissa Cat2=new Kissa(7,"Miu");
            Console.WriteLine(Cat2.PalautaKissanNimi() + " "+ Cat2.PalautaKissanIka());
            Console.ReadLine();

        }
    }
}
