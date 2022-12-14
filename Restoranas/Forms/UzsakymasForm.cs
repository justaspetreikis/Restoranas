
using Restoranas.Models;
using System.Data;
using static Restoranas.Forms.RestoranasForm;
using File = System.IO.File;
using System.Text;

namespace Restoranas.Forms
{
    public partial class UzsakymasForm : Form
    {
        int staliukoNumeris = 0;
        
        public UzsakymasForm()
        {
            InitializeComponent();         
        }

        public void UzsakymasForm_Load(object sender, EventArgs e)
        {
            PatikrinamKurisStaliukasPasirinktas();

            StaliukoUzimtumoKeitimasIrBuvusioUzsakymoUzkrovimas();

            StaliukoUzimtumoIrSedimuVietuInfo();

            MaistoAsortimentoPildymas();
        }

        private void cmb_PasirinktiPatiekala_SelectedIndexChanged(object sender, EventArgs e)
        {
            UzkrautiPasirinktoPatiekaloKaina();
        }      

        private void btn_Uzsakyti_Click(object sender, EventArgs e)
        {
            ParodytiLentelejeIrIrasytiIFailaUzsakytusStaliukoPatiekalus();
        }

        private void btn_AtlaisvintiStaliuka_Click(object sender, EventArgs e)
        {
            PatikrintiArApmoketaSaskaitairPakeistiUzimtumoInfo();
        }

        private void tbKlientoPaduotaSuma_TextChanged(object sender, EventArgs e)
        {
            PatikrinameArGeraiIvestaKlientoPaduotaSuma();
        }

        private void btn_ApmoketiUzsakyma_Click_1(object sender, EventArgs e)
        {
            bool pakankamai = ArKlientasPadavePakankamaiPinigu();

            if(pakankamai == false)
            {
                MessageBox.Show("Užsakymo suma didesnė nei paduota kliento suma. Apmokėti nepavyko");
            }

            else
            {
                UzsakymoIrasymasIVisuUzsakymuFaila();

                string path = $@"C:\Users\petre\Desktop\CodeAcademy\Restoranas\Stalo{staliukoNumeris}Uzsakymas.txt";

                if (File.Exists(path))
                {
                    File.WriteAllText(path, "");
                }

                DialogResult uzklausaCekiui = MessageBox.Show("Ar klientui reikalingas čekis?", "Čekio spausdinimas", MessageBoxButtons.YesNo);
                if (uzklausaCekiui == DialogResult.Yes)
                {
                    var klientoCekisForm = new KlientoSaskaitaForm();
                    klientoCekisForm.Show();

                    var restoranoCekisForm = new RestoranoSaskaitaForm();
                    restoranoCekisForm.Show();
                }
                else if (uzklausaCekiui == DialogResult.No)
                {
                    var restoranoCekisForm = new RestoranoSaskaitaForm();
                    restoranoCekisForm.Show();
                }

                var ss = new UzsakymasForm();
                ss.Show();
                this.Hide();
            }     

        }

