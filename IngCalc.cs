using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class IngCalc : SimpleCalculator.CalcUI
    {
        public IngCalc()
        {
            InitializeComponent();
            ClassicTool.Enabled = true;
            IngeneerTool.Enabled = false;
            outputDisplay2.Text = "0";
        }

        private void keyDegree_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDegree);
        }

        private void keySQRT_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSQRT);
            OutputDisplay.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcReset();
        }

        private void keyReverse_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDivByOne);
            OutputDisplay.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcReset();
        }

        private void keyDegree2_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDegree2);
            OutputDisplay.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcReset();
        }

        private async void keyFactorial_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eFactorial);
            outputDisplay2.Text = await Subb();
            CalcEngine.CalcReset();
        }

        private void keyCBRT_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eCBRT);
            OutputDisplay.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcReset();
        }

        private void IngCalc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void keyQE_Click(object sender, EventArgs e)
        {
            formQE formQE = new formQE();
            formQE.Show(this);
        }

        private async static Task <string> Subb()
        {
            return await Task.Run(() =>
            {
                string s = CalcEngine.CalcEqual();
                CalcEngine.CalcReset();
                
                Thread.Sleep(10000);
                return s ;
            }
            );
        }

        private void KeyClear_Click_1(object sender, EventArgs e)
        {
            CalcEngine.CalcReset();
            OutputDisplay.Text = "0";
            outputDisplay2.Text = "0";
        }
    }
}
