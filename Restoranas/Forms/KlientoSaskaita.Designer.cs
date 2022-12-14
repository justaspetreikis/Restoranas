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
            // KlientoSaskaitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.rtb_KlientoSaskaita);
            this.Name = "KlientoSaskaitaForm";
            this.Text = "KlientoSaskaita";
            this.Load += new System.EventHandler(this.KlientoSaskaitaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtb_KlientoSaskaita;
    }
}