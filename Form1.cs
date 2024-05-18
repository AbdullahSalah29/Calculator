using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form1 : Form
    {
        Double resultValue = 0,resultValue2=0;
        String op = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {

            if (isOperationPerformed || guna2TextBox2.Text == "0")
            { 
                isOperationPerformed = false;
                op = "";
                if (guna2TextBox2.Text == "0")
                { resultValue2 = Double.Parse(guna2TextBox2.Text); }
                guna2TextBox2.Clear();
                guna2TextBox1.Text = " ";
            }
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            
            if (button.Text == ".")
            {
                if (!guna2TextBox2.Text.Contains("."))
                    guna2TextBox2.Text +=  button.Text;
                else
                    return;
            }
            else
                guna2TextBox2.Text +=  button.Text;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            op = button.Text;
            resultValue = Double.Parse(guna2TextBox2.Text);
            guna2TextBox1.Text = resultValue.ToString() + " " + op + " ";
            guna2TextBox2.Text = "";
            //isOperationPerformed = true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            guna2TextBox2.Text = " ";
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Text = "0";
            guna2TextBox1.Text = " ";
            resultValue2 = 0;
            isOperationPerformed = false;
            resultValue = 0;
            op = "";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           isOperationPerformed = true;

            guna2TextBox1.Text += guna2TextBox2.Text+" = ";
            if(op=="+")
            {
                if (guna2TextBox1.Text != "")
                    guna2TextBox2.Text = (resultValue + Double.Parse(guna2TextBox2.Text)).ToString();
            }
            if (op == "-")
            {
                if(guna2TextBox1.Text!="")
                guna2TextBox2.Text = (resultValue - Double.Parse(guna2TextBox2.Text)).ToString();
                else
                    guna2TextBox2.Text = (resultValue - resultValue2).ToString();


            }
            if (op == "X")
            {
                if (guna2TextBox1.Text != "")
                    guna2TextBox2.Text = (resultValue * Double.Parse(guna2TextBox2.Text)).ToString();
                else
                    guna2TextBox2.Text = (resultValue * resultValue2).ToString();

            }
            if (op == "/")
            {
                if (guna2TextBox1.Text != "")
                    guna2TextBox2.Text = (resultValue / Double.Parse(guna2TextBox2.Text)).ToString();
                else
                    guna2TextBox2.Text = (resultValue / resultValue2).ToString();

            }
            if (op == "mod")
            {
                if (guna2TextBox1.Text != "")
                    guna2TextBox2.Text = (resultValue % Double.Parse(guna2TextBox2.Text)).ToString();
                else
                    guna2TextBox2.Text = (resultValue % resultValue2).ToString();

            }
            if (op == "tan")
            {
                guna2TextBox2.Text = (Math.Tan(resultValue*Math.PI/180)).ToString();
            }
            if (op == "sin")
            {
                guna2TextBox2.Text = (Math.Sin(resultValue * Math.PI / 180)).ToString();
            }
            if (op == "cos")
            {
                guna2TextBox2.Text = (Math.Cos(resultValue * Math.PI / 180)).ToString();
            }
            if (op == "x^y")
            {
                if (guna2TextBox1.Text != "")
                    guna2TextBox2.Text = (Math.Pow(resultValue,Double.Parse(guna2TextBox2.Text))).ToString();
                else
                    guna2TextBox2.Text = (Math.Pow(resultValue, resultValue2)).ToString();

            }
            if (op == "10^x")
            {
                guna2TextBox2.Text = (Math.Pow(10, resultValue)).ToString();

            }
            if (op == "ln")
            {
                guna2TextBox2.Text = (Math.Log(resultValue)).ToString();

            }
            if (op == "log")
            {
                guna2TextBox2.Text = (Math.Log10(resultValue)).ToString();

            }
            if (op == "+/-")
            {
                
                guna2TextBox2.Text = (-1*resultValue).ToString();

            }
            if (op == "sqrt")
            {
                guna2TextBox2.Text = (Math.Sqrt( resultValue)).ToString();

            }
            if (op == "x^2")
            {
                guna2TextBox2.Text = (Math.Pow(resultValue,2)).ToString();

            }
            if (op == "pi")
            {
                guna2TextBox2.Text = (Math.PI).ToString();

            }
            if (op == "e")
            {
                guna2TextBox2.Text = (Math.E).ToString();

            }
            if (op == "1/x")
            {
                guna2TextBox2.Text = (Math.Pow(resultValue,.5)).ToString();

            }
            if (op == "|x|")
            {
                guna2TextBox2.Text = (Math.Abs( resultValue)).ToString();

            }
            if (op == "exp")
            {
                if (guna2TextBox1.Text != "")
                    guna2TextBox2.Text = (resultValue.ToString()+".+e"+guna2TextBox2.Text);
                else
                    guna2TextBox2.Text = (resultValue.ToString() + ".+e" + resultValue2);



            }
            if (op == "n!")
            {
                var result = 1;
                for(var i=1;i<=resultValue;i++)
                {
                    if (resultValue == 1)
                    {
                        result = 1;
                        break;

                    }result *= i;
                }


                guna2TextBox2.Text =  (result).ToString();

            }





        }
    }
}
