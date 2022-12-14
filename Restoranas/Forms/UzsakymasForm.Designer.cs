namespace Restoranas.Forms
{
    partial class UzsakymasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_Data = new System.Windows.Forms.TextBox();
            this.tb_StaliukoNumeris = new System.Windows.Forms.TextBox();
            this.tb_StaliukoUzimtumas = new System.Windows.Forms.TextBox();
            this.btn_AtlaisvintiStaliuka = new System.Windows.Forms.Button();
            this.label_PasirinktiPatiekala = new System.Windows.Forms.Label();
            this.label_Kaina = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pavadinimas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kaina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_PasirinktiPatiekala = new System.Windows.Forms.ComboBox();
            this.tb_Kaina = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Uzsakyti = new System.Windows.Forms.Button();
            this.label_Suma = new System.Windows.Forms.Label();
            this.btn_ApmoketiUzsakyma = new System.Windows.Forms.Button();
            this.label_VietuSkaicius = new System.Windows.Forms.Label();
            this.label_skaicius = new System.Windows.Forms.Label();
            this.btn_Gristi = new System.Windows.Forms.Button();
            this.lbUzsakymoSuma = new System.Windows.Forms.Label();
            this.uzsakymasRepozitorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_KlientoPaduotaSuma = new System.Windows.Forms.Label();
            this.label_Graza = new System.Windows.Forms.Label();
            this.label_PaskaiciuotaGraza = new System.Windows.Forms.Label();
            this.tbKlientoPaduotaSuma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzsakymasRepozitorijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Data
            // 
            this.tb_Data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Data.Location = new System.Drawing.Point(628, 9);
            this.tb_Data.Name = "tb_Data";
            this.tb_Data.ReadOnly = true;
            this.tb_Data.Size = new System.Drawing.Size(192, 34);
            this.tb_Data.TabIndex = 0;
            this.tb_Data.Text = "0000-00-00 00:00:00";
            // 
            // tb_StaliukoNumeris
            // 
            this.tb_StaliukoNumeris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_StaliukoNumeris.Location = new System.Drawing.Point(12, 9);
            this.tb_StaliukoNumeris.Name = "tb_StaliukoNumeris";
            this.tb_StaliukoNumeris.ReadOnly = true;
            this.tb_StaliukoNumeris.Size = new System.Drawing.Size(169, 34);
            this.tb_StaliukoNumeris.TabIndex = 1;
            // 
            // tb_StaliukoUzimtumas
            // 
            this.tb_StaliukoUzimtumas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_StaliukoUzimtumas.Location = new System.Drawing.Point(187, 12);
            this.tb_StaliukoUzimtumas.Name = "tb_StaliukoUzimtumas";
            this.tb_StaliukoUzimtumas.ReadOnly = true;
            this.tb_StaliukoUzimtumas.Size = new System.Drawing.Size(169, 34);
            this.tb_StaliukoUzimtumas.TabIndex = 2;
            // 
            // btn_AtlaisvintiStaliuka
            // 
            this.btn_AtlaisvintiStaliuka.Location = new System.Drawing.Point(187, 52);
            this.btn_AtlaisvintiStaliuka.Name = "btn_AtlaisvintiStaliuka";
            this.btn_AtlaisvintiStaliuka.Size = new System.Drawing.Size(169, 34);
            this.btn_AtlaisvintiStaliuka.TabIndex = 3;
            this.btn_AtlaisvintiStaliuka.Text = "Atlaisvinti staliuką";
            this.btn_AtlaisvintiStaliuka.UseVisualStyleBackColor = true;
            this.btn_AtlaisvintiStaliuka.Click += new System.EventHandler(this.btn_AtlaisvintiStaliuka_Click);
            // 
            // label_PasirinktiPatiekala
            // 
            this.label_PasirinktiPatiekala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_PasirinktiPatiekala.Location = new System.Drawing.Point(12, 109);
            this.label_PasirinktiPatiekala.Name = "label_PasirinktiPatiekala";
            this.label_PasirinktiPatiekala.Size = new System.Drawing.Size(180, 31);
            this.label_PasirinktiPatiekala.TabIndex = 5;
            this.label_PasirinktiPatiekala.Text = "Pasirinkti patiekalą";
            // 
            // label_Kaina
            // 
            this.label_Kaina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Kaina.Location = new System.Drawing.Point(12, 148);
            this.label_Kaina.Name = "label_Kaina";
            this.label_Kaina.Size = new System.Drawing.Size(169, 31);
            this.label_Kaina.TabIndex = 6;
            this.label_Kaina.Text = "Kaina";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pavadinimas,
            this.Kaina});
            this.dataGridView1.Location = new System.Drawing.Point(12, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(454, 244);
            this.dataGridView1.TabIndex = 8;
            // 
            // Pavadinimas
            // 
            this.Pavadinimas.HeaderText = "Pavadinimas";
            this.Pavadinimas.MinimumWidth = 6;
            this.Pavadinimas.Name = "Pavadinimas";
            this.Pavadinimas.Width = 250;
            // 
            // Kaina
            // 
            this.Kaina.HeaderText = "Kaina";
            this.Kaina.MinimumWidth = 6;
            this.Kaina.Name = "Kaina";
            this.Kaina.Width = 150;
            // 
            // cmb_PasirinktiPatiekala
            // 
            this.cmb_PasirinktiPatiekala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PasirinktiPatiekala.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_PasirinktiPatiekala.FormattingEnabled = true;
            this.cmb_PasirinktiPatiekala.Location = new System.Drawing.Point(187, 109);
            this.cmb_PasirinktiPatiekala.Name = "cmb_PasirinktiPatiekala";
            this.cmb_PasirinktiPatiekala.Size = new System.Drawing.Size(169, 33);
            this.cmb_PasirinktiPatiekala.TabIndex = 9;
            this.cmb_PasirinktiPatiekala.SelectedIndexChanged += new System.EventHandler(this.cmb_PasirinktiPatiekala_SelectedIndexChanged);
            // 
            // tb_Kaina
            // 
            this.tb_Kaina.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Kaina.Location = new System.Drawing.Point(187, 148);
            this.tb_Kaina.Name = "tb_Kaina";
            this.tb_Kaina.ReadOnly = true;
            this.tb_Kaina.Size = new System.Drawing.Size(169, 31);
            this.tb_Kaina.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Uzsakyti
            // 
            this.btn_Uzsakyti.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Uzsakyti.Location = new System.Drawing.Point(187, 191);
            this.btn_Uzsakyti.Name = "btn_Uzsakyti";
            this.btn_Uzsakyti.Size = new System.Drawing.Size(169, 34);
            this.btn_Uzsakyti.TabIndex = 11;
            this.btn_Uzsakyti.Text = "Užsakyti";
            this.btn_Uzsakyti.UseVisualStyleBackColor = true;
            this.btn_Uzsakyti.Click += new System.EventHandler(this.btn_Uzsakyti_Click);
            // 
            // label_Suma
            // 
            this.label_Suma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_Suma.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Suma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Suma.Location = new System.Drawing.Point(311, 497);
            this.label_Suma.Name = "label_Suma";
            this.label_Suma.Size = new System.Drawing.Size(155, 37);
            this.label_Suma.TabIndex = 12;
            this.label_Suma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ApmoketiUzsakyma
            // 
            this.btn_ApmoketiUzsakyma.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ApmoketiUzsakyma.Location = new System.Drawing.Point(651, 307);
            this.btn_ApmoketiUzsakyma.Name = "btn_ApmoketiUzsakyma";
            this.btn_ApmoketiUzsakyma.Size = new System.Drawing.Size(169, 58);
            this.btn_ApmoketiUzsakyma.TabIndex = 13;
            this.btn_ApmoketiUzsakyma.Text = "Apmokėti užsakymą";
            this.btn_ApmoketiUzsakyma.UseVisualStyleBackColor = true;
            this.btn_ApmoketiUzsakyma.Click += new System.EventHandler(this.btn_ApmoketiUzsakyma_Click_1);
            // 
            // label_VietuSkaicius
            // 
            this.label_VietuSkaicius.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_VietuSkaicius.Location = new System.Drawing.Point(362, 15);
            this.label_VietuSkaicius.Name = "label_VietuSkaicius";
            this.label_VietuSkaicius.Size = new System.Drawing.Size(120, 30);
            this.label_VietuSkaicius.TabIndex = 14;
            this.label_VietuSkaicius.Text = "Vietų skaičius";
            // 
            // label_skaicius
            // 
            this.label_skaicius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_skaicius.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_skaicius.ForeColor = System.Drawing.Color.Black;
            this.label_skaicius.Location = new System.Drawing.Point(484, 7);
            this.label_skaicius.Name = "label_skaicius";
            this.label_skaicius.Size = new System.Drawing.Size(86, 39);
            this.label_skaicius.TabIndex = 15;
            this.label_skaicius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Gristi
            // 
            this.btn_Gristi.Location = new System.Drawing.Point(700, 490);
            this.btn_Gristi.Name = "btn_Gristi";
            this.btn_Gristi.Size = new System.Drawing.Size(120, 39);
            this.btn_Gristi.TabIndex = 16;
            this.btn_Gristi.Text = "Grįšti";
            this.btn_Gristi.UseVisualStyleBackColor = true;
            this.btn_Gristi.Click += new System.EventHandler(this.btn_Gristi_Click);
            // 
            // lbUzsakymoSuma
            // 
            this.lbUzsakymoSuma.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUzsakymoSuma.Location = new System.Drawing.Point(150, 503);
            this.lbUzsakymoSuma.Name = "lbUzsakymoSuma";
            this.lbUzsakymoSuma.Size = new System.Drawing.Size(155, 31);
            this.lbUzsakymoSuma.TabIndex = 17;
            this.lbUzsakymoSuma.Text = "Užsakymo suma:";
            // 
            // label_KlientoPaduotaSuma
            // 
            this.label_KlientoPaduotaSuma.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_KlientoPaduotaSuma.Location = new System.Drawing.Point(484, 207);
            this.label_KlientoPaduotaSuma.Name = "label_KlientoPaduotaSuma";
            this.label_KlientoPaduotaSuma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_KlientoPaduotaSuma.Size = new System.Drawing.Size(192, 30);
            this.label_KlientoPaduotaSuma.TabIndex = 18;
            this.label_KlientoPaduotaSuma.Text = "Kliento paduota suma";
            this.label_KlientoPaduotaSuma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Graza
            // 
            this.label_Graza.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Graza.Location = new System.Drawing.Point(484, 258);
            this.label_Graza.Name = "label_Graza";
            this.label_Graza.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_Graza.Size = new System.Drawing.Size(192, 30);
            this.label_Graza.TabIndex = 19;
            this.label_Graza.Text = "Grąža";
            // 
            // label_PaskaiciuotaGraza
            // 
            this.label_PaskaiciuotaGraza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_PaskaiciuotaGraza.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_PaskaiciuotaGraza.ForeColor = System.Drawing.Color.Black;
            this.label_PaskaiciuotaGraza.Location = new System.Drawing.Point(682, 251);
            this.label_PaskaiciuotaGraza.Name = "label_PaskaiciuotaGraza";
            this.label_PaskaiciuotaGraza.Size = new System.Drawing.Size(138, 37);
            this.label_PaskaiciuotaGraza.TabIndex = 20;
            this.label_PaskaiciuotaGraza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbKlientoPaduotaSuma
            // 
            this.tbKlientoPaduotaSuma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbKlientoPaduotaSuma.Location = new System.Drawing.Point(682, 207);
            this.tbKlientoPaduotaSuma.Name = "tbKlientoPaduotaSuma";
            this.tbKlientoPaduotaSuma.Size = new System.Drawing.Size(138, 34);
            this.tbKlientoPaduotaSuma.TabIndex = 21;
            this.tbKlientoPaduotaSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbKlientoPaduotaSuma.TextChanged += new System.EventHandler(this.tbKlientoPaduotaSuma_TextChanged);
            // 
            // UzsakymasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 541);
            this.Controls.Add(this.tbKlientoPaduotaSuma);
            this.Controls.Add(this.label_PaskaiciuotaGraza);
            this.Controls.Add(this.label_Graza);
            this.Controls.Add(this.label_KlientoPaduotaSuma);
            this.Controls.Add(this.lbUzsakymoSuma);
            this.Controls.Add(this.btn_Gristi);
            this.Controls.Add(this.label_skaicius);
            this.Controls.Add(this.label_VietuSkaicius);
            this.Controls.Add(this.btn_ApmoketiUzsakyma);
            this.Controls.Add(this.label_Suma);
            this.Controls.Add(this.btn_Uzsakyti);
            this.Controls.Add(this.tb_Kaina);
            this.Controls.Add(this.cmb_PasirinktiPatiekala);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_Kaina);
            this.Controls.Add(this.label_PasirinktiPatiekala);
            this.Controls.Add(this.btn_AtlaisvintiStaliuka);
            this.Controls.Add(this.tb_StaliukoUzimtumas);
            this.Controls.Add(this.tb_StaliukoNumeris);
            this.Controls.Add(this.tb_Data);
            this.Name = "UzsakymasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uzsakymas";
            this.Load += new System.EventHandler(this.UzsakymasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzsakymasRepozitorijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_Data;
        private TextBox tb_StaliukoNumeris;
        private TextBox tb_StaliukoUzimtumas;
        private Button btn_AtlaisvintiStaliuka;
        private Label label_PasirinktiPatiekala;
        private Label label_Kaina;
        private DataGridView dataGridView1;
        private ComboBox cmb_PasirinktiPatiekala;
        private TextBox tb_Kaina;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn Pavadinimas;
        private DataGridViewTextBoxColumn Kaina;
        private Button btn_Uzsakyti;
        private Label label_Suma;
        private Button btn_ApmoketiUzsakyma;
        private Label label_VietuSkaicius;
        private Label label_skaicius;
        private Button btn_Gristi;
        private Label lbUzsakymoSuma;
        private BindingSource uzsakymasRepozitorijaBindingSource;
        private Label label_KlientoPaduotaSuma;
        private Label label_Graza;
        private Label label_PaskaiciuotaGraza;
        private TextBox tbKlientoPaduotaSuma;
    }
}