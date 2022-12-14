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
            // RestoranoSaskaitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 444);
            this.Controls.Add(this.rtb_RestoranoSaskaita);
            this.Name = "RestoranoSaskaitaForm";
            this.Text = "RestoranoSaskaita";
            this.Load += new System.EventHandler(this.RestoranoSaskaita_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtb_RestoranoSaskaita;
    }
}