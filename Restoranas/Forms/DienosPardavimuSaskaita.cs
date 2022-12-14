using CekiuSpausdinimas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Restoranas.Forms.RestoranasForm;

namespace Restoranas.Forms
{
    public partial class DienosPardavimuSaskaitaForm : Form
    {
        public DienosPardavimuSaskaitaForm()
        {
            InitializeComponent();
        }

        private void rtb_DienosPardavimai_TextChanged(object sender, EventArgs e)
        {


        }

        private void DienosPardavimuSaskaitaForm_Load(object sender, EventArgs e)
        {
            var uzsakymai = new KlientoUzsakymasRepozitorija().VisiUzsakymai();

            string diena = DateTime.Now.ToString("MM/dd/yyyy");
            List < KlientoUzsakymas> dienosPardavimuListas = new List<KlientoUzsakymas>();

            foreach (var paimtasUsakymas in uzsakymai)
            {
                if (paimtasUsakymas.DataIrLaikas.ToString("MM/dd/yyyy") == diena)
                {
                    dienosPardavimuListas.Add(paimtasUsakymas);
                }
            }

            rtb_DienosPardavimai.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtb_DienosPardavimai.AppendText("\t\tDienos pardavimai" + Environment.NewLine);
            rtb_DienosPardavimai.AppendText("\t\t      " + diena + Environment.NewLine);
            rtb_DienosPardavimai.AppendText("-------------------------------------------------------------" + Environment.NewLine);

            double suma = 0;

            var parduotosPrekes = new List<string>();
            foreach(var a in dienosPardavimuListas)
            {
                foreach (var patiekalas in a.UzsakytiPatiekalai)
                {
                    parduotosPrekes.Add(patiekalas.Pavadinimas);
                    suma += patiekalas.Kaina;
                }

            }
            var q = from x in parduotosPrekes
                    group x by x into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };
            foreach (var x in q)
            {
                rtb_DienosPardavimai.AppendText(x.Value + " x " + x.Count + "\n");
            }
            rtb_DienosPardavimai.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtb_DienosPardavimai.AppendText("Dienos pardavimų suma: \t\t\t" + suma.ToString("0.##") + " EUR" + Environment.NewLine);
            rtb_DienosPardavimai.AppendText("-------------------------------------------------------------" + Environment.NewLine);


        }
    }
}
