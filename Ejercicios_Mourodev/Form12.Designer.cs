namespace Ejercicios_Mourodev
{
    partial class Form12
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtUno = new System.Windows.Forms.TextBox();
            this.txtDos = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUnoSinDos = new System.Windows.Forms.Label();
            this.lblDosSinUno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "primera cadena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "segunda cadena:";
            // 
            // txtUno
            // 
            this.txtUno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUno.Location = new System.Drawing.Point(123, 10);
            this.txtUno.Name = "txtUno";
            this.txtUno.Size = new System.Drawing.Size(335, 20);
            this.txtUno.TabIndex = 2;
            // 
            // txtDos
            // 
            this.txtDos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDos.Location = new System.Drawing.Point(123, 51);
            this.txtDos.Name = "txtDos";
            this.txtDos.Size = new System.Drawing.Size(335, 20);
            this.txtDos.TabIndex = 3;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(16, 98);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(99, 23);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "CONVERTIR";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cadena 1 sin carateres de la 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cadena 2 sin caracteres de la 1";
            // 
            // lblUnoSinDos
            // 
            this.lblUnoSinDos.AutoSize = true;
            this.lblUnoSinDos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnoSinDos.Location = new System.Drawing.Point(206, 153);
            this.lblUnoSinDos.Name = "lblUnoSinDos";
            this.lblUnoSinDos.Size = new System.Drawing.Size(78, 15);
            this.lblUnoSinDos.TabIndex = 7;
            this.lblUnoSinDos.Text = "                       ";
            // 
            // lblDosSinUno
            // 
            this.lblDosSinUno.AutoSize = true;
            this.lblDosSinUno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDosSinUno.Location = new System.Drawing.Point(206, 191);
            this.lblDosSinUno.Name = "lblDosSinUno";
            this.lblDosSinUno.Size = new System.Drawing.Size(78, 15);
            this.lblDosSinUno.TabIndex = 8;
            this.lblDosSinUno.Text = "                       ";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.lblDosSinUno);
            this.Controls.Add(this.lblUnoSinDos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtDos);
            this.Controls.Add(this.txtUno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form12";
            this.Text = "Eliminando carácteres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUno;
        private System.Windows.Forms.TextBox txtDos;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUnoSinDos;
        private System.Windows.Forms.Label lblDosSinUno;
    }
}