using System;
using System.Windows.Forms;

//https://www.youtube.com/watch?v=Is1EHXFhEe4

namespace Calculator
{
    public partial class Calculator : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")|(operation_pressed))
                result.Clear();
                operation_pressed = false;

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
            //bug - result not resetting to 0
            //idea - +/- button to do minus the value of result
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            equation.Text = "";
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }//end switch
        }

        private void equation_Click(object sender, EventArgs e)
        {

        }
    }
}
