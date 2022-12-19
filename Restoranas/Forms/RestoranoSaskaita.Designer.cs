namespace Restoranas.Forms
{
    partial class RestoranoSaskaitaForm
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
            this.rtb_RestoranoSaskaita = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_SiustiEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_RestoranoSaskaita
            // 
            this.rtb_RestoranoSaskaita.Location = new System.Drawing.Point(12, 12);
            this.rtb_RestoranoSaskaita.Name = "rtb_RestoranoSaskaita";
            this.rtb_RestoranoSaskaita.Size = new System.Drawing.Size(378, 426);
            this.rtb_RestoranoSaskaita.TabIndex = 0;
            this.rtb_RestoranoSaskaita.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 444);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 27);
            this.textBox2.TabIndex = 3;
            // 
            // button_SiustiEmail
            // 
            this.button_SiustiEmail.AllowDrop = true;
            this.button_SiustiEmail.Location = new System.Drawing.Point(270, 444);
            this.button_SiustiEmail.Name = "button_SiustiEmail";
            this.button_SiustiEmail.Size = new System.Drawing.Size(120, 33);
            this.button_SiustiEmail.TabIndex = 4;
            this.button_SiustiEmail.Text = "Siųsti Email";
            this.button_SiustiEmail.UseVisualStyleBackColor = true;
            this.button_SiustiEmail.Click += new System.EventHandler(this.button_SiustiEmail_Click);
            // 
            // RestoranoSaskaitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 480);
            this.Controls.Add(this.button_SiustiEmail);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rtb_RestoranoSaskaita);
            this.Name = "RestoranoSaskaitaForm";
            this.Text = "RestoranoSaskaita";
            this.Load += new System.EventHandler(this.RestoranoSaskaita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtb_RestoranoSaskaita;
        private TextBox textBox2;
        private Button button_SiustiEmail;
    }
}