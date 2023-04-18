using System;

namespace Maksukortti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maksukortti kortti = new Maksukortti(50);
            Console.WriteLine(kortti);
            kortti.syoEdullisesti();
            Console.WriteLine(kortti);
            kortti.syoMaukkaasti();
            kortti.syoEdullisesti();
            Console.WriteLine(kortti);

            //Negatiivinen saldo

            Maksukortti kortti2 = new Maksukortti(5);
            Console.WriteLine(kortti2);
            kortti2.syoMaukkaasti();
            Console.WriteLine(kortti2);
            kortti2.syoMaukkaasti();
            Console.WriteLine(kortti2);

            //Kortin lataaminen

            Maksukortti kortti3= new Maksukortti(0); 
            kortti3.LataaRahaa(10);
            Console.WriteLine(kortti3);
            kortti3.LataaRahaa(25);
            Console.WriteLine(kortti3);
            kortti3.LataaRahaa(35);
            Console.WriteLine(kortti3);
            kortti3.LataaRahaa(235);
            Console.WriteLine(kortti3);

            //Kortin lataaminen negatiivisella arvolla

            Maksukortti kortti4 = new Maksukortti(10);
            Console.WriteLine("Pekka: " + kortti4);
            kortti4.LataaRahaa(-15);
            Console.WriteLine("Pekka: " + kortti4);

            //Monta korttia

            Maksukortti pekankortti= new Maksukortti(20);   
            Maksukortti matinkortti= new Maksukortti(30);
            pekankortti.syoMaukkaasti();
            matinkortti.syoEdullisesti();
            Console.WriteLine("Pekka: "+pekankortti);
            Console.WriteLine("Matti: "+matinkortti);
            pekankortti.syoEdullisesti();
            matinkortti.syoEdullisesti();
            matinkortti.LataaRahaa(50); 
            Console.WriteLine("Pekka: " + pekankortti);
            Console.WriteLine("Matti: " + matinkortti);

            Console.ReadLine();
        }
    }
}
