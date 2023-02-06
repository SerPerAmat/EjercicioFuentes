namespace EjercicioFuentes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.texto = new System.Windows.Forms.Label();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Location = new System.Drawing.Point(232, 33);
            this.texto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(165, 15);
            this.texto.TabIndex = 0;
            this.texto.Text = "En algun lugar de la Mancha";
            this.texto.Click += new System.EventHandler(this.texto_Click);
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(100, 225);
            this.boton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(68, 40);
            this.boton1.TabIndex = 1;
            this.boton1.Text = "Negrita";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(278, 225);
            this.boton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(78, 40);
            this.boton2.TabIndex = 2;
            this.boton2.Text = "Cursiva";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(459, 225);
            this.boton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(76, 40);
            this.boton3.TabIndex = 3;
            this.boton3.Text = "Subrayar";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(256, 131);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 4;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.texto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Ejercicio Fuentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.TextBox textBox;
    }
}

