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
        }

        public bool getCanFly() 
        {
            return this.wings;
        }
    }
}
