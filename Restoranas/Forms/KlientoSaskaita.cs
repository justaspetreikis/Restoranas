using CekiuSpausdinimas;
using CekiuSpausdinimas.Models;
using Restoranas.Models;
using static Restoranas.Forms.RestoranasForm;

namespace Restoranas.Forms
{
    public partial class KlientoSaskaitaForm : Form
    {
        int staliukoNumeris = 0;
        public KlientoSaskaitaForm()
        {
            InitializeComponent(); 
        }

        private void KlientoSaskaitaForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ButtonClicked.buttonClicked))
            {
                string staliukas = ButtonClicked.buttonClicked;
                staliukoNumeris = int.Parse(staliukas.Substring(staliukas.Length - 1));
            }

            var uzsakymas = new KlientoUzsakymasRepozitorija().GautiKlientoUzsakyma(staliukoNumeris);

            CekisKlientui cekisKlientui = new CekisKlientui();
            cekisKlientui.CekioSpausdinimas(uzsakymas, rtb_KlientoSaskaita);

        }

        private void rtb_KlientoSaskaita_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
