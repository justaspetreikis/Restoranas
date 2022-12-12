using Restoranas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoranas.Models
{
    public class Gerimai
    {
        public List<Asortimentas> MeniuListas;
        public Gerimai()
        {
            MeniuListas = new List<Asortimentas>();

            string failas = @"C:\Users\petre\Desktop\CodeAcademy\Restoranas\Gerimai.txt";
            string[] gerimai = File.ReadAllLines(failas);
            foreach (string gerimas in gerimai)
            {
                var gerimoInfo = gerimas.Split(';');
                string pavadinimas = gerimoInfo[0].ToString();
                double kaina = double.Parse(gerimoInfo[1]);

                MeniuListas.Add(new Asortimentas(pavadinimas, kaina));
            }
        }

        public List<Asortimentas> GerimuListas()
        {
            return MeniuListas;
        }

        public Asortimentas PatiekaloKaina(string patiekaloPavadinimas)
        {
            return MeniuListas.Where(x => x.Pavadinimas == patiekaloPavadinimas).FirstOrDefault();
        }
        public void PakeistiKaina()
        {
            throw new NotImplementedException();
        }

        public void PridetiPreke()
        {
            throw new NotImplementedException();
        }
    }
}
