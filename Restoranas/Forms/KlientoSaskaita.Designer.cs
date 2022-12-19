namespace Restoranas.Forms
{
    partial class KlientoSaskaitaForm
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
            this.rtb_KlientoSaskaita = new System.Windows.Forms.RichTextBox();
            this.button_SiustiEmail = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtb_KlientoSaskaita
            // 
            this.rtb_KlientoSaskaita.Location = new System.Drawing.Point(12, 12);
            this.rtb_KlientoSaskaita.Name = "rtb_KlientoSaskaita";
            this.rtb_KlientoSaskaita.ReadOnly = true;
            this.rtb_KlientoSaskaita.Size = new System.Drawing.Size(378, 426);
            this.rtb_KlientoSaskaita.TabIndex = 0;
            this.rtb_KlientoSaskaita.Text = "";
            this.rtb_KlientoSaskaita.TextChanged += new System.EventHandler(this.rtb_KlientoSaskaita_TextChanged);
            // 
            // button_SiustiEmail
            // 
            this.button_SiustiEmail.AllowDrop = true;
            this.button_SiustiEmail.Location = new System.Drawing.Point(270, 441);
            this.button_SiustiEmail.Name = "button_SiustiEmail";
            this.button_SiustiEmail.Size = new System.Drawing.Size(120, 33);
            this.button_SiustiEmail.TabIndex = 1;
            this.button_SiustiEmail.Text = "Siųsti Email";
            this.button_SiustiEmail.UseVisualStyleBackColor = true;
            this.button_SiustiEmail.Click += new System.EventHandler(this.button_SiustiEmail_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 447);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 27);
            this.textBox2.TabIndex = 2;
            // 
            // KlientoSaskaitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 480);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button_SiustiEmail);
            this.Controls.Add(this.rtb_KlientoSaskaita);
            this.Name = "KlientoSaskaitaForm";
            this.Text = "KlientoSaskaita";
            this.Load += new System.EventHandler(this.KlientoSaskaitaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtb_KlientoSaskaita;
        private Button button_SiustiEmail;
        private TextBox textBox2;
    }
}