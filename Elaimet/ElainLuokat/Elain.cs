using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Elain
    {
        private int age; //atribuutit
        public string Name;
        private bool OnLihanSyoja;
        public Elain() // Parametriton Konstruktori
        {

        }
        public Elain(int age, string name)  //Parametrillinen Konstruktori joka asettaa iän ja nimen
        {
            this.age = age;
            this.Name = name;
        }

        public void AsetaElaimenlka(int newAge) 
        {
            if(newAge >= 0) 
            {
                this.age = newAge;
            }
        }

        public void AsetaElaimenNimi(string newname) 
        {
            this.Name = newname;
        }

        public int PalautaElaimenIka() 
        {
            return this.age;
        }

        public string PalautaElaimenNimi() 
        {
            return this.Name;
        }

        public void AsetaOnLihanSyoja(bool eatMeat)
        {
            this.OnLihanSyoja = eatMeat;
           
        }

        public bool PalautaOnLihanSyoja() 
        {
            return this.OnLihanSyoja;
        }
        public virtual void Aantele() 
        {
            Console.WriteLine("Umph!");
        }

    }
}
