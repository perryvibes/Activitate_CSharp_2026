using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    public class CasaBilete
    {
        private List<Bilet> bilete { get; set; }
        public CasaBilete()
        {
            bilete = new List<Bilet>();
        }
        public void AdaugaBilet(Bilet _bilet)
        {
            bilete.Add(_bilet);
        }
        public double GetIncasariTotale() => bilete.Sum(bilet => bilet.CalculeazaPretFinal());
        public double GetReduceriAcordate() => bilete.Sum(bilet => bilet.PretBaza - bilet.GetReducere());
        public int GetNumarBiletePerTip<T>() where T : Bilet => bilete.OfType<T>().Count();
        public Bilet GetBiletulCelMaiScump() => bilete.OrderByDescending(bilet => bilet.CalculeazaPretFinal()).FirstOrDefault();
    }
}
