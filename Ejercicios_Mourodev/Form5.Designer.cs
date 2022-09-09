namespace Ejercicios_Mourodev
{
    partial class Form5
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbRectángulo = new System.Windows.Forms.RadioButton();
            this.rbCuadrado = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ancho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCuadrado);
            this.groupBox1.Controls.Add(this.rbRectángulo);
            this.groupBox1.Controls.Add(this.rbTriangulo);
            this.groupBox1.Location = new System.Drawing.Point(295, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona la figura";
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(19, 19);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rbTriangulo.TabIndex = 0;
            this.rbTriangulo.TabStop = true;
            this.rbTriangulo.Text = "Triángulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            // 
            // rbRectángulo
            // 
            this.rbRectángulo.AutoSize = true;
            this.rbRectángulo.Location = new System.Drawing.Point(19, 43);
            this.rbRectángulo.Name = "rbRectángulo";
            this.rbRectángulo.Size = new System.Drawing.Size(80, 17);
            this.rbRectángulo.TabIndex = 1;
            this.rbRectángulo.TabStop = true;
            this.rbRectángulo.Text = "Rectángulo";
            this.rbRectángulo.UseVisualStyleBackColor = true;
            // 
            // rbCuadrado
            // 
            this.rbCuadrado.AutoSize = true;
            this.rbCuadrado.Location = new System.Drawing.Point(19, 67);
            this.rbCuadrado.Name = "rbCuadrado";
            this.rbCuadrado.Size = new System.Drawing.Size(71, 17);
            this.rbCuadrado.TabIndex = 2;
            this.rbCuadrado.TabStop = true;
            this.rbCuadrado.Text = "Cuadrado";
            this.rbCuadrado.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCuadrado;
        private System.Windows.Forms.RadioButton rbRectángulo;
        private System.Windows.Forms.RadioButton rbTriangulo;
    }
}