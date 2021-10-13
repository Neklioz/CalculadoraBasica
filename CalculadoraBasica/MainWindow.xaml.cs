using System;
using System.Collections.Generic;
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

namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcularButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int operando1 = int.Parse(Operando1TextBox.Text);
                int operando2 = int.Parse(Operando2TextBox.Text);
                String operador = OperadorTextBox.Text;

                Calcular(operando1, operador, operando2);
            }
            catch
            {
                MessageBox.Show("Se ha producido un error. Revise los operandos.");
            }
            
        }

        void Calcular(int operando1, String operador, int operando2)
        {
            int resultado = 0;

            if (operador == "+")
            {
                resultado = operando1 + operando2;
            }
            else if (operador == "-")
            {
                resultado = operando1 - operando2;
            }
            else if (operador == "*")
            {
                resultado = operando1 * operando2;
            }
            else
            {
                 resultado = operando1 / operando2;
            }

            ResultadoTextBox.Text = resultado.ToString();
        }

        private void LimpiarButtonClick(object sender, RoutedEventArgs e)
        {
            Operando1TextBox.Text = "";
            Operando2TextBox.Text = "";
            OperadorTextBox.Text = "";
            ResultadoTextBox.Text = "";
        }

        private void OperadorTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            String operador = OperadorTextBox.Text;
            if(operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                CalcularButton.IsEnabled = true;
            }
            else
            {
                CalcularButton.IsEnabled = false;
            }
        }
    }
}
