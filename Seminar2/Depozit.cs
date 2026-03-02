using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    public class Depozit
    {
        public string Nume { get; set; }
        public event EventHandler<ComandaSchimbatStareEventArgs> ComandaSchimbatStare;
        public event EventHandler ComandaLivrata;

        private List<Comanda> comenzi;
        public Depozit(string _nume)
        {
            Nume = _nume;
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
            comanda.Stare = (StareComanda)((int)comanda.Stare + 1);

            var eventArgs = new ComandaSchimbatStareEventArgs()
            {
                Comanda = comanda,
                StareNoua = comanda.Stare
            };
           
            comanda.Stare = (StareComanda)((int)comanda.Stare + 1);

            eventArgs.StareNoua = comanda.Stare;

            ComandaSchimbatStare?.Invoke(this, eventArgs);
        }

    }
}
