using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float a= float.Parse(textBox1.Text);
            float b= float.Parse(textBox2.Text);
            
            switch(comboBox1.Text)
            {
                case "+":
                    label3.Text = BasicComputation.Add(a,b).ToString();
                    break;
                case "-":
                    label3.Text = BasicComputation.Sub(a, b).ToString();
                    break;
                case "*":
                    label3.Text = BasicComputation.Mul(a, b).ToString();
                    break;
                case "/":
                    label3.Text = BasicComputation.Divi(a, b).ToString();
                    break;
            }
        }
    }
}
