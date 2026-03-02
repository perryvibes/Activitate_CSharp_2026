using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    public static class NotificareService
    {
        public static void NotificaPrinSMS(string _nrComanda, string _mesaj)
        {
            Console.WriteLine($"[SMS] Comanda: {_nrComanda}: {_mesaj}");
        }
        public static void NotificaPrinEmail(string _nrComanda, string _mesaj)
        {
            Console.WriteLine($"[EMAIL] Comanda: {_nrComanda}: {_mesaj}");
        }
        public static void NotificaPrinLog(string _nrComanda, string _mesaj)
        {
            Console.WriteLine($"[Log] Comanda: {_nrComanda}: {_mesaj}");
        }

    }
}
