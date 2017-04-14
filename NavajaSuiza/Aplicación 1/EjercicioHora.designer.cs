/// <summary>
/// Espacio de nombres de la Aplicación 1
/// </summary>
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
            this.Horas = new System.Windows.Forms.TextBox();
            this.Minutos = new System.Windows.Forms.TextBox();
            this.Segundos = new System.Windows.Forms.TextBox();
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
            // Horas
            // 
            this.Horas.Location = new System.Drawing.Point(276, 55);
            this.Horas.Name = "Horas";
            this.Horas.Size = new System.Drawing.Size(100, 20);
            this.Horas.TabIndex = 1;
            // 
            // Minutos
            // 
            this.Minutos.Location = new System.Drawing.Point(277, 97);
            this.Minutos.Name = "Minutos";
            this.Minutos.Size = new System.Drawing.Size(100, 20);
            this.Minutos.TabIndex = 2;
            // 
            // Segundos
            // 
            this.Segundos.Location = new System.Drawing.Point(277, 145);
            this.Segundos.Name = "Segundos";
            this.Segundos.Size = new System.Drawing.Size(100, 20);
            this.Segundos.TabIndex = 3;
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
            this.Controls.Add(this.Segundos);
            this.Controls.Add(this.Minutos);
            this.Controls.Add(this.Horas);
            this.Controls.Add(this.BotonMostrar);
            this.Name = "FormularioHora";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonMostrar;
        private System.Windows.Forms.TextBox Horas;
        private System.Windows.Forms.TextBox Minutos;
        private System.Windows.Forms.TextBox Segundos;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
    }
}

