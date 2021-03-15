using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {
        bool b = false;
        string operand = "";
        double result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ClickOnNumbers(object sender, MouseEventArgs e)
        {
            if (resultRtxtb.Text == "0" || b) resultRtxtb.Clear();
            Button button = (Button)sender;
            resultRtxtb.Text += button.Text;
            resultLabel.Text += button.Text;
            b = false;
        }

        private void Operations(object sender, MouseEventArgs e)
        {
            b = true;
            Button button = (Button)sender;
            string newOperand = button.Text;
            resultLabel.Text = resultLabel.Text + " " + newOperand + " ";
            switch (operand)
            {
                case "+":
                    resultRtxtb.Text = (result + Double.Parse(resultRtxtb.Text)).ToString();
                    break;
                case "-":
                    resultRtxtb.Text = (result - Double.Parse(resultRtxtb.Text)).ToString();
                    break;
                case "*":
                    resultRtxtb.Text = (result * Double.Parse(resultRtxtb.Text)).ToString();
                    break;
                case "/":
                    resultRtxtb.Text = (result / Double.Parse(resultRtxtb.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(resultRtxtb.Text);
            operand = newOperand;
        }

        private void ClearAll(object sender, MouseEventArgs e)
        {
            resultRtxtb.Clear();
            resultLabel.Text = "";
            result = 0;
            operand = "";
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            b = true;
            switch (operand)
            {
                case "+":
                    resultRtxtb.Text = (result + Double.Parse(resultRtxtb.Text)).ToString();
                    break;
                case "-":
                    resultRtxtb.Text = (result - Double.Parse(resultRtxtb.Text)).ToString();
                    break;
                case "*":
                    resultRtxtb.Text = (result * Double.Parse(resultRtxtb.Text)).ToString();
                    break;
                case "/":
                    resultRtxtb.Text = (result / Double.Parse(resultRtxtb.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(resultRtxtb.Text);
            resultRtxtb.Text = result.ToString();
            result = 0;
            operand = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
