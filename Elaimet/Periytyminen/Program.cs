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

            Console.ReadLine();


        }
    }
}