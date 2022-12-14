using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CekiuSpausdinimas.Models
{
    public class CekisDienosPardavimai: ICekioSiuntimasIrSpausdinimas
    {
        public void CekioSiuntimasEmailu(string Email)
        {
            MessageBox.Show($"Čekis išsiųstas restorano elektroninio pašto adresu: {Email}");
        }

        public void CekioSpausdinimas(KlientoUzsakymas uzsakymas, RichTextBox richTextBox)
        {
            richTextBox.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            richTextBox.AppendText("\t\t\tVisi dienos pardavimai" + Environment.NewLine);
            richTextBox.AppendText("\t\t" + uzsakymas.DataIrLaikas.ToString() + Environment.NewLine);
            richTextBox.AppendText("-------------------------------------------------------------" + Environment.NewLine);

            double suma = 0;

            var parduotosPrekes = new List<string>();

            foreach (var patiekalas in uzsakymas.UzsakytiPatiekalai)
            {
                parduotosPrekes.Add(patiekalas.Pavadinimas);
                suma += patiekalas.Kaina;
            }

            var q = from x in parduotosPrekes
                    group x by x into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };
            foreach (var x in q)
            {
                richTextBox.AppendText(x.Value + " x " + x.Count );
            }
            richTextBox.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            richTextBox.AppendText("Dienos pardavimų suma: \t\t\t" + suma.ToString("0.##") + " EUR" + Environment.NewLine);
            richTextBox.AppendText("-------------------------------------------------------------" + Environment.NewLine);
        }
    }
}
