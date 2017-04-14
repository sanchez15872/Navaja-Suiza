/// <summary>
/// Espacio de nombres de la Aplicación 4
/// </summary>
namespace NavajaSuiza.Aplicacion4
{
    /// <summary>
    /// partial class del FormularioFibonacci
    /// </summary>
    partial class FormularioFibonacci
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
            this.TextBoxFibonacci = new System.Windows.Forms.TextBox();
            this.BotonCalcular = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxFibonacci
            // 
            this.TextBoxFibonacci.Location = new System.Drawing.Point(91, 97);
            this.TextBoxFibonacci.Name = "TextBoxFibonacci";
            this.TextBoxFibonacci.Size = new System.Drawing.Size(110, 20);
            this.TextBoxFibonacci.TabIndex = 0;
            // 
            // BotonCalcular
            // 
            this.BotonCalcular.Location = new System.Drawing.Point(91, 154);
            this.BotonCalcular.Name = "BotonCalcular";
            this.BotonCalcular.Size = new System.Drawing.Size(110, 23);
            this.BotonCalcular.TabIndex = 1;
            this.BotonCalcular.Text = "Mostrar Fibonacci";
            this.BotonCalcular.UseVisualStyleBackColor = true;
            this.BotonCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 97);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Numero";
            // 
            // FormularioFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BotonCalcular);
            this.Controls.Add(this.TextBoxFibonacci);
            this.Name = "FormularioFibonacci";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormularioFibonacci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxFibonacci;
        private System.Windows.Forms.Button BotonCalcular;
        private System.Windows.Forms.Label Label1;
    }
}

