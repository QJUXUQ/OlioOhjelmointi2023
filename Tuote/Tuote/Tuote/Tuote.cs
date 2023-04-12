using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuote
{
    internal class Tuote
    {
        private string nimi;
        private double hinta;
        private int maara;

        public Tuote() 
        {
            nimi = "Banaani";
            hinta = 1.1;
            maara = 13;
        }  
        public Tuote(string nimiAlussa, double hintaAlussa, int maaraAlussa)
        {

            this.nimi = nimiAlussa;
            this.hinta = hintaAlussa;
            this.maara = maaraAlussa;
        }

        public void TulostaTuote()
        {
            Console.WriteLine(Nimi+", hinta "+Hinta+" "+Maara+" kpl");
        }
        public string Nimi 
        {
        get { return nimi; }
        set { nimi = value; }
        }
        public double Hinta
        {
        get 
            {
                return hinta;
            }
            set 
            {
                hinta = value; 
            }

        }
        public int Maara 
        {
            get { return maara; }
            set { maara = value; }  
        }

    }
    
    }

