using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Linnut : Elain
    {
        private bool wings;

        public void setCanFly(bool canFly) 
        {

            this.wings = canFly;

            if (canFly)
            {
                Console.WriteLine("Can fly");
            }
            else
            {
                Console.WriteLine("Can't fly");
            }
        }

        public bool getCanFly() 
        {
            return this.wings;
        }
    }
}
