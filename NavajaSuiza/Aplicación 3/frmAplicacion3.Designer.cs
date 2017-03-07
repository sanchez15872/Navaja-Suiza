namespace NavajaSuiza.Aplicacion3
{
    partial class frmAplicacion3
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
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esta Aplicacion te calcula la potencia de un numero, primero te pide la base y lu" +
    "ego el exponente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 93);
            this.button1.TabIndex = 1;
            this.button1.Text = "LLama a la  lógica de la clase Aplicación3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAplicacion3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "frmAplicacion3";
            this.Text = "frmAplicacion3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}