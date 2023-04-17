using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora_Tarefa
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        double valorA;
        double valorB;
        string operador;
        double result;
        int count;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            tbDigitado.Text = tbDigitado.Text + "1";
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            tbDigitado.Text = tbDigitado.Text + "2";
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            tbDigitado.Text = tbDigitado.Text + "3";
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            tbDigitado.Text = tbDigitado.Text + "4";
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            tbDigitado.Text = tbDigitado.Text + "5";
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            tbDigitado.Text = tbDigitado.Text + "6";
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            tbDigitado.Text = tbDigitado.Text + "7";
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            tbDigitado.Text = tbDigitado.Text + "8";
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            tbDigitado.Text = tbDigitado.Text + "9";
        }

        private void bt0_Click(object sender, RoutedEventArgs e)
        {
            tbDigitado.Text = tbDigitado.Text + "0";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tbDigitado.Text = tbDigitado.Text + ",";
        }

        //Operadores
        private void btMais_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Considerando operador +
                if (operador == "+")
                {
                    if (count == 1)
                    {
                        valorB = Convert.ToDouble(tbDigitado.Text);
                        result = result + valorB;
                        tbCapture.Text = result.ToString() + $"{operador}";
                        tbDigitado.Clear();
                    }

                    if (valorA != 0 && tbDigitado.Text != null && count == 0)
                    {
                        valorB = Convert.ToDouble(tbDigitado.Text);
                        result = valorA + valorB;
                        tbCapture.Text = result.ToString() + $"{operador}";
                        tbDigitado.Clear();
                        count = 1;
                    }
                }
                if (valorA == 0)
                {
                    valorA = Convert.ToDouble(tbDigitado.Text);
                    operador = "+";
                    tbCapture.Text = valorA.ToString() + $"{operador}";
                    tbDigitado.Clear();
                }

                //Considerando outros operadores
                if (operador == "-")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('-', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result - valorB;
                    operador = "+";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }

                if (operador == "*")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('*', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result * valorB;
                    operador = "+";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }

                if (operador == "/")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('/', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result / valorB;
                    operador = "+";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }

                if (operador == "%")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('%', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = valorB * (result / 100);
                    operador = "+";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }
            }
            catch(Exception ex)
            {
                if(tbDigitado.Text == null)
                {
                    MessageBox.Show("Preencha o campo vázio!!!");
                }
            }
        }

        private void btIgual_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (operador == "+")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('+', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result + valorB;
                    tbCapture.Text = result.ToString();
                    tbDigitado.Clear();
                }

                if (operador == "-")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('-', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result - valorB;
                    tbCapture.Text = result.ToString();
                    tbDigitado.Clear();
                }

                if (operador == "*")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('*', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result * valorB;
                    tbCapture.Text = result.ToString();
                    tbDigitado.Clear();
                }

                if (operador == "/")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('/', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result / valorB;
                    tbCapture.Text = result.ToString();
                    tbDigitado.Clear();
                }

                if (operador == "%")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('%', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = valorB * (result / 100);
                    tbCapture.Text = result.ToString() + $"{operador}";
                    tbDigitado.Clear();
                }
            }
            catch
            {
                if (tbDigitado.Text == null)
                {
                    MessageBox.Show("Preencha o campo vázio!!!");
                }
            }
        }

        private void btMenos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Considerando operador -
                if (operador == "-")
                {
                    if (count == 1)
                    {
                        valorB = Convert.ToDouble(tbDigitado.Text);
                        result = result - valorB;
                        tbCapture.Text = result.ToString() + $"{operador}";
                        tbDigitado.Clear();
                    }

                    if (valorA != 0 && tbDigitado.Text != null && count == 0)
                    {
                        valorB = Convert.ToDouble(tbDigitado.Text);
                        result = valorA - valorB;
                        tbCapture.Text = result.ToString() + $"{operador}";
                        tbDigitado.Clear();
                        count = 1;
                    }
                }

                if (valorA == 0)
                {
                    valorA = Convert.ToDouble(tbDigitado.Text);
                    operador = "-";
                    tbCapture.Text = valorA.ToString() + $"{operador}";
                    tbDigitado.Clear();
                }

                //Considerando outros operadores
                if (operador == "+")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('+', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result + valorB;
                    operador = "-";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }
                
                if (operador == "*")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('*', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result * valorB;
                    operador = "-";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }
                
                if (operador == "/")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('/', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result / valorB;
                    operador = "-";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }

                if (operador == "%")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('%', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = valorB * (result / 100);
                    operador = "-";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }
            }
            catch
            {
                if (tbDigitado.Text == null)
                {
                    MessageBox.Show("Preencha o campo vázio!!!");
                }
            }

        }

        private void btVezes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Considerando operador X
                if (operador == "*")
                {
                    if (count == 1)
                    {
                        valorB = Convert.ToDouble(tbDigitado.Text);
                        result = result * valorB;
                        tbCapture.Text = result.ToString() + $"{operador}";
                        tbDigitado.Clear();
                    }

                    if (valorA != 0 && tbDigitado.Text != null && count == 0)
                    {
                        valorB = Convert.ToDouble(tbDigitado.Text);
                        result = valorA * valorB;
                        tbCapture.Text = result.ToString() + $"{operador}";
                        tbDigitado.Clear();
                        count = 1;
                    }
                }

                if (valorA == 0)
                {
                    valorA = Convert.ToDouble(tbDigitado.Text);
                    operador = "*";
                    tbCapture.Text = valorA.ToString() + $"{operador}";
                    tbDigitado.Clear();
                }

                //Considerando outros operadores
                if (operador == "+")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('+', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result + valorB;
                    operador = "*";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }

                if (operador == "-")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('-', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result - valorB;
                    operador = "*";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }

                if (operador == "%")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('%', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = valorB * (result / 100);
                    operador = "*";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }
            }
            catch 
            {
                if (tbDigitado.Text == null)
                {
                    MessageBox.Show("Preencha o campo vázio!!!");
                }
            }
        }

        private void btLimparTudo_Click(object sender, RoutedEventArgs e)
        {
            valorA = 0;
            valorB = 0;
            result = 0;
            count = 0;
            operador = "";
            tbDigitado.Clear();
            tbCapture.Clear();
        }

        private void btLimpar_Click(object sender, RoutedEventArgs e)
        {
            if(tbDigitado.Text.Length > 0)
            {
                tbDigitado.Text = tbDigitado.Text.Substring(0, tbDigitado.Text.Length - 1);
            }
        }

        private void btDivisao_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Considerando operador X
                if (operador == "/")
                {
                    if (count == 1)
                    {
                        valorB = Convert.ToDouble(tbDigitado.Text);
                        result = result / valorB;
                        tbCapture.Text = result.ToString() + $"{operador}";
                        tbDigitado.Clear();
                    }

                    if (valorA != 0 && tbDigitado.Text != null && count == 0)
                    {
                        valorB = Convert.ToDouble(tbDigitado.Text);
                        result = valorA / valorB;
                        tbCapture.Text = result.ToString() + $"{operador}";
                        tbDigitado.Clear();
                        count = 1;
                    }
                }

                if (valorA == 0)
                {
                    valorA = Convert.ToDouble(tbDigitado.Text);
                    operador = "/";
                    tbCapture.Text = valorA.ToString() + $"{operador}";
                    tbDigitado.Clear();
                }

                //Considerando outros operadores
                if (operador == "+")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('+', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result + valorB;
                    operador = "/";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }

                if (operador == "-")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('-', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result - valorB;
                    operador = "/";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }

                if (operador == "*")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('*', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result * valorB;
                    operador = "/";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }
                
                if (operador == "%")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('%', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = valorB * (result / 100);
                    operador = "/";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }
            }
            catch
            {
                if (tbDigitado.Text == null)
                {
                    MessageBox.Show("Preencha o campo vázio!!!");
                }
            }
        }

        private void btPorcentagem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Considerando operador X
                if (operador == "%")
                {
                    if (count == 1)
                    {
                        valorB = Convert.ToDouble(tbDigitado.Text);
                        result = valorB * (result / 100);
                        tbCapture.Text = result.ToString() + $"{operador}";
                        tbDigitado.Clear();
                    }

                    if (valorA != 0 && tbDigitado.Text != null && count == 0)
                    {
                        valorB = Convert.ToDouble(tbDigitado.Text);
                        result = valorB * (valorA / 100);
                        tbCapture.Text = result.ToString() + $"{operador}";
                        tbDigitado.Clear();
                        count = 1;
                    }
                }

                if (valorA == 0)
                {
                    valorA = Convert.ToDouble(tbDigitado.Text);
                    operador = "%";
                    tbCapture.Text = valorA.ToString() + $"{operador}";
                    tbDigitado.Clear();
                }

                //Considerando outros operadores
                if (operador == "+")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('+', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result + valorB;
                    operador = "%";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }

                if (operador == "-")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('-', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result - valorB;
                    operador = "%";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }

                if (operador == "*")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('*', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result * valorB;
                    operador = "%";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }
                
                if (operador == "/")
                {
                    result = Convert.ToDouble(tbCapture.Text.Replace('/', ' '));
                    valorB = Convert.ToDouble(tbDigitado.Text);
                    result = result / valorB;
                    operador = "%";
                    tbCapture.Text = result.ToString() + $"{operador}";
                    count = 1;
                    tbDigitado.Clear();
                }
            }
            catch
            {
                if (tbDigitado.Text == null)
                {
                    MessageBox.Show("Preencha o campo vázio!!!");
                }
            }
        }

        private void tbDigitado_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
