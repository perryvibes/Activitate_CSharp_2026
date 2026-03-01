using Seminar1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    public enum TipFilm
    {
        Comedie,
        Actiune,
        Drama,
        Istoric
    }
    public class Bilet : IPretCalculabil, IValidabil
    {
        public string NumeFilm { get; set; }
        public int NumarSala { get; set; }
        public TipFilm TipFilm { get; set; }
        public DateTime ExpiraLa { get; set; }
        public Client Client { get; set; }
        private int numarLoc { get; set; }
        public int NumarLoc
        {
            get => numarLoc;
            set
            {
                if (value <= 1 || value >= 200)
                {
                    throw new ArgumentException("Locul trebuie sa fie intre 1 si 200 inclusiv.");
                }
                numarLoc = value;
            }
        }
        private double pretBaza { get; set; }
        public double PretBaza
        {
            get => pretBaza;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Pretul trebuie sa fie mai mare decat 0!");
                }
                pretBaza = value;
            }
        }
        public Bilet(string _numeFilm, int _NumarSala, TipFilm _tipFilm, DateTime _ExpiraLa, Client _Client, int _NumarLoc, double _PretBaza)
        {
            NumeFilm = _numeFilm;
            NumarSala = _NumarSala;
            TipFilm = _tipFilm;
            ExpiraLa = _ExpiraLa;
            Client = _Client;
            NumarLoc = _NumarLoc;
            PretBaza = _PretBaza;
        }
        public virtual double GetReducere() => throw new NotImplementedException();
        public virtual double CalculeazaPretFinal() => PretBaza - GetReducere();
        public virtual bool EsteValabil() => DateTime.Now < ExpiraLa;

    }
}
