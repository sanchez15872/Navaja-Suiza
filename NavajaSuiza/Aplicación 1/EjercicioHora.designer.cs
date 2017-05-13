
namespace NavajaSuiza.Aplicacion1
{
    /// <summary>
    /// Partial class FormularioHora
    /// </summary>
    partial class FormularioHora
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
            this.BotonMostrar = new System.Windows.Forms.Button();
            this.TextBoxHoras = new System.Windows.Forms.TextBox();
            this.TextBoxMinutos = new System.Windows.Forms.TextBox();
            this.TextBoxSegundos = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonMostrar
            // 
            this.BotonMostrar.Location = new System.Drawing.Point(277, 191);
            this.BotonMostrar.Name = "BotonMostrar";
            this.BotonMostrar.Size = new System.Drawing.Size(99, 58);
            this.BotonMostrar.TabIndex = 0;
            this.BotonMostrar.Text = "Hora";
            this.BotonMostrar.UseVisualStyleBackColor = true;
            this.BotonMostrar.Click += new System.EventHandler(this.BotonHora_Click);
            // 
            // TextBoxHoras
            // 
            this.TextBoxHoras.Location = new System.Drawing.Point(276, 55);
            this.TextBoxHoras.MaxLength = 2;
            this.TextBoxHoras.Name = "TextBoxHoras";
            this.TextBoxHoras.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHoras.TabIndex = 1;
            // 
            // TextBoxMinutos
            // 
            this.TextBoxMinutos.Location = new System.Drawing.Point(277, 97);
            this.TextBoxMinutos.MaxLength = 2;
            this.TextBoxMinutos.Name = "TextBoxMinutos";
            this.TextBoxMinutos.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMinutos.TabIndex = 2;
            // 
            // TextBoxSegundos
            // 
            this.TextBoxSegundos.Location = new System.Drawing.Point(277, 145);
            this.TextBoxSegundos.MaxLength = 2;
            this.TextBoxSegundos.Name = "TextBoxSegundos";
            this.TextBoxSegundos.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSegundos.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(171, 55);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Horas";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(171, 97);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(44, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Minutos";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(171, 145);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(55, 13);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Segundos";
            // 
            // FormularioHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 261);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBoxSegundos);
            this.Controls.Add(this.TextBoxMinutos);
            this.Controls.Add(this.TextBoxHoras);
            this.Controls.Add(this.BotonMostrar);
            this.Name = "FormularioHora";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonMostrar;
        private System.Windows.Forms.TextBox TextBoxHoras;
        private System.Windows.Forms.TextBox TextBoxMinutos;
        private System.Windows.Forms.TextBox TextBoxSegundos;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
    }
}

