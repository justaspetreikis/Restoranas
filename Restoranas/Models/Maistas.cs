using Restoranas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoranas.Models
{
    public class Maistas
    {
        public List<Asortimentas> MeniuListas { get; set; }
        public Maistas()
        {
            MeniuListas = new List<Asortimentas>();

            string failas = @"C:\Users\petre\Desktop\CodeAcademy\Restoranas\Maistas.txt";
            string[] patiekalai = File.ReadAllLines(failas);
            foreach (string patiekalas in patiekalai)
            {
                var patiekaloInfo = patiekalas.Split(';');
                string pavadinimas = patiekaloInfo[0].ToString();
                double kaina = double.Parse(patiekaloInfo[1]);

                MeniuListas.Add(new Asortimentas(pavadinimas,kaina));
            }
        }

        public List<Asortimentas> MaistoPatiekaluListas()
        {
            return MeniuListas;
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
