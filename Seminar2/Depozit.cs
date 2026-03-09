using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    public class Depozit
    {
        public string Nume { get; set; }
        public event EventHandler<ComandaSchimbatStareEventArgs> ComandaSchimbatStare;
        public event EventHandler<ComandaLivrataEventArgs> ComandaLivrata;


        private List<Comanda> comenzi;
        public Depozit(string _nume)
        {
            Nume = _nume;
            comenzi = new List<Comanda>();
        }
        public void InregistreazaComanda(Comanda _comanda,
            NotificareClient _notificator = null)
        {
            comenzi.Add(_comanda);
            _notificator?.Invoke(_comanda.NumarComanda, "Comanda Inregistrata");
        }
        public void AvanseazaComanda(string _nrComanda)
        {
            var comanda = comenzi.FirstOrDefault(c => c.NumarComanda == _nrComanda);
            if (comanda == null) return;
            if (comanda.Stare == StareComanda.Livrata) return;

            var comandaSchimbatStareEventArgs = new ComandaSchimbatStareEventArgs()
            {
                Comanda = comanda,
                StareVeche = comanda.Stare
            };

            comanda.Stare = (StareComanda)((int)comanda.Stare + 1);

            comandaSchimbatStareEventArgs.StareNoua = comanda.Stare;
            OnComandaSchimbatStare(comandaSchimbatStareEventArgs);

            if (comanda.Stare == StareComanda.Livrata)
            {
                var comandaLivrataEventArgs = new ComandaLivrataEventArgs()
                {
                    Comanda = comanda,
                    DataLivrare = DateTime.Now
                };
                OnComandaLivrata(comandaLivrataEventArgs);
            }
        }
            
        public List<Comanda> GetComenziActive()
        {   
            return comenzi.Where(comanda => comanda.Stare != StareComanda.Livrata).ToList(); 
        }
        protected virtual void OnComandaSchimbatStare(ComandaSchimbatStareEventArgs eventArgs)
        {
            ComandaSchimbatStare?.Invoke(this, eventArgs);
        }
        protected virtual void OnComandaLivrata(ComandaLivrataEventArgs eventArgs)
        {
            ComandaLivrata?.Invoke(this, eventArgs);
        }
    }
}
