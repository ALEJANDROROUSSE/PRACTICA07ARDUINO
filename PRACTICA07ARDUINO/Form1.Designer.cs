namespace PRACTICA07ARDUINO
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
            this.btnAPAGAR = new System.Windows.Forms.Button();
            this.btnENCENDER = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAPAGAR
            // 
            this.btnAPAGAR.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAPAGAR.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAPAGAR.Location = new System.Drawing.Point(130, 189);
            this.btnAPAGAR.Name = "btnAPAGAR";
            this.btnAPAGAR.Size = new System.Drawing.Size(215, 123);
            this.btnAPAGAR.TabIndex = 0;
            this.btnAPAGAR.Text = "APAGAR";
            this.btnAPAGAR.UseVisualStyleBackColor = false;
            this.btnAPAGAR.Click += new System.EventHandler(this.btnAPAGAR_Click);
            // 
            // btnENCENDER
            // 
            this.btnENCENDER.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnENCENDER.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnENCENDER.Location = new System.Drawing.Point(491, 189);
            this.btnENCENDER.Name = "btnENCENDER";
            this.btnENCENDER.Size = new System.Drawing.Size(223, 123);
            this.btnENCENDER.TabIndex = 1;
            this.btnENCENDER.Text = "ENCENDER";
            this.btnENCENDER.UseVisualStyleBackColor = false;
            this.btnENCENDER.Click += new System.EventHandler(this.btnENCENDER_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(865, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRÁCTICA 07 ALEJANDRO ROUSSE Y LUIS EDUARDO VARGAS 3-O";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(1038, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnENCENDER);
            this.Controls.Add(this.btnAPAGAR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAPAGAR;
        private System.Windows.Forms.Button btnENCENDER;
        private System.Windows.Forms.Label label1;
    }
}

