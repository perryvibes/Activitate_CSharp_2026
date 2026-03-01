using Seminar1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    public class BiletVIP : Bilet
    {
        public bool IncludePopcorn { get; set; }
        public bool IncludeBautura { get; set; }
        public BiletVIP(string _numeFilm, int _NumarSala, TipFilm _tipFilm, DateTime _ExpiraLa, Client _Client, int _NumarLoc, double _PretBaza, bool _popcorn, bool _bautura)
            : base(_numeFilm, _NumarSala, _tipFilm, _ExpiraLa, _Client, _NumarLoc, _PretBaza)
        {
            IncludePopcorn = _popcorn;
            IncludeBautura = _bautura;
        }
        public double GetExtras()
        {
            double total = 0;
            if (IncludePopcorn) total += 15;
            if (IncludeBautura) total += 10;
            return total;
        }
        public override double CalculeazaPretFinal() => PretBaza + GetExtras();
    }
}
