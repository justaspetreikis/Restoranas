using CekiuSpausdinimas.Models;
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

            this.textBox2.Enter += new EventHandler(textBox2_Enter);
            this.textBox2.Leave += new EventHandler(textBox2_Leave);
            textBox2_SetText();

            if (!string.IsNullOrEmpty(ButtonClicked.buttonClicked))
            {
                string staliukas = ButtonClicked.buttonClicked;
                staliukoNumeris = int.Parse(staliukas.Substring(staliukas.Length - 1));
            }

            var uzsakymas = new KlientoUzsakymasRepozitorija().GautiKlientoUzsakyma(staliukoNumeris);

            CekisRestoranui cekisRestoranui = new CekisRestoranui();
            cekisRestoranui.CekioSpausdinimas(uzsakymas, rtb_RestoranoSaskaita);
        }

        protected void textBox2_SetText()
        {
            this.textBox2.Text = "Įveskite restorano Email";
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

        private void button_SiustiEmail_Click(object sender, EventArgs e)
        {
            if(textBox2.ForeColor == Color.Gray || !textBox2.Text.Contains('@'))
            {
                MessageBox.Show("Neįvestas arba blogai įvestas elektroninio pašto adresas");
            }
            else
            {
                CekisRestoranui cekisRestoranui = new();
                cekisRestoranui.CekioSiuntimasEmailu(textBox2.Text);
            }

        }
    }
}
