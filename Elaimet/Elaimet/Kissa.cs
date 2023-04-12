using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    internal class Kissa //luokan nimi
    {
        private int age; //atribuutit
        public string Name;

        public Kissa() // Parametriton Konstruktori
        {
        
        }
        public Kissa(int age,string name)  //Parametrillinen Konstruktori joka asettaa iän ja nimen
        {
            this.age = age;
            this.Name = name;
        }
        
        public void AsetaKissanNimi(string name) //metodi
        {
        this.Name=name;
        }
        
        public string PalautaKissanNimi()  
        {
        return this.Name;
        }
        public void AsetaKissanIka(int age) //metodi
        {
            this.age = age;
        }
        public int PalautaKissanIka() 
        {
        return age;
        }
    }
}
