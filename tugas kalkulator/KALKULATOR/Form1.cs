using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaAllahMugoSaget
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String Operation = "";
        bool isoperation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tekan(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")||(isoperation))
                textBox1.Clear();

            isoperation = false;
            Button button = (Button)sender;
            if(button.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + button.Text;
            }
                else
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void operasi(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button17.PerformClick();
                Operation = button.Text;
                isoperation = true;
            }
            else
            {

                Operation = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                isoperation = true;

            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch (Operation)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
