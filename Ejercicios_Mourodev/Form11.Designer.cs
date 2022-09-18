namespace Ejercicios_Mourodev
{
    partial class Form11
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
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.btnEquilibrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESCRIBE LA FUNCIÓN";
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(139, 10);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(461, 20);
            this.txtExpresion.TabIndex = 1;
            // 
            // btnEquilibrada
            // 
            this.btnEquilibrada.Location = new System.Drawing.Point(16, 41);
            this.btnEquilibrada.Name = "btnEquilibrada";
            this.btnEquilibrada.Size = new System.Drawing.Size(117, 23);
            this.btnEquilibrada.TabIndex = 2;
            this.btnEquilibrada.Text = "¿Está equilibrada?";
            this.btnEquilibrada.UseVisualStyleBackColor = true;
            this.btnEquilibrada.Click += new System.EventHandler(this.btnEquilibrada_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 80);
            this.Controls.Add(this.btnEquilibrada);
            this.Controls.Add(this.txtExpresion);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¿La funcion está equilibrada?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Button btnEquilibrada;
    }
}