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
    public partial class RestoranoSaskaitaForm : Form
    {
        int staliukoNumeris = 0;
        public RestoranoSaskaitaForm()
        {
            InitializeComponent();
        }

        private void RestoranoSaskaita_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ButtonClicked.buttonClicked))
            {
                string staliukas = ButtonClicked.buttonClicked;
                staliukoNumeris = int.Parse(staliukas.Substring(staliukas.Length - 1));
            }

            var uzsakymas = new KlientoUzsakymasRepozitorija().GautiKlientoUzsakyma(staliukoNumeris);

            CekisRestoranui cekisRestoranui = new CekisRestoranui();
            cekisRestoranui.CekioSpausdinimas(uzsakymas, rtb_RestoranoSaskaita);
        }
    }
}
