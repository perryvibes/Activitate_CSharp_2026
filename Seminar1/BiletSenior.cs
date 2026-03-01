using Seminar1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    public class BiletSenior : Bilet
    {
        private double reducereSenior = 0.3;
        public int VarstaClient { get; set; }
        public BiletSenior(string _numeFilm, int _NumarSala, TipFilm _tipFilm, DateTime _ExpiraLa, Client _Client, int _NumarLoc, double _PretBaza, int _varstaClient)
            : base(_numeFilm, _NumarSala, _tipFilm, _ExpiraLa, _Client, _NumarLoc, _PretBaza)
        {
            if (_varstaClient < 60)
            {
                throw new ArgumentException("Varsta trebuie sa fie de cel putin 60 de ani!");
            }
            VarstaClient = _varstaClient;
        }
        public override double GetReducere() => PretBaza * reducereSenior;
        public override bool EsteValabil() => base.EsteValabil();
    }
}
