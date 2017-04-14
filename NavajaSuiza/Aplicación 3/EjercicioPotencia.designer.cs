/// <summary>
/// Espacio de nombres de la Aplicación 3
/// </summary>
namespace NavajaSuiza.Aplicacion3
{
    /// <summary>
    /// Partial class FormularioPotencia
    /// </summary>
    partial class FormularioPotencia
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
            this.TextBoxNumero = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxPotencia = new System.Windows.Forms.TextBox();
            this.BotonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(60, 58);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Número";
            // 
            // TextBoxNumero
            // 
            this.TextBoxNumero.Location = new System.Drawing.Point(149, 51);
            this.TextBoxNumero.Name = "TextBoxNumero";
            this.TextBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNumero.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(60, 126);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(49, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Potencia";
            // 
            // TextBoxPotencia
            // 
            this.TextBoxPotencia.Location = new System.Drawing.Point(149, 126);
            this.TextBoxPotencia.Name = "TextBoxPotencia";
            this.TextBoxPotencia.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPotencia.TabIndex = 3;
            // 
            // BotonCalcular
            // 
            this.BotonCalcular.Location = new System.Drawing.Point(149, 196);
            this.BotonCalcular.Name = "BotonCalcular";
            this.BotonCalcular.Size = new System.Drawing.Size(100, 23);
            this.BotonCalcular.TabIndex = 4;
            this.BotonCalcular.Text = "Resultado";
            this.BotonCalcular.UseVisualStyleBackColor = true;
            this.BotonCalcular.Click += new System.EventHandler(this.BotonPotencia_Click);
            // 
            // FormularioPotencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BotonCalcular);
            this.Controls.Add(this.TextBoxPotencia);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBoxNumero);
            this.Controls.Add(this.Label1);
            this.Name = "FormularioPotencia";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TextBoxNumero;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox TextBoxPotencia;
        private System.Windows.Forms.Button BotonCalcular;
    }
}

