using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_ARITMETICA
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0;
        char operador;


        public Form1()
        {
            InitializeComponent();
        }
        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (textResult.Text == "0")
                textResult.Text = "";
            textResult.Text += boton.Text;

        }

        private void buttonigual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textResult.Text);

            if (operador == '+')
            {
                textResult.Text = (num1 + num2) .ToString();
                num1 = Convert.ToDouble(textResult.Text);

            }
            else if (operador == '-')
            {
                textResult.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(textResult.Text);
            }
            else if (operador == '*')
            {
                textResult.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(textResult.Text);
            }
            else if (operador == '/')
            {
                textResult.Text = (num1 / num2).ToString();
                num1 = Convert.ToDouble(textResult.Text);
            }
        }

        private void buttonborrar_Click(object sender, EventArgs e)
        {
            if (textResult.Text.Length > 1)
            {
                textResult.Text = textResult.Text.Substring(0, textResult.Text.Length - 1);
            }
            else
            {
                textResult.Text = "'0";
            }
        }

        private void buttonborrartodo_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operador = '\0';
            textResult.Text = "0";

        }

        private void clicoperador (object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            num1 = Convert.ToDouble(textResult.Text);
            operador = Convert.ToChar(boton.Tag);

            textResult.Text = "0";
        }

       
    }
}
