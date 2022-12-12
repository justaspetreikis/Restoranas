using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoranas.Models
{
    public class Asortimentas
    {
        public string Pavadinimas { get; set; }
        public double Kaina { get; set; }

        public Asortimentas(string pavadinimas, double kaina)
        {
            Pavadinimas = pavadinimas;
            Kaina = kaina;
        }

    }
}
