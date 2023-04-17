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

        // aikaisemmassa erässä käytin tätä koodipätkää, mutta koodi toimii ilman tätäkin. Kommentiksi laitettu päivityksen kommentoimiseksi.

        //public string returnSound
        //{

        //    get
        //    {
        //        return _aani;
        //    }
        //    set
        //    {
        //        _aani = value;
        //    }
        //}

        }
}
