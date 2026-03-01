using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    public class Client
    {
        private string nume { get; set; }
        private string prenume { get; set; }
        private string email { get; set; }
        private string telefon { get; set; }

        public string Email
        {
            get => email;
            set
            {
                if (value.Contains('@') && value.Contains('.') != true)
                {
                    throw new ArgumentException("Emailul este invalid!");
                }
                email = value;
            }
        }
        public string Telefon
        {
            get => telefon;
            set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentException("Telefonul trebuie sa contina 10 caractere!");
                }

                telefon = value;
            }
        }
        public Client(string _nume, string _prenume, string _Email, string _Telefon)
        {
            nume = _nume;
            prenume = _prenume;
            email = _Email;
            telefon = _Telefon;
        }
    }
}
