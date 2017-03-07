namespace NavajaSuiza.Aplicación_1
{
    partial class frmAplicacion1
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "En esta aplicación colocamos la hora, los minutos, y los segundos, este nos devol" +
    "verá la misma hora con un segundo de más";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 128);
            this.button1.TabIndex = 1;
            this.button1.Text = "LLama a la  lógica de la clase Aplicación1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAplicacion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "frmAplicacion1";
            this.Text = "Aplicacion1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}