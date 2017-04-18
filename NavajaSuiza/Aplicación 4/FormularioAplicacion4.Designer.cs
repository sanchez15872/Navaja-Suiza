
namespace NavajaSuiza.Aplicacion4
{
    /// <summary>
    /// Partial class frmAplicacion4
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
            this.Boton1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Boton1
            // 
            this.Boton1.Location = new System.Drawing.Point(205, 111);
            this.Boton1.Name = "Boton1";
            this.Boton1.Size = new System.Drawing.Size(92, 85);
            this.Boton1.TabIndex = 0;
            this.Boton1.Text = "LLama a la  lógica de la clase Aplicación4";
            this.Boton1.UseVisualStyleBackColor = true;
            this.Boton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(63, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(362, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Este Programa te calcula la succesión de fibonacci de un numero insertado";
            // 
            // FormularioAplicacion4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 261);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Boton1);
            this.Name = "FormularioAplicacion4";
            this.Text = "frmAplicacion4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton1;
        private System.Windows.Forms.Label Label1;
    }
}