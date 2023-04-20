using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Nisakkaat : Elain
    {
        private bool produceMilk;

        public void setMilk(bool milk) 
        {
            this.produceMilk = milk;
            
            if (milk)
            {
                Console.WriteLine("Can produce milk"); //Alkuperäisesti tein tällaista lisähommaa nisäkkäiden ja lintujen attribuutteihin mutta en saanut sitä toimimaan syystä x
            }
            else                                        //mutta halusin lisätä tämän kuitenkin extrana tänne tehtävääni.
            {
                Console.WriteLine("Can't produce milk");
            }
            


        }
        public bool getMilk() 
        {
            
            return produceMilk;
            

        }
    }
}
