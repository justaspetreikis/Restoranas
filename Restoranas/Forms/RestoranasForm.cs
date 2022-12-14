using Restoranas.Forms;
using Restoranas.Models;
using System.Drawing;

namespace Restoranas.Forms
{
    public partial class RestoranasForm : Form
    {
        public RestoranasForm()
        {
            InitializeComponent();
        }
        public static class ButtonClicked
        {
            public static string buttonClicked;
        }

        private UzsakymasForm pirmasStaliukas = new UzsakymasForm();
        private UzsakymasForm antrasStaliukas = new UzsakymasForm();
        private UzsakymasForm treciasStaliukas = new UzsakymasForm();
        private UzsakymasForm ketvirtasStaliukas = new UzsakymasForm();
        private UzsakymasForm penktasStaliukas = new UzsakymasForm();
        private UzsakymasForm sestasStaliukas = new UzsakymasForm();
        private UzsakymasForm septintasStaliukas = new UzsakymasForm();
        private UzsakymasForm astuntasStaliukas = new UzsakymasForm();

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClicked.buttonClicked = (sender as Button).Text;
            if (!pirmasStaliukas.Visible)
            {
                pirmasStaliukas.Show();
            }
            else
            {
                pirmasStaliukas.BringToFront();
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonClicked.buttonClicked = (sender as Button).Text;
            if (!antrasStaliukas.Visible)
            {
                antrasStaliukas.Show();
            }
            else
            {
                antrasStaliukas.BringToFront();
            }
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonClicked.buttonClicked = (sender as Button).Text;
            if (!treciasStaliukas.Visible)
            {
                treciasStaliukas.Show();
            }
            else
            {
                treciasStaliukas.BringToFront();
            }
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonClicked.buttonClicked = (sender as Button).Text;
            if (!ketvirtasStaliukas.Visible)
            {
                ketvirtasStaliukas.Show();
            }
            else
            {
                ketvirtasStaliukas.BringToFront();
            }
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonClicked.buttonClicked = (sender as Button).Text;
            if (!penktasStaliukas.Visible)
            {
                penktasStaliukas.Show();
            }
            else
            {
                penktasStaliukas.BringToFront();
            }
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonClicked.buttonClicked = (sender as Button).Text;
            if (!sestasStaliukas.Visible)
            {
                sestasStaliukas.Show();
            }
            else
            {
                sestasStaliukas.BringToFront();
            }
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonClicked.buttonClicked = (sender as Button).Text;
            if (!septintasStaliukas.Visible)
            {
                septintasStaliukas.Show();
            }
            else
            {
                septintasStaliukas.BringToFront();
            }
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonClicked.buttonClicked = (sender as Button).Text;
            if (!astuntasStaliukas.Visible)
            {
                astuntasStaliukas.Show();
            }
            else
            {
                astuntasStaliukas.BringToFront();
            }
            this.Hide();
        }

        private void RestoranasForm_Load(object sender, EventArgs e)
        {
            var stalai = new StaliukasRepozitorija();
            var staliukuInfo = stalai.VisuStaluListas();
            foreach (var stalas in staliukuInfo)
            {
                if (stalas.Uzimtas == true)
                {
                    switch (stalas.Numeris)
                    {
                        case 1:
                            button1.BackColor = Color.Red;
                            break;
                        case 2:
                            button2.BackColor = Color.Red;
                            break;
                        case 3:
                            button3.BackColor = Color.Red;
                            break;
                        case 4:
                            button4.BackColor = Color.Red;
                            break;
                        case 5:
                            button5.BackColor = Color.Red;
                            break;
                        case 6:
                            button6.BackColor = Color.Red;
                            break;
                        case 7:
                            button7.BackColor = Color.Red;
                            break;
                        case 8:
                            button8.BackColor = Color.Red;
                            break;
                    }

                }
                else
                {
                    switch (stalas.Numeris)
                    {
                        case 1:
                            button1.BackColor = Color.Green;
                            break;
                        case 2:
                            button2.BackColor = Color.Green;
                            break;
                        case 3:
                            button3.BackColor = Color.Green;
                            break;
                        case 4:
                            button4.BackColor = Color.Green;
                            break;
                        case 5:
                            button5.BackColor = Color.Green;
                            break;
                        case 6:
                            button6.BackColor = Color.Green;
                            break;
                        case 7:
                            button7.BackColor = Color.Green;
                            break;
                        case 8:
                            button8.BackColor = Color.Green;
                            break;

                    }
                }
            }
        }
    }
}
