using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3
{
    public sealed class Contact
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public bool NotificariActive { get; set; }

        public override string ToString()
        {
            return $"{Prenume} {Nume} - {Telefon}";
        }

    }
}
