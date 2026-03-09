using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    public class ComandaLivrataEventArgs: EventArgs
    {
        public Comanda Comanda { get; set; }
        public DateTime DataLivrare { get; set; }
    }
}
