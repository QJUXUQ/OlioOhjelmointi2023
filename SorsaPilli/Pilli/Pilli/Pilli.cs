using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilli
{
    internal class Pilli
    {
        private string _aani;

        public Pilli(string pilliAani)
        {
            this._aani = pilliAani;

        }

        public void Soi()
        {
            
            Console.WriteLine(_aani);

        }
        public string returnSound
        {

            get
            {
                return _aani;
            }
            set
            {
                _aani = value;
            }
        }

        }
}
