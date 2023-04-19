using ElainLuokat;
namespace Periytyminen
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kissa kissa = new Kissa();
            kissa.AsetaElaimenNimi("Pucci");
            kissa.AsetaElaimenlka(12);
            kissa.AsetaOnLihanSyoja(true);
            Console.WriteLine(kissa.PalautaElaimenNimi()+" "+kissa.PalautaElaimenIka()+" "+kissa.PalautaOnLihanSyoja());
            kissa.Kehraa();
            Console.ReadLine();

            Koira koira = new Koira();
            koira.AsetaElaimenNimi("Buck");
            koira.AsetaElaimenlka(17);
            koira.AsetaOnLihanSyoja(true);
            Console.WriteLine(koira.PalautaElaimenNimi() + " " + koira.PalautaElaimenIka() + " " + koira.PalautaOnLihanSyoja());
            Console.WriteLine(koira.haukku);
            koira.Aantele();
            kissa.Aantele();
            //Elain elain= new Elain();
            //Nisakkaat nisakas= new Nisakkaat();
            //elain.Aantele();
            //nisakas.Aantele();
            //Elain oliota ei pysty enää tekemään joten on kommenttiosioon laitettu

            Koira koiru = new Koira();
            koiru.setMilk(true);
            Console.WriteLine(koiru.getMilk());

            Papukaija papukaija = new Papukaija();
            papukaija.AsetaElaimenNimi("Kaakattaja");
            papukaija.AsetaElaimenlka(3);
            papukaija.setCanFly(true);
            Console.WriteLine("Papukaija: "+papukaija.PalautaElaimenNimi()+" "+papukaija.PalautaElaimenIka()+" "+ papukaija.getCanFly());

            koiru.AsetaElaimenNimi("Nami");
            koiru.AsetaElaimenlka(1);
            Console.WriteLine("Koira: "+koiru.PalautaElaimenNimi()+" "+koiru.PalautaElaimenIka()+" "+koiru.getMilk());



            Console.ReadLine();


        }
    }
}