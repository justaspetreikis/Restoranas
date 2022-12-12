using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoranas.Models
{
    public class UzsakymasRepozitorija
    {
        public List<Uzsakymas> VisiUzsakymai { get; set; }
        public UzsakymasRepozitorija()
        {
            VisiUzsakymai = new List<Uzsakymas>();

            string failas = @"C:\Users\petre\Desktop\CodeAcademy\Restoranas\VisiUzsakymai.txt";
            string[] uzsakymai = File.ReadAllLines(failas);
            foreach (string uzsakymas in uzsakymai)
            {
                var paimtasUzsakymas = uzsakymas.Split(';');
                DateTime data = DateTime.Parse(paimtasUzsakymas[0]);
                int staliukoNumeris = int.Parse(paimtasUzsakymas[1]);
                double klientoPaduotaSuma = double.Parse(paimtasUzsakymas[2]);
                List<Asortimentas> parduotiProduktai = new List<Asortimentas>();
                for (int j = 3; j < paimtasUzsakymas.Length - 1; j += 2)
                {
                    parduotiProduktai.Add(new Asortimentas(paimtasUzsakymas[j], double.Parse(paimtasUzsakymas[j + 1])));
                }

                VisiUzsakymai.Add(new Uzsakymas(staliukoNumeris, data, parduotiProduktai, klientoPaduotaSuma));
            }

        }
        public List<Uzsakymas> VisuUzsakymuListas()
        {
            return VisiUzsakymai;
        }

        public Uzsakymas UzsakymoInfo(int staliukoNumeris)
        {
            VisiUzsakymai.Sort((x, y) => DateTime.Compare(y.UzsakymoLaikas, x.UzsakymoLaikas));
            return VisiUzsakymai.Where(x => x.StaliukoNumeris == staliukoNumeris).FirstOrDefault();
        }
    }
}
