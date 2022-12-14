using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CekiuSpausdinimas.Models
{
    public interface ICekioSiuntimasIrSpausdinimas
    {
        public void CekioSiuntimasEmailu(string Email);
        public void CekioSpausdinimas(KlientoUzsakymas uzsakymas, RichTextBox richTextBox);
    }
}
