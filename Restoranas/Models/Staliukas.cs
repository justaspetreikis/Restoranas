using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoranas.Models
{
    public class Staliukas
    {
        public int Numeris { get; set; }
        public int SedimosVietos { get; set; }
        public bool Uzimtas { get; set; }

        public Staliukas(int numerius, int sedimosVietos, bool uzimtas)
        {
            Numeris = numerius;
            SedimosVietos = sedimosVietos;
            Uzimtas = uzimtas;
        }
    }
}
