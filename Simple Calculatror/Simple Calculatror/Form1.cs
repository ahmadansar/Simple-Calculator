using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculatror
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text=="")
            {
                MessageBox.Show("Both Numbers Are Mandatory!");
            }
            else
            {
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);
                float sum = num1 + num2;
                label4.Text = "Sum Is : "+sum.ToString();
                label4.Visible = true;
                button7.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both Numbers Are Mandatory!");
            }
            else
            {
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);
                float subtract = num1 - num2;
                label4.Text = "Diffrence Is : " + subtract.ToString();
                label4.Visible = true;
                button7.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both Numbers Are Mandatory!");
            }
            else
            {
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);
                float mul = num1 * num2;
                label4.Text = "Product Is : " + mul.ToString();
                label4.Visible = true;
                button7.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both Numbers Are Mandatory!");
            }
            else
            {
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);
                if (num2 == 0)
                {
                    MessageBox.Show("Cannot Divide by Zero!");
                }
                else
                {
                    float div = num1 / num2;
                    label4.Text = "Division Is : " + div.ToString();
                    label4.Visible = true;
                    button7.Visible = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both Numbers Are Mandatory!");
            }
            else
            {
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);
                if (num2 == 0)
                {
                    MessageBox.Show("Cannot Divide by Zero!");
                }
                else
                {
                    float rem = num1 % num2;
                    label4.Text = "Remainder Is : " + rem.ToString();
                    label4.Visible = true;
                    button7.Visible = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both Numbers Are Mandatory!");
            }
            else
            {
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);
                float exp = 1;
                for (int i = 0; i < num2; i++)
                {
                    exp=exp*num1;
                }
                label4.Text = "Power  Is : " + exp.ToString();
                label4.Visible = true;
                button7.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            button7.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
