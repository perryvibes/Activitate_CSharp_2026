using Seminar1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    public class BiletStudent : Bilet
    {
        private double reducere = 0.2;
        public string NumarLegitimatie { get; set; }
        public string Facultate { get; set; }

        public BiletStudent(string _numeFilm, int _NumarSala, TipFilm _tipFilm, DateTime _ExpiraLa, Client _Client, int _NumarLoc, double _PretBaza, string _NrLegit, string _Facultate)
            : base(_numeFilm, _NumarSala, _tipFilm, _ExpiraLa, _Client, _NumarLoc, _PretBaza)
        {
            NumarLegitimatie = _NrLegit;
            Facultate = _Facultate;
        }
        public override bool EsteValabil() => base.EsteValabil() && string.IsNullOrEmpty(NumarLegitimatie);
        public override double GetReducere() => PretBaza * reducere;

    }
}
