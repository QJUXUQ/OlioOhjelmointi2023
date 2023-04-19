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
            

        }
        public bool getMilk() 
        {
            return produceMilk;
            

        }
    }
}
