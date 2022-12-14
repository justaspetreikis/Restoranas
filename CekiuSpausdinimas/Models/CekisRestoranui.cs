using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CekiuSpausdinimas.Models
{
    public class CekisRestoranui : ICekioSiuntimasIrSpausdinimas
    {
        public void CekioSiuntimasEmailu(string Email)
        {
            MessageBox.Show($"Čekis išsiųstas restorano elektroninio pa6to adresu: {Email}");
        }

        public void CekioSpausdinimas(KlientoUzsakymas uzsakymas, RichTextBox richTextBox)
        {
            richTextBox.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            richTextBox.AppendText("\tStaliuko numeris: " + uzsakymas.StaliukoNumeris + Environment.NewLine);
            richTextBox.AppendText("\t\t\t" + uzsakymas.DataIrLaikas.ToString() + Environment.NewLine);
            richTextBox.AppendText("-------------------------------------------------------------" + Environment.NewLine);

            double suma = 0;

            foreach (var patiekalas in uzsakymas.UzsakytiPatiekalai)
            {
                richTextBox.AppendText($"{patiekalas.Pavadinimas} \t\t\t" + patiekalas.Kaina.ToString() + " EUR" + Environment.NewLine);
                suma += patiekalas.Kaina;
            }
            richTextBox.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            richTextBox.AppendText("Suma: \t\t\t\t" + suma.ToString("0.##") + " EUR" + Environment.NewLine);
            richTextBox.AppendText("-------------------------------------------------------------" + Environment.NewLine);
        }
    }
}
