using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Calculadora
{
    public partial class Window : Form
    {
        //Conexion
        WebClient client;

        //Defino un grupo de constantes que contendran los valores de los botones, es mas eficiente tener todos agrupados aqui
        private const string zero = "0";
        private const string one = "1";
        private const string two = "2";
        private const string three = "3";
        private const string four = "4";
        private const string five = "5";
        private const string six = "6";
        private const string seven = "7";
        private const string eight = "8";
        private const string nine = "9";
        private const string period = ".";

        //Contendra el valor numerico
        Double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Window()
        {
            InitializeComponent();

            //Se inicializa la conexion
            client = new WebClient();
        }

        private void button_clicked(object sender, EventArgs e)
        {
            //Si hay solamente un cero, se pone en blanco
            if(calcTextBox.Text.Equals("0") || operation_pressed)
            {
                calcTextBox.Clear();
            }
          
            Button button = null;
            try
            {
                //Se hace un safe casting del boton que fue presionado
                button = sender as Button;
            }
            catch(NullReferenceException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            //Dependiendo de cual button se presiono se realizara una accion
            if (button.Text.Equals(zero))
            {
                calcTextBox.Text += zero;
            }
            else if(button.Text.Equals(one))
            {
                calcTextBox.Text += one;
            }
            else if (button.Text.Equals(two))
            {
                calcTextBox.Text += two;
            }
            else if (button.Text.Equals(three))
            {
                calcTextBox.Text += three;
            }
            else if (button.Text.Equals(four))
            {
                calcTextBox.Text += four;
            }
            else if (button.Text.Equals(five))
            {
                calcTextBox.Text += five;
            }
            else if (button.Text.Equals(six))
            {
                calcTextBox.Text += six;
            }
            else if (button.Text.Equals(seven))
            {
                calcTextBox.Text += seven;
            }
            else if (button.Text.Equals(eight))
            {
                calcTextBox.Text += eight;
            }
            else if (button.Text.Equals(nine))
            {
                calcTextBox.Text += nine;
            }
            else if (button.Text.Equals(period))
            {
                //Se verifica que no halla un punto en el campo
                if (!calcTextBox.Text.Contains(period))
                    calcTextBox.Text += period;
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            calcTextBox.Text = "0";
        }

        private void operator_clicked(object sender, MouseEventArgs e)
        {
            Button operatorButton = sender as Button;         
            operation = operatorButton.Text;
            value = double.Parse(calcTextBox.Text);
            if (!(operation.Equals("√") || operation.Equals("1/x")))
                operation_pressed = true;

            if (operation.Equals("√"))
                operationInProgress.Text = operation + value;
            else if (operation.Equals("1/x"))
                operationInProgress.Text = String.Format("1/{0}",value);
            else
                operationInProgress.Text = value + " " + operation;

            //Se muestra el label
            operationInProgress.Visible = true;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            //Limpia la operacion en progreso
            operationInProgress.Text = "";
            operationInProgress.Visible = false;

            double segundoMiembro = double.Parse(calcTextBox.Text);
            try
            {
            
            switch (operation)
            {
                case "+":
                    calcTextBox.Text =  (value + Double.Parse(calcTextBox.Text)).ToString();
                    //Se envia la operacion
                    SendResult(operation, value, segundoMiembro, double.Parse(calcTextBox.Text));
                    break;
                case "-":
                    calcTextBox.Text = (value - Double.Parse(calcTextBox.Text)).ToString();
                    //Se envia la operacion
                    SendResult(operation, value, segundoMiembro, double.Parse(calcTextBox.Text));
                    break;
                case "/":
                    calcTextBox.Text = (value / Double.Parse(calcTextBox.Text)).ToString();
                    //Se envia la operacion
                    SendResult(operation, value, segundoMiembro, double.Parse(calcTextBox.Text));
                    break;
                case "%":
                    calcTextBox.Text = (value % Double.Parse(calcTextBox.Text)).ToString();
                    //Se envia la operacion
                    SendResult(operation, value, segundoMiembro, double.Parse(calcTextBox.Text));
                    break;
                case "*":
                    calcTextBox.Text = (value * Double.Parse(calcTextBox.Text)).ToString();
                    //Se envia la operacion
                    SendResult(operation, value, segundoMiembro, double.Parse(calcTextBox.Text));
                    break;
                case "√":
                    calcTextBox.Text = Math.Sqrt(Double.Parse(calcTextBox.Text)).ToString();
                    //Se envia la operacion
                    SendResult(operation, value, double.Parse(calcTextBox.Text));
                    break;
                case "1/x":
                    calcTextBox.Text = (1 / double.Parse(calcTextBox.Text)).ToString();
                    //Se envia la operacion
                    SendResult(operation, value, double.Parse(calcTextBox.Text));
                    break;
                default:
                    break;
            }//!

            }
            catch (WebException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

            //La operacion ya fue efectuada se vuelve a la normalidad
            operation_pressed = false;
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            calcTextBox.Text = "0";
            value = 0;
        }

        private void changeSignButton_Click(object sender, EventArgs e)
        {
            double  value = double.Parse(calcTextBox.Text);
            //Se convierte a negativo y vice versa. (Matematica Basica)
            calcTextBox.Text = (value - value * 2).ToString(); 
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            int len = calcTextBox.Text.Length;
            //Se comprueba que halla que borrar
            if (!(len == 0 || calcTextBox.Text.Equals("0")))
                calcTextBox.Text = calcTextBox.Text.Substring(0, len - 1);  //borra
            else
                calcTextBox.Text = "0";
        }

        public void SendResult(string operacion,double primero, double segundo, double resultado)
        {
            //Envia la operacion a Amadis
            client.DownloadString(string.Format("http://adamix.net/practica/?m=sof-001&t=10&e=20131488&op={0} {1} {2} = {3}",primero, operacion, segundo, resultado));
        }

        public void SendResult(string operacion,double value, double resultado)
        {
            if (operation.Equals("√"))
                client.DownloadString(string.Format("http://adamix.net/practica/?m=sof-001&t=10&e=20131488&op={0}{1} = {2} Nota: Su pagina no esta en UTF-8 por lo tanto no reconoce el signo de Raiz Cuadrada", operacion, value, resultado));
            else
                client.DownloadString(string.Format("http://adamix.net/practica/?m=sof-001&t=10&e=20131488&op= 1/{0} = {1}", value, resultado));
        }

        
    }
}
