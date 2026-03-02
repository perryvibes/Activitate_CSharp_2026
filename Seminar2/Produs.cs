using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    public class Produs
    {
        public string Nume { get; set; }
        public decimal Pret { get; set; }
        public int Cantitate { get; set; }

        public Produs(string _nume, decimal _pret, int _cantitate)
        {
            Nume = _nume;
            Pret = _pret;
            Cantitate = _cantitate;
        }
    }
}
