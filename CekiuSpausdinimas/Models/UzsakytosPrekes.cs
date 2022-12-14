using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CekiuSpausdinimas.Models
{
    public class UzsakytosPrekes
    {
        public string Pavadinimas { get; set; }
        public double Kaina { get; set; }

        public UzsakytosPrekes(string pavadinimas, double kaina)
        {
            Pavadinimas = pavadinimas;
            Kaina = kaina;
        }
    }
}
