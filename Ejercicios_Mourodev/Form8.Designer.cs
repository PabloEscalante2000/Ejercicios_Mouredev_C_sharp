namespace Ejercicios_Mourodev
{
    partial class Form8
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserta texto: ";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(90, 10);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(322, 20);
            this.txtTexto.TabIndex = 1;
            // 
            // lstPalabras
            // 
            this.lstPalabras.FormattingEnabled = true;
            this.lstPalabras.Location = new System.Drawing.Point(16, 85);
            this.lstPalabras.Name = "lstPalabras";
            this.lstPalabras.Size = new System.Drawing.Size(396, 186);
            this.lstPalabras.TabIndex = 2;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(16, 43);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(75, 23);
            this.btnContar.TabIndex = 3;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 286);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.lstPalabras);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de palabras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.ListBox lstPalabras;
        private System.Windows.Forms.Button btnContar;
    }
}