
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CekiuSpausdinimas.Models
{
    public class KlientoUzsakymasRepozitorija
    {
        public List<KlientoUzsakymas> Uzsakymai { get; private set; }
        public KlientoUzsakymasRepozitorija()
        {
            Uzsakymai = new List<KlientoUzsakymas>();

            string failas = @"C:\Users\petre\Desktop\CodeAcademy\Restoranas\VisiUzsakymai.txt";
            string[] uzsakymai = File.ReadAllLines(failas);
            double suma = 0;
            double graza;
            double pvm;
            foreach (string uzsakymas in uzsakymai)
            {
                var paimtasUzsakymas = uzsakymas.Split(';');
                DateTime data = DateTime.Parse(paimtasUzsakymas[0]);
                int staliukoNumeris = int.Parse(paimtasUzsakymas[1]);
                double klientoPaduotaSuma = double.Parse(paimtasUzsakymas[2]);
                List<UzsakytosPrekes> parduotiProduktai = new();
                for (int j = 3; j < paimtasUzsakymas.Length - 1; j += 2)
                {
                    parduotiProduktai.Add(new UzsakytosPrekes(paimtasUzsakymas[j], double.Parse(paimtasUzsakymas[j + 1])));
                    suma += double.Parse(paimtasUzsakymas[j + 1]);
                }
                graza = klientoPaduotaSuma - suma;
                pvm = suma / 100 * 9;

                Uzsakymai.Add(new KlientoUzsakymas(staliukoNumeris, parduotiProduktai, suma, klientoPaduotaSuma, graza, pvm, data));
            }

        }
        public List<KlientoUzsakymas> VisiUzsakymai()
        {
            return Uzsakymai;
        }

        public KlientoUzsakymas GautiKlientoUzsakyma(int staliukoNumeris)
        {
            Uzsakymai.Sort((x, y) => DateTime.Compare(y.DataIrLaikas, x.DataIrLaikas));
            return Uzsakymai.Where(x => x.StaliukoNumeris == staliukoNumeris).FirstOrDefault();
        }
    }
}
