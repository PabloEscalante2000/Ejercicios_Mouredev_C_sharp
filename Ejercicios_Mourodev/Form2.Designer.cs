namespace Ejercicios_Mourodev
{
    partial class Form2
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
            this.txtNom1 = new System.Windows.Forms.TextBox();
            this.txtNom2 = new System.Windows.Forms.TextBox();
            this.btnAnagrama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palabra 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palabra 2:";
            // 
            // txtNom1
            // 
            this.txtNom1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNom1.Location = new System.Drawing.Point(137, 35);
            this.txtNom1.Name = "txtNom1";
            this.txtNom1.Size = new System.Drawing.Size(100, 20);
            this.txtNom1.TabIndex = 2;
            // 
            // txtNom2
            // 
            this.txtNom2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNom2.Location = new System.Drawing.Point(137, 71);
            this.txtNom2.Name = "txtNom2";
            this.txtNom2.Size = new System.Drawing.Size(100, 20);
            this.txtNom2.TabIndex = 3;
            // 
            // btnAnagrama
            // 
            this.btnAnagrama.Location = new System.Drawing.Point(80, 154);
            this.btnAnagrama.Name = "btnAnagrama";
            this.btnAnagrama.Size = new System.Drawing.Size(118, 23);
            this.btnAnagrama.TabIndex = 4;
            this.btnAnagrama.Text = "¿Son anagramas?";
            this.btnAnagrama.UseVisualStyleBackColor = true;
            this.btnAnagrama.Click += new System.EventHandler(this.btnAnagrama_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 213);
            this.Controls.Add(this.btnAnagrama);
            this.Controls.Add(this.txtNom2);
            this.Controls.Add(this.txtNom1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom1;
        private System.Windows.Forms.TextBox txtNom2;
        private System.Windows.Forms.Button btnAnagrama;
    }
}