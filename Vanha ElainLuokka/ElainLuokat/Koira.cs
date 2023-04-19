using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Koira
    {
        private int age = 0; //atribuutit
        public string Name = "Haukkuli";

        public Koira() // Parametriton Konstruktori
        {

        }
        public Koira(int age, string name)  //Parametrillinen Konstruktori joka asettaa iän ja nimen
        {
            this.age = age;
            this.Name = name;
        }

        public void AsetaKoiranNimi(string name) //metodi
        {
            this.Name = name;
        }

        public string PalautaKoiranNimi()
        {
            return this.Name;
        }
        public void AsetaKoiranIka(int age) //metodi
        {
            bool ageCheck;


            if (age > 0)
            {
                ageCheck = true;
                this.age = age;
                Console.WriteLine("Tehtiin muutos");


            }
            else
            {


                ageCheck = false;
                Console.WriteLine("Ikään ei tehty muutosta");

            }



        }
        public int PalautaKoiranIka()
        {
            return age;
        }

        // Luokan arvon palauttaminen:

        public void SetKoiranNimi(string uusiNimi)
        {
            bool nameCheck;


            if (uusiNimi.ContainsCaseInsensitive("Musti") == true)
            {
                nameCheck = true;

            }
            else
            {
                nameCheck = false;
                Name = uusiNimi;

            }



        }

        public override string ToString()
        {
            return "Koira: " + this.Name + " " + this.age;
        }
    }
}
