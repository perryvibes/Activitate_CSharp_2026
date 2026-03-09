using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Comanda c1 = new Comanda("Iulian", "iulia@gmail.com");
            c1.AdaugaProdus(new Produs("mouse", 70, 1));
            c1.AdaugaProdus(new Produs("tastatura", 120.99m, 1));

            var optiuni = Console.ReadLine();
            NotificareClient notificator = null;
            //Action<string, string> notificator = null; // tip generic
            if (optiuni.Contains("sms"))
                notificator += NotificareService.NotificaPrinSMS;
            if (optiuni.Contains("email"))
                notificator += NotificareService.NotificaPrinEmail;
            if (optiuni.Contains("log"))
                notificator += NotificareService.NotificaPrinLog;

            notificator?.Invoke(c1.NumarComanda, "Comanda a fost inregistrata");

            Depozit d = new Depozit("Depozit Stefanesti");
            d.InregistreazaComanda(c1, notificator);

            d.ComandaSchimbatStare +=
                (object sender, ComandaSchimbatStareEventArgs e) =>
                {
                    Console.WriteLine($"Comanda {e.Comanda.NumarComanda} din " + 
                        $"{e.StareVeche} in {e.StareNoua}");
                };
            d.ComandaLivrata += OnComandaLivrata;

            d.AvanseazaComanda("CMD-001");
            d.AvanseazaComanda("CMD-001");
            d.AvanseazaComanda("CMD-001");
        }
        private static void OnComandaLivrata(object sender, ComandaLivrataEventArgs e)
        {
            Console.WriteLine($"Comanda {e.Comanda.NumarComanda} a fost livrata la data de {e.DataLivrare.ToString("dd.MM.yyyy")}");
        }
        private static NotificareClient BuildNotificator(string optiuni)
        {
            NotificareClient notificator = null;
            //switch (optiuni)
            //{
            //    case optiuni.Contains("sms"):
            //    {
            //        notificator += NotificareService.NotificaPrinSMS;
            //            break;
            //    }
            //    case optiuni.Contains("email"):
            //    {
            //        notificator += NotificareService.NotificaPrinEmail;
            //            break;
            //    }
            //    case optiuni.Contains("log"):
            //    {
            //        notificator += NotificareService.NotificaPrinLog;
            //            break;
            //    }
            //    default:
            //        return notificator;
            //        break;
            //}
            if (optiuni.Contains("sms"))
                notificator += NotificareService.NotificaPrinSMS;
            if (optiuni.Contains("email"))
                notificator += NotificareService.NotificaPrinEmail;
            if (optiuni.Contains("log"))
                notificator += NotificareService.NotificaPrinLog;
            return notificator;
        }
    }
}