        private void btn_Gristi_Click(object sender, EventArgs e)
        {
            var restoranoForma = new RestoranasForm();
            restoranoForma.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_Data.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public void PapildytiSenaUzsakyma()
        {
            List<Asortimentas> staliukoUzsakymas = new List<Asortimentas>();
            string path = $@"C:\Users\petre\Desktop\CodeAcademy\Restoranas\Stalo{staliukoNumeris}Uzsakymas.txt";
            string[] uzsakymai = File.ReadAllLines(path);

            foreach (string uzsakymas in uzsakymai)
            {
                var paimtasUzsakymas = uzsakymas.Split(';');

                for (int j = 0; j < paimtasUzsakymas.Length - 1; j += 2)
                {
                    staliukoUzsakymas.Add(new Asortimentas(paimtasUzsakymas[j], double.Parse(paimtasUzsakymas[j + 1])));
                }
            }

            if (staliukoUzsakymas != null)
            {
                foreach (var u in staliukoUzsakymas)
                {
                    dataGridView1.Rows.Add(u.Pavadinimas, u.Kaina);
                }
                double sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                }
                label_Suma.Text = $"{sum} EUR";
            }

        }
        public static string DGVtoString(DataGridView dgv, char delimiter)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value);
                    sb.Append(delimiter);
                }
                //sb.Remove(sb.Length - 1, 1);
                sb.AppendLine();
            }
            string singleLine = sb.ToString();
            return singleLine.Replace("\r\n", "");
        }

        private void StaliukoUzimtumoIrSedimuVietuInfo()
        {
            var stalas = new StaliukasRepozitorija();
            var staliukoInfo = stalas.StaliukoInfo(staliukoNumeris);

            if (staliukoInfo.Uzimtas == false)
            {
                tb_StaliukoUzimtumas.Text = "LAISVAS";
            }
            else
            {
                tb_StaliukoUzimtumas.Text = "UŽIMTAS";
            }

            label_skaicius.Text = staliukoInfo.SedimosVietos.ToString();
        }

        private void PatikrinamKurisStaliukasPasirinktas()
        {
            if (!string.IsNullOrEmpty(ButtonClicked.buttonClicked))
            {
                tb_StaliukoNumeris.Text = ButtonClicked.buttonClicked;
                string staliukas = tb_StaliukoNumeris.Text;
                staliukoNumeris = int.Parse(staliukas.Substring(staliukas.Length - 1));
            }
        }

        private void MaistoAsortimentoPildymas()
        {
            var maistas = new Maistas();
            var patiekalai = maistas.MaistoPatiekaluListas();

            var gerimai = new Gerimai();
            var gerimuListas = gerimai.GerimuListas();
            var meniu = patiekalai.Concat(gerimuListas);

            foreach (var patiekalas in meniu)
            {
                cmb_PasirinktiPatiekala.Items.Add(patiekalas.Pavadinimas);
            }
        }

        private void StaliukoUzimtumoKeitimasIrBuvusioUzsakymoUzkrovimas()
        {
            var stalas = new StaliukasRepozitorija();
            var staliukoInfo = stalas.StaliukoInfo(staliukoNumeris);

            if (staliukoInfo.Uzimtas == true)
            {
                PapildytiSenaUzsakyma();
            }

            if (staliukoInfo.Uzimtas == false)
            {
                string[] strings = File.ReadAllLines(@"C:\Users\petre\Desktop\CodeAcademy\Restoranas\Staliukai.txt");
                strings[staliukoNumeris - 1] = strings[staliukoNumeris - 1].Replace("false", "true");
                File.WriteAllLines(@"C:\Users\petre\Desktop\CodeAcademy\Restoranas\Staliukai.txt", strings);
            }
        }

        private void PatikrintiArApmoketaSaskaitairPakeistiUzimtumoInfo()
        {
            string infoApieStaliukus = @"C:\Users\petre\Desktop\CodeAcademy\Restoranas\Staliukai.txt";
            if (string.IsNullOrEmpty(label_Suma.Text) || label_Suma.Text == "0 EUR")
            {
                var stalas = new StaliukasRepozitorija();
                var staliukoInfo = stalas.StaliukoInfo(staliukoNumeris);

                if (staliukoInfo.Uzimtas == true)
                {
                    string[] strings = File.ReadAllLines(infoApieStaliukus);
                    strings[staliukoNumeris - 1] = strings[staliukoNumeris - 1].Replace("true", "false");
                    File.WriteAllLines(infoApieStaliukus, strings);

                    tb_StaliukoUzimtumas.Text = "LAISVAS";
                }
            }

            else
            {
                MessageBox.Show("NEAPMOKĖTA SĄSKAITA! Staliuko atlaisvinti negalima");
            }
        }

        private void ParodytiLentelejeIrIrasytiIFailaUzsakytusStaliukoPatiekalus()
        {
            string path = $@"C:\Users\petre\Desktop\CodeAcademy\Restoranas\Stalo{staliukoNumeris}Uzsakymas.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path)) ;
            }

            if (string.IsNullOrEmpty(cmb_PasirinktiPatiekala.Text))
            {
                MessageBox.Show("Nepasirinktas patieklas");
            }
            else
            {
                dataGridView1.Rows.Add(cmb_PasirinktiPatiekala.Text, tb_Kaina.Text);

                double sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                }
                label_Suma.Text = $"{sum.ToString("0.##")} EUR";


                string dgv = DGVtoString(dataGridView1, ';');

                string uzsakymoInfo = dgv + "\n";


                File.WriteAllText(path, uzsakymoInfo);

            }
        }

        private void UzkrautiPasirinktoPatiekaloKaina()
        {
            var maistas = new Maistas();
            var patiekalai = maistas.MaistoPatiekaluListas();

            var gerimai = new Gerimai();
            var gerimuListas = gerimai.GerimuListas();

            var meniu = patiekalai.Concat(gerimuListas);
            tb_Kaina.Text = meniu.Where(x => x.Pavadinimas == cmb_PasirinktiPatiekala.Text).FirstOrDefault().Kaina.ToString();
        }

        private bool ArKlientasPadavePakankamaiPinigu()
        {
            bool pakankamai = true;
            if (double.Parse(label_PaskaiciuotaGraza.Text) < 0)
            {
                pakankamai = false;
            }
            return pakankamai;
        }

        private void UzsakymoIrasymasIVisuUzsakymuFaila()
        {
                string path = $@"C:\Users\petre\Desktop\CodeAcademy\Restoranas\VisiUzsakymai.txt";

                string dgv = DGVtoString(dataGridView1, ';');

                string uzsakymoInfo = tb_Data.Text.ToString() + ';' + staliukoNumeris.ToString()
                                      + ';' + tbKlientoPaduotaSuma.Text
                                      + ';' + dgv + label_Suma.Text.Remove(label_Suma.Text.Length - 4) 
                                      + "\n";

                File.AppendAllText(path, uzsakymoInfo);
        }


        private void PatikrinameArGeraiIvestaKlientoPaduotaSuma()
        {
            double suma = double.Parse(label_Suma.Text.Remove(label_Suma.Text.Length - 4));
            double graza;
            bool parseSuccess = double.TryParse((tbKlientoPaduotaSuma.Text), out graza);
            if (parseSuccess)
            {
                label_PaskaiciuotaGraza.Text = (double.Parse(tbKlientoPaduotaSuma.Text) - suma).ToString("0.##");
            }
            else
            {
                MessageBox.Show("Blogai įvesta 'Kliento paduota suma'");
            }
        }

    }
}
