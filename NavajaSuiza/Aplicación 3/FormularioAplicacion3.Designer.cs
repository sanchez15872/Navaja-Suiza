/// <summary>
/// Espacio de nombres de la Aplicación 3
/// </summary>
namespace NavajaSuiza.Aplicacion3
{
    /// <summary>
    /// partial class de frmAplicacion3
    /// </summary>
    partial class FormularioAplicacion4
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Boton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(23, 39);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(465, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Esta Aplicacion te calcula la potencia de un numero, primero te pide la base y lu" +
    "ego el exponente";
            // 
            // Boton1
            // 
            this.Boton1.Location = new System.Drawing.Point(213, 118);
            this.Boton1.Name = "Boton1";
            this.Boton1.Size = new System.Drawing.Size(98, 93);
            this.Boton1.TabIndex = 1;
            this.Boton1.Text = "LLama a la  lógica de la clase Aplicación3";
            this.Boton1.UseVisualStyleBackColor = true;
            this.Boton1.Click += new System.EventHandler(this.Boton1_Click);
            // 
            // FormularioAplicacion4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 261);
            this.Controls.Add(this.Boton1);
            this.Controls.Add(this.Label1);
            this.Name = "FormularioAplicacion4";
            this.Text = "frmAplicacion3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Boton1;
    }
}