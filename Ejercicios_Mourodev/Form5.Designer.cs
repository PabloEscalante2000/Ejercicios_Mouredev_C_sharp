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
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblAlto = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCuadrado = new System.Windows.Forms.RadioButton();
            this.rbRectángulo = new System.Windows.Forms.RadioButton();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.btnArea = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(35, 32);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(41, 13);
            this.lblAncho.TabIndex = 0;
            this.lblAncho.Text = "Ancho:";
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.Location = new System.Drawing.Point(38, 61);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(28, 13);
            this.lblAlto.TabIndex = 1;
            this.lblAlto.Text = "Alto:";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(99, 24);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 20);
            this.txtAncho.TabIndex = 2;
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(99, 53);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(100, 20);
            this.txtAlto.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCuadrado);
            this.groupBox1.Controls.Add(this.rbRectángulo);
            this.groupBox1.Controls.Add(this.rbTriangulo);
            this.groupBox1.Location = new System.Drawing.Point(38, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona la figura";
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
            this.rbCuadrado.CheckedChanged += new System.EventHandler(this.rbCuadrado_CheckedChanged);
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
            this.rbRectángulo.CheckedChanged += new System.EventHandler(this.rbRectángulo_CheckedChanged);
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
            this.rbTriangulo.CheckedChanged += new System.EventHandler(this.rbTriangulo_CheckedChanged);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(38, 229);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 5;
            this.btnArea.Text = "Área";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 301);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAlto);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.lblAlto);
            this.Controls.Add(this.lblAncho);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área de figuras Geométricas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label lblAlto;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCuadrado;
        private System.Windows.Forms.RadioButton rbRectángulo;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.Button btnArea;
    }
}