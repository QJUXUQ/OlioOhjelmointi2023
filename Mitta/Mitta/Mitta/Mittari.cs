using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mitta
{
    internal class Mittari
    {
        private int _mitta;

        public Mittari() 
        {
            _mitta=0;
        }
        public void Lisaa() 
        {
            if (_mitta<5) 
            {
                _mitta++; 
            } 
        }

        public void Vahenna() 
        {
            if ( _mitta>0) 
            {
                _mitta--;
            }
        }

        public int Mitta() 
        {
            return _mitta;
        }

        public Boolean Taynna() 
        {
            if (_mitta == 5)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
