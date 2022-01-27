using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Calculator
{
    public partial class CSCALC : Form
    {
        public CSCALC()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tbCalc.Text == "0")
            {

                tbCalc.Clear();

            }

            tbCalc.Text = tbCalc.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (tbCalc.Text == "0")
            {

                tbCalc.Clear();

            }

            tbCalc.Text = tbCalc.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (tbCalc.Text == "0")
            {

                tbCalc.Clear();

            }

            tbCalc.Text = tbCalc.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (tbCalc.Text == "0")
            {

                tbCalc.Clear();

            }

            tbCalc.Text = tbCalc.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (tbCalc.Text == "0")
            {

                tbCalc.Clear();

            }

            tbCalc.Text = tbCalc.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (tbCalc.Text == "0")
            {

                tbCalc.Clear();

            }

            tbCalc.Text = tbCalc.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (tbCalc.Text == "0")
            {

                tbCalc.Clear();

            }

            tbCalc.Text = tbCalc.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (tbCalc.Text == "0")
            {

                tbCalc.Clear();

            }

            tbCalc.Text = tbCalc.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (tbCalc.Text == "0")
            {

                tbCalc.Clear();

            }

            tbCalc.Text = tbCalc.Text + "9";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbCalc.Clear();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (tbCalc.Text == "0")
            {

                tbCalc.Clear();

            }

            tbCalc.Text = tbCalc.Text + "0";
        }

        string operationPerformed = "";
        double resultValue = 0;
        bool isOperationPerformed = false;

        private void btnEquals_Click(object sender, EventArgs e)
        {


            switch (operationPerformed)
            {

                case "+":
                    tbCalc.Text = (resultValue + Double.Parse(tbCalc.Text)).ToString();
                    break;
                case "-":
                    tbCalc.Text = (resultValue - Double.Parse(tbCalc.Text)).ToString();
                    break;
                case "*":
                    tbCalc.Text = (resultValue * Double.Parse(tbCalc.Text)).ToString();
                    break;
                case "/":
                    tbCalc.Text = (resultValue / Double.Parse(tbCalc.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(tbCalc.Text);

        }

        private void btnSlash_Click(object sender, EventArgs e)
        {

        }

        private void btnTimes_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (tbCalc.Text.Length == 0)
            {

                if (!tbCalc.Text.Contains("."))
                {

                    tbCalc.Text = tbCalc.Text + ".";

                }

            }
        }
    }
}
