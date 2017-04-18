
namespace NavajaSuiza.Aplicacion2
{
    /// <summary>
    /// Partial class FormularioFactorial
    /// </summary>
    partial class FormularioFactorial
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
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBoxFactorial = new System.Windows.Forms.TextBox();
            this.Boton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(34, 90);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(62, 18);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Número";
            // 
            // TextBoxFactorial
            // 
            this.TextBoxFactorial.Location = new System.Drawing.Point(140, 90);
            this.TextBoxFactorial.Name = "TextBoxFactorial";
            this.TextBoxFactorial.Size = new System.Drawing.Size(183, 20);
            this.TextBoxFactorial.TabIndex = 1;
            // 
            // Boton1
            // 
            this.Boton1.Location = new System.Drawing.Point(213, 153);
            this.Boton1.Name = "Boton1";
            this.Boton1.Size = new System.Drawing.Size(110, 23);
            this.Boton1.TabIndex = 2;
            this.Boton1.Text = "Calcular factorial";
            this.Boton1.UseVisualStyleBackColor = true;
            this.Boton1.Click += new System.EventHandler(this.BotonCalcular_Click);
            // 
            // FormularioFactorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 261);
            this.Controls.Add(this.Boton1);
            this.Controls.Add(this.TextBoxFactorial);
            this.Controls.Add(this.Label1);
            this.Name = "FormularioFactorial";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TextBoxFactorial;
        private System.Windows.Forms.Button Boton1;
    }
}

