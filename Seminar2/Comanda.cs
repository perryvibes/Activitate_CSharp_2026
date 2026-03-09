using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    public class Comanda
    {
        private static int _counter = 0;
        public string NumarComanda { get; }
        public string NumeClient { get; }
        public string EmailClient { get; }
        public List<Produs> Produse { get; }
        public StareComanda Stare { get; set; }
        public DateTime DataPlasata { get; }

        public Comanda(string _numeClient, string _email)
        {
            NumarComanda = $"CMD-{_counter++:d3}";
            NumeClient = _numeClient;
            EmailClient = _email;
            Produse = new List<Produs>();
            Stare = StareComanda.Plasata;
            DataPlasata = DateTime.Now;
        }
        public decimal GetValoareTotala()
        {
            return Produse.Sum(produs => produs.Cantitate * produs.Pret);
        }
        public void AdaugaProdus(Produs produs)
        {
            Produse.Add(produs);
        }
        public override string ToString()
        {
            return $"Numar: {NumarComanda} | Client: {NumeClient} " +
                $"| Valoare:{GetValoareTotala()}";
        }

    }
}
