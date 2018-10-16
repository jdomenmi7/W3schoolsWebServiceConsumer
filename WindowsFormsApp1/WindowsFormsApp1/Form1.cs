using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.serviciow3schools;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           serviciow3schools.TempConvert temperatura = new serviciow3schools.TempConvert();
            String texto = textCtoF.Text.ToString();
            String a = temperatura.CelsiusToFahrenheit(texto);
            labelResponse.Text = "Respuest Servidor" + " " + a.ToString();
        }       
    }
}
