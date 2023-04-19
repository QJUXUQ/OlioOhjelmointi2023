using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Kissa : Nisakkaat //luokan nimi
    {

        public void Kehraa() 
        {
            Console.WriteLine("Mjiu Mjau Purrnau");
        }
        public override void Aantele()
        {
            Console.WriteLine("Mjau!");
        }
    }
        
    }


