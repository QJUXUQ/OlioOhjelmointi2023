using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Kissa //luokan nimi
    {
        private int age=0; //atribuutit
        public string Name="Miuku";

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
        public int PalautaKissanIka() 
        {
        return age;
        }
        
        // Luokan arvon palauttaminen:
        
        public void SetKissanNimi(string uusiNimi) 
        {
            bool nameCheck;
            
            
            if (uusiNimi.ContainsCaseInsensitive("Hilda")==true)
            {
                nameCheck = true;

            }
            else 
            {
                nameCheck = false;
                Name=uusiNimi;
                
            }
             

           
        }

        public override string ToString()
        {
            return "Kissa: "+this.Name+" "+this.age;
        }
    }
        
    }


