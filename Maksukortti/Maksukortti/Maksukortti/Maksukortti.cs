using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maksukortti
{
    internal class Maksukortti
    {
        private double saldo;

        public Maksukortti(double alkusaldo) 
        {
            this.saldo = alkusaldo;
        }
        public override string ToString()
        {
            return "Kortilla on rahaa "+this.saldo+" euroa";
        }

        public void syoEdullisesti() 
        {
            if (saldo > 2.60)
            {
                this.saldo = saldo - 2.60;
            }
            

        }

        public void syoMaukkaasti() 
        {
            if (saldo > 4.60)
            {
                this.saldo = saldo - 4.60;
            } 

        }
        
        public void LataaRahaa(double raha) 
        {
            
            
            if (raha > 0)
            {
                saldo += raha;
            }
        }   
    }
}
