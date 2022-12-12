using Restoranas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoranas.Models
{
    public class Uzsakymas
    {
        public int StaliukoNumeris { get; set; }
        public DateTime UzsakymoLaikas { get; set; }

        public List<Asortimentas> BendrasUzakymas;
        double KlientoPaduotaSuma { get; set; }

        public Uzsakymas(int staliukoNumeris, DateTime uzsakymoLaikas, List<Asortimentas>bendrasUzsakymas, double klientoPaduotaSuma)
        {
            StaliukoNumeris = staliukoNumeris;
            UzsakymoLaikas = uzsakymoLaikas;
            BendrasUzakymas = bendrasUzsakymas;
            KlientoPaduotaSuma = klientoPaduotaSuma;
        }
    }
}
