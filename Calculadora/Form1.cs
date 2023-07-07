using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Linq.Expressions;

namespace Calculadora
{
    public partial class TelaCalculadora : Form
    {
        decimal calculo;
        bool adicao, subtracao, divisao, multiplicacao, resultado, porcent = false;
       


        public TelaCalculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculo = decimal.Parse(txtResult.Text);
            txtOperacao.Text += "*";
            txtResult.Text = "";

            adicao = false;
            subtracao = false;
            divisao = false;
            multiplicacao = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculo = decimal.Parse(txtResult.Text);
            txtOperacao.Text += "-";
            txtResult.Text = "";

            adicao = false;
            subtracao = true;
            divisao = false;
            multiplicacao = false;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string apagar = txtResult.Text;
                apagar = apagar.Remove(apagar.Length - 1);
                txtResult.Text = apagar;
            }
            catch(Exception) { 

            }
        }
        

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";

            txtOperacao.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";

            txtOperacao.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";

            txtOperacao.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";

            txtOperacao.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";

            txtOperacao.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";

            txtOperacao.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";

            txtOperacao.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";

            txtOperacao.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";

            txtOperacao.Text += "9";
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";

            txtOperacao.Text += "0";
        }


        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtResult.Text += ",";

            txtOperacao.Text += ",";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            resultado = true;

            txtOperacao.Text += "=";
            

            if(adicao == true)
            {
                txtResult.Text = Convert.ToString(decimal.Parse(txtResult.Text) + calculo);

                txtOperacao.Text += txtResult.Text;
            }
            else if(subtracao == true){
                txtResult.Text = Convert.ToString(calculo - decimal.Parse(txtResult.Text));

                txtOperacao.Text += txtResult.Text;
            }
            else if(divisao == true)
            {
                txtResult.Text = Convert.ToString( calculo / decimal.Parse(txtResult.Text));

                txtOperacao.Text += txtResult.Text;
            }
            else if(multiplicacao == true)
            {
                txtResult.Text = Convert.ToString(decimal.Parse(txtResult.Text) * calculo);

                txtOperacao.Text += txtResult.Text;
            }
           
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            calculo = decimal.Parse(txtResult.Text);
            txtOperacao.Text += "/";
            txtResult.Text = "";

            adicao = false;
            subtracao = false;
            divisao = true;
            multiplicacao = false;


        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            calculo = decimal.Parse(txtResult.Text);
            txtOperacao.Text += "+";
            txtResult.Text = "";

            adicao = true;
            subtracao = false;
            divisao = false;
            multiplicacao = false;
            
        }

        private void btnPorcen_Click(object sender, EventArgs e)
        {
            calculo = decimal.Parse(txtResult.Text);
            txtOperacao.Text += "%";
            txtResult.Text = Convert.ToString(calculo / 100);

            adicao = false;
            subtracao = false;
            divisao = false;
            multiplicacao = false;
            porcent = true;
                
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtOperacao.Text = "";

            adicao = false;
            subtracao = false;
            divisao = false;
            multiplicacao = false;
            resultado = false;

        }
    }
}
