using System;

namespace WindowsFormsApp1
{
    partial class Form1
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
            this.labelCtoF = new System.Windows.Forms.Label();
            this.textCtoF = new System.Windows.Forms.TextBox();
            this.buttonCtoF = new System.Windows.Forms.Button();
            this.labelResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCtoF
            // 
            this.labelCtoF.AutoSize = true;
            this.labelCtoF.Location = new System.Drawing.Point(169, 73);
            this.labelCtoF.Name = "labelCtoF";
            this.labelCtoF.Size = new System.Drawing.Size(35, 13);
            this.labelCtoF.TabIndex = 0;
            this.labelCtoF.Text = "Celsius to Farenheit";
            
            // 
            // textCtoF
            // 
            this.textCtoF.Location = new System.Drawing.Point(172, 102);
            this.textCtoF.Name = "textCtoF";
            this.textCtoF.Size = new System.Drawing.Size(100, 20);
            this.textCtoF.TabIndex = 1;
            // 
            // buttonCtoF
            // 
            this.buttonCtoF.Location = new System.Drawing.Point(172, 129);
            this.buttonCtoF.Name = "buttonCtoF";
            this.buttonCtoF.Size = new System.Drawing.Size(75, 23);
            this.buttonCtoF.TabIndex = 2;
            this.buttonCtoF.Text = "Calcular";
            this.buttonCtoF.UseVisualStyleBackColor = true;
            this.buttonCtoF.Click += new System.EventHandler(this.buttonCtoF_Click);
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Location = new System.Drawing.Point(172, 159);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(35, 13);
            this.labelResponse.TabIndex = 3;
            this.labelResponse.Text = "Respuesta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResponse);
            this.Controls.Add(this.buttonCtoF);
            this.Controls.Add(this.textCtoF);
            this.Controls.Add(this.labelCtoF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonCtoF_Click(object sender, EventArgs e)
        {
            serviciow3schools.TempConvert temperatura = new serviciow3schools.TempConvert();
            String texto = textCtoF.Text.ToString();
            String a = temperatura.CelsiusToFahrenheit(texto);
            labelResponse.Text = "Respuest Servidor" + " " + a.ToString();
        }

        #endregion

        private System.Windows.Forms.Label labelCtoF;
        private System.Windows.Forms.TextBox textCtoF;
        private System.Windows.Forms.Button buttonCtoF;
        private System.Windows.Forms.Label labelResponse;
    }
}

