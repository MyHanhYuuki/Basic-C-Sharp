using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        string firstNum;
        string secondNum;
        string Calculation;
        int flag = 0;
        public Form1()
        {
            InitializeComponent();
            firstNum = "";
            secondNum = "";
            Calculation = "";
            txbKQ.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            firstNum = "";
            secondNum = "";
            Calculation = "";
            txbKQ.Text = "0";
            flag = 0;
        }

        private void txbKQ_Changed()
        {
            if (Calculation == "")
                txbKQ.Text = firstNum;
            else
                txbKQ.Text = secondNum;

        }
        private void btnce_Click(object sender, EventArgs e)
        {
            if (Calculation == "")
                txbKQ.Text = "";
            else
                txbKQ.Text = "";
            txbKQ_Changed();
        }

        private void btnBacksp_Click(object sender, EventArgs e)
        {
            if (Calculation == "" && firstNum.Length > 0)
            {
                firstNum = firstNum.Substring(0, firstNum.Length - 1);
            }
            else if (Calculation != "" && secondNum.Length > 0)
            {
                secondNum = secondNum.Substring(0, secondNum.Length - 1);
            }
            txbKQ_Changed();
        }
        private void Calculation_Input(string calculation)
        {
            if (flag == 1)
            {
                Calculate();
            }
            if (firstNum != "")
            {
                Calculation = calculation;
                flag = 1;
            }
            txbKQ_Changed();
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            Calculation_Input(btncong.Text);
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            Calculation_Input(btntru.Text);
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            Calculation_Input(btnnhan.Text);
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            Calculation_Input(btnchia.Text);
        }

        private void btnpt_Click(object sender, EventArgs e)
        {
            if (txbKQ.Text != "Invalid input" && txbKQ.Text != "Can't divide by zero")
            {
                if (Calculation != "")
                {
                    if (secondNum == "")
                        secondNum = (Convert.ToDouble(firstNum) / 100 * Convert.ToDouble(firstNum)).ToString();
                    else
                        secondNum = (Convert.ToDouble(secondNum) / 100 * Convert.ToDouble(firstNum)).ToString();
                }
                else
                {
                    if (firstNum == "")
                        firstNum = (Convert.ToDouble(txbKQ.Text) / 100 * Convert.ToDouble(txbKQ.Text)).ToString();
                    else
                        firstNum = (Convert.ToDouble(firstNum) / 100 * Convert.ToDouble(firstNum)).ToString();

                }
            }
            else
                return;
            txbKQ_Changed();
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            if (txbKQ.Text != "Invalid input" && txbKQ.Text != "Can't divide by zero")
            {
                if (Calculation != "")
                {
                    if (secondNum == "")
                        secondNum = (Math.Sqrt(Convert.ToDouble(firstNum))).ToString();
                    else
                    {
                        if (Convert.ToDouble(secondNum) >= 0)
                            secondNum = (Math.Sqrt(Convert.ToDouble(secondNum))).ToString();
                        else
                        {
                            txbKQ.Text = "Invalid input";
                            firstNum = "";
                            secondNum = "";
                            Calculation = "";
                            return;
                        }
                    }

                }
                else
                {
                    if (firstNum == "")
                        firstNum = (Math.Sqrt(Convert.ToDouble(txbKQ.Text))).ToString();
                    else
                    {
                        if (Convert.ToDouble(firstNum) >= 0)
                            firstNum = (Math.Sqrt(Convert.ToDouble(firstNum))).ToString();
                        else
                        {
                            txbKQ.Text = "Invalid input";
                            firstNum = "";
                            secondNum = "";
                            Calculation = "";
                            return;
                        }
                    }
                }
            }
            else
                return;
            txbKQ_Changed();
        }

        private void btmotpx_Click(object sender, EventArgs e)
        {
            if (txbKQ.Text != "Invalid input" && txbKQ.Text != "Cannot divide by zero")
            {
                if (Calculation != "")
                {
                    if (secondNum == "")
                    {
                        if (Convert.ToDouble(firstNum) != 0)
                            secondNum = (1.0 / Convert.ToDouble(firstNum)).ToString();
                        else
                        {
                            txbKQ.Text = "Cannot divide by zero";
                            firstNum = "";
                            secondNum = "";
                            Calculation = "";
                            return;
                        }
                    }
                    else
                    {
                        if (Convert.ToDouble(secondNum) != 0)
                            secondNum = (1.0 / Convert.ToDouble(secondNum)).ToString();
                        else
                        {
                            txbKQ.Text = "Cannot divide by zero";
                            firstNum = "";
                            secondNum = "";
                            Calculation = "";
                            return;
                        }
                    }

                }
                else
                {
                    if (firstNum == "")
                        firstNum = (Math.Sqrt(Convert.ToDouble(txbKQ.Text))).ToString();
                    else
                    {
                        if (Convert.ToDouble(firstNum) >= 0)
                            firstNum = (Math.Sqrt(Convert.ToDouble(firstNum))).ToString();
                        else
                        {
                            txbKQ.Text = "Invalid input";
                            firstNum = "";
                            secondNum = "";
                            Calculation = "";
                            return;
                        }
                    }
                }
            }
            else
                return;
            txbKQ_Changed();
        }
        private void Calculate()
        {
            if (secondNum != "")
            {
                double n1 = Convert.ToDouble(firstNum);
                double n2 = Convert.ToDouble(secondNum);
                switch (Calculation)
                {
                    case "+":
                        txbKQ.Text = (n1 + n2).ToString();
                        break;
                    case "-":
                        txbKQ.Text = (n1 - n2).ToString();
                        break;
                    case "*":
                        txbKQ.Text = (n1 * n2).ToString();
                        break;
                    case "/":
                        if (n2 == 0)
                        {
                            txbKQ.Text = "Cannot divide by zero";
                            Calculation = "";
                            firstNum = "";
                            secondNum = "";
                            return;
                        }
                        txbKQ.Text = (n1 / n2).ToString();
                        break;
                }
                Calculation = "";
                secondNum = "";
                firstNum = txbKQ.Text;
                txbKQ_Changed();
            }
        }

        private void btncham_Click(object sender, EventArgs e)
        {
            if (Calculation != "")
                secondNum += (secondNum != "" && !secondNum.Contains(".")) ? "." : "";
            else
                firstNum += (firstNum != "" && !firstNum.Contains(".")) ? "." : "";
        }

        private void btncst_Click(object sender, EventArgs e)
        {

            if (Calculation != "")
            {
                if (secondNum == "")
                    secondNum = firstNum[0] == '-' ? firstNum.Substring(1) : "-" + firstNum;
                else
                    secondNum = secondNum[0] == '-' ? secondNum.Substring(1) : "-" + secondNum;
            }
            else
            {
                if (firstNum != "")
                    firstNum = firstNum[0] == '-' ? firstNum.Substring(1) : "-" + firstNum;
            }
            txbKQ_Changed();
        }
        private void Num(string number)
        {
            if (flag == 0)
                firstNum += number;
            else
                secondNum += number;
            txbKQ_Changed();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Num(btn0.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Num(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Num(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Num(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Num(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Num(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Num(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Num(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Num(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Num(btn9.Text);
        }

        private void btnbang_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
