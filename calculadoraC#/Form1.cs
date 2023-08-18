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

namespace calculadoraC_
{
    public partial class Form1 : Form
    {
        
        
        private enum Operacoes
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        private Operacoes OperacaoSelect { get; set; }
        public double Valor { get; set; }
        public double Resultado { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        //Botão 1
        private void button7_Click(object sender, EventArgs e)
        {

              printNumeros.Text = printNumeros.Text += "1";
            
        }

        //Botão 2
        private void button8_Click(object sender, EventArgs e)
        {

               printNumeros.Text = printNumeros.Text += "2";


        }

        //Botão 3
        private void button9_Click(object sender, EventArgs e)
        {

                printNumeros.Text = printNumeros.Text += "3";


        }

        //Botão 4
        private void button4_Click(object sender, EventArgs e)
        {

                printNumeros.Text = printNumeros.Text += "4";

        }

        //Botão 5
        private void button5_Click(object sender, EventArgs e)
        {
   
                printNumeros.Text = printNumeros.Text += "5";

        }

        //Botão 6
        private void button6_Click(object sender, EventArgs e)
        {

                printNumeros.Text = printNumeros.Text += "6";

        }

        //Botão 7
        private void button1_Click(object sender, EventArgs e)
        {

                printNumeros.Text = printNumeros.Text += "7";

        }

        //Botão 8
        private void button2_Click(object sender, EventArgs e)
        {


                printNumeros.Text = printNumeros.Text += "8";

        }

        //Botão 9
        private void button3_Click(object sender, EventArgs e)
        {

                printNumeros.Text = printNumeros.Text += "9";

        }

        //Botão 0
        private void button11_Click(object sender, EventArgs e)
        {
           
                printNumeros.Text = printNumeros.Text += "0";

        }

        //Botão Clear
        private void button14_Click(object sender, EventArgs e)
        {
                printNumeros.Text = "";
                aparecerOperador.Text = "";
        }

        //Botão da vírgula
        private void button10_Click(object sender, EventArgs e)
        {

            //Tratamento de exceção para, se caso, o usuário clicar antes de inserir qualquer número
            if (printNumeros.Text != "")
            {
                if (!Convert.ToString(printNumeros.Text).Contains(","))
                {
                    printNumeros.Text = printNumeros.Text += ",";
                }

            }
            
            else
            {
                printNumeros.Text = "";
            }
            
        }

        //Botão de adição
        private void button16_Click(object sender, EventArgs e)
        {
            //Tratamento de exceção para, se caso, o usuário clicar antes de inserir qualquer número
            if (printNumeros.Text != "")
            {
                OperacaoSelect = Operacoes.Adicao;
                Valor = Convert.ToDouble(printNumeros.Text);
                printNumeros.Text = "";
                aparecerOperador.Text = "+";

            }

            else
            {
                printNumeros.Text = "";
            }
            

        }

        //Botão de subtração
        private void button17_Click(object sender, EventArgs e)
        {
            //Tratamento de exceção para, se caso, o usuário clicar antes de inserir qualquer número
            if (printNumeros.Text != "")
            {
                OperacaoSelect = Operacoes.Subtracao;
                Valor = Convert.ToDouble(printNumeros.Text); 
                printNumeros.Text = "";
                aparecerOperador.Text = "-";

            }

            else
            {
                printNumeros.Text = "";
            }
            
        }

        //Botão de mutliplicação
        private void button13_Click(object sender, EventArgs e)
        {
            //Tratamento de exceção para, se caso, o usuário clicar antes de inserir qualquer número
            if (printNumeros.Text != "")
            {
                OperacaoSelect = Operacoes.Multiplicacao;
                Valor = Convert.ToDouble(printNumeros.Text);
                printNumeros.Text = "";
                aparecerOperador.Text = "x";

            }

            else
            {
                printNumeros.Text = "";
            }
        }

        //Botão de divisão
        private void button15_Click(object sender, EventArgs e)
        {
            if (printNumeros.Text != ""){

                OperacaoSelect = Operacoes.Divisao;
                Valor = Convert.ToDouble(printNumeros.Text);
                printNumeros.Text = "";
                aparecerOperador.Text = "÷";

            }

            else
            {
                printNumeros.Text = "";
            }
        }

        //Botão de resultado
        private void button12_Click(object sender, EventArgs e)
        {
            //Tratamento de exceção para, se caso, o usuário clicar antes de inserir qualquer número
            if (printNumeros.Text != "")
            {
  
                aparecerOperador.Text = "=";
                switch (OperacaoSelect)
                {
                    case Operacoes.Adicao:
                        Resultado = Valor + Convert.ToDouble(printNumeros.Text);
                        break;

                    case Operacoes.Subtracao:
                        Resultado = Valor - Convert.ToDouble(printNumeros.Text);
                        break;

                    case Operacoes.Multiplicacao:
                        Resultado = Valor * Convert.ToDouble(printNumeros.Text);
                        break;

                    case Operacoes.Divisao:
                        Resultado = Valor / Convert.ToDouble(printNumeros.Text);
                        break;
                }

            }

            else
            {
                printNumeros.Text = "";
            }

            printNumeros.Text = Convert.ToString(Resultado);
        }
    }
}