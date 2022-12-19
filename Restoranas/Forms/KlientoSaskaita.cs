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
            this.textBox2.Enter += new EventHandler(textBox2_Enter);
            this.textBox2.Leave += new EventHandler(textBox2_Leave);
            textBox2_SetText();

            if (!string.IsNullOrEmpty(ButtonClicked.buttonClicked))
            {
                string staliukas = ButtonClicked.buttonClicked;
                staliukoNumeris = int.Parse(staliukas.Substring(staliukas.Length - 1));
            }

            var uzsakymas = new KlientoUzsakymasRepozitorija().GautiKlientoUzsakyma(staliukoNumeris);

            CekisKlientui cekisKlientui = new CekisKlientui();
            cekisKlientui.CekioSpausdinimas(uzsakymas, rtb_KlientoSaskaita);

        }

        protected void textBox2_SetText()
        {
            this.textBox2.Text = "Įveskite kliento Email";
            textBox2.ForeColor = Color.Gray;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.ForeColor == Color.Black)
                return;
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
                textBox2_SetText();
        }
        private void rtb_KlientoSaskaita_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_SiustiEmail_Click(object sender, EventArgs e)
        {
            CekisKlientui cekisKlientui = new CekisKlientui();
            cekisKlientui.CekioSiuntimasEmailu(textBox2.Text);
        }
    }
}
