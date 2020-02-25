using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class formQE : Form
    {
        public formQE()
        {
            InitializeComponent();
            
        }
        protected string a
        {
            get { return textBoxA.Text; }
            set { textBoxA.Text = value; }
        }

        protected string b
        {
            get { return textBoxB.Text; }
            set { textBoxB.Text = value; }
        }

        protected string c
        {
            get { return textBoxC.Text; }
            set { textBoxC.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1;
            double x2;

            try
            {
                double a1 = double.Parse(a);
                double b1 = double.Parse(b);
                double c1 = double.Parse(c);
                if (Ur.Deskr(a1, b1, c1) >= 0)
                {
                    Ur.Gg(a1, b1, c1, out x1, out x2);
                    richTextBox1.Text = $"{a}*x^2 + {b}*x + {c} = 0\n" + $"Корни уравнения: \nx1 = {x1}\nx2 = {x2} ";
                }
                else richTextBox1.Text = "Корней нет";
                richTextBox1.Refresh();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");

            }
           
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!char.IsDigit(e.KeyChar)&&num!=46)
            {
                e.Handled = true;
                MessageBox.Show("Введите число или точку ");
            }
        }

        

        private void textBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && num != 46)
            {
                e.Handled = true;
                MessageBox.Show("Введите число или точку ");
            }
        }

        private void textBoxC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && num != 46)
            {
                e.Handled = true;
                MessageBox.Show("Введите число или точку");
            }
        }
    }
}
