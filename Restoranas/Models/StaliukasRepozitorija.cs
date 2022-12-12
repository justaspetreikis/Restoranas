using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoranas.Models
{
    public class StaliukasRepozitorija
    {
        public List<Staliukas> StaliukuListas { get; set; }

        public StaliukasRepozitorija()
        {
            StaliukuListas = new List<Staliukas>();

            string failas = @"C:\Users\petre\Desktop\CodeAcademy\Restoranas\Staliukai.txt";
            string[] staliukai = File.ReadAllLines(failas);
            foreach (string staliukas in staliukai)
            {
                var paimtasStaliukas = staliukas.Split(';');
                int staliukoNumeris = int.Parse(paimtasStaliukas[0]);
                int vietuSkaicius = int.Parse(paimtasStaliukas[1]);
                bool arUzimtas = bool.Parse(paimtasStaliukas[2]);

                StaliukuListas.Add(new Staliukas(staliukoNumeris, vietuSkaicius, arUzimtas));
            }
        }
        public List<Staliukas> VisuStaluListas()
        {
            return StaliukuListas;
        }

        public Staliukas StaliukoInfo(int staliukoNumeris)
        {
            return StaliukuListas.Where(x => x.Numeris == staliukoNumeris).FirstOrDefault();
        }
    }
}
