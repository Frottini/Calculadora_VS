using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Decimal Valor1 = 0, Valor2 = 0;
        String operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtValor.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtValor.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtValor.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtValor.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtValor.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtValor.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtValor.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtValor.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtValor.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtValor.Text += "9";
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            txtValor.Text += ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Valor2 = decimal.Parse(txtValor.Text, CultureInfo.InvariantCulture);
            
         if (operacao == "SOMA")
         { 
                txtValor.Text = Convert.ToString(Valor1 + Valor2);
         }
         else if (operacao == "SUB")
         {
                txtValor.Text = Convert.ToString(Valor1 - Valor2);
         }
         else if (operacao == "MULT")
         {
                txtValor.Text = Convert.ToString(Valor1 * Valor2);
         }
         else
         {
                txtValor.Text = Convert.ToString(Valor1 / Valor2);
         }
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            Valor1 = decimal.Parse(txtValor.Text, CultureInfo.InvariantCulture);

            txtValor.Text = "";
            operacao = "SUB";
            label1.Text = "-";
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            Valor1 = decimal.Parse(txtValor.Text, CultureInfo.InvariantCulture);
            txtValor.Text = "";
            operacao = "MULT";
            label1.Text = "x";
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            Valor1 = decimal.Parse(txtValor.Text, CultureInfo.InvariantCulture);

            txtValor.Text = "";
            operacao = "DIV";
            label1.Text = "/";
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            label1.Text = "";
        }

        private void btn_Adicao_Click(object sender, EventArgs e)
        {
            Valor1 = decimal.Parse (txtValor.Text, CultureInfo.InvariantCulture);

            txtValor.Text = "";
            operacao = "SOMA";
            label1.Text = "+";
        }
    }
}
