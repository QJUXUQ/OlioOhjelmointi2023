using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velka
{
    internal class Velka
    {
        private double _saldo;
        private double _korkoprosentti;

        public Velka(double saldoAlussa, double korkoProsentti) 
        {
        this._saldo = saldoAlussa;
        this._korkoprosentti = korkoProsentti;  
        }

        public void TulostaSaldo() 
        {
            Console.WriteLine(Saldo); //tulostaa saldon
        }

        public void OdotaVuosi() 
        {
           Console.WriteLine(_saldo =_saldo*(1+_korkoprosentti)); //kasvattaa velan määrää
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }

        public double Korko
        {
            get
            {
                return _korkoprosentti;
            }
            set
            {
                _korkoprosentti = value;
            }
        }
    }
}
