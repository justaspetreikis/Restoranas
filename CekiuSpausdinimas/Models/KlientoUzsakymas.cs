using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CekiuSpausdinimas.Models
{
    public class KlientoUzsakymas
    {
        public int StaliukoNumeris { get; set; }
        public List<UzsakytosPrekes> UzsakytiPatiekalai { get; set; }      
        public double Suma { get; set; }
        public double Sumoketa { get; set; }
        public double Graza { get; set; }
        public double PVM { get; set; }
        public DateTime DataIrLaikas { get; set; }

        public KlientoUzsakymas(int staliukoNumeris, List<UzsakytosPrekes> uzsakytiPatiekalai, double suma, double sumoketa, double graza, double pVM, DateTime dataIrLaikas)
        {
            StaliukoNumeris = staliukoNumeris;
            UzsakytiPatiekalai = uzsakytiPatiekalai;
            Suma = suma;
            Sumoketa = sumoketa;
            Graza = graza;
            PVM = pVM;
            DataIrLaikas = dataIrLaikas;
        }
    }
}
