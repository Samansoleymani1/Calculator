using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        ICalculate calulator;
        public Form1()
        {
            InitializeComponent();
            calulator = new Calculate();   
        }
        bool Validateinputs()
        {
            bool Isvalid = true;

            if (meric1.Value == 0)
            {
                Isvalid = false;
                MessageBox.Show("Please Enter Number 1");
            }

            if (meric2.Value == 0)
            {
                Isvalid = false;
                MessageBox.Show("Please Enter Number 2");
            }

            return Isvalid;
        }



        private void plus_Click(object sender, EventArgs e)
        {
            if (Validateinputs())
            {
                int sum = calulator.plus((int)meric1.Value, (int)meric2.Value);
                MessageBox.Show("Sum is : " + sum);
            }

        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (Validateinputs())
            {
                int minus = calulator.minus((int)meric1.Value, (int)meric2.Value);
                MessageBox.Show("Minus is : " + minus);
            }
        }

        private void mulitple_Click(object sender, EventArgs e)
        {
            if (Validateinputs())
            {
                int mulitple = calulator.multiple((int)meric1.Value, (int)meric2.Value);
                MessageBox.Show("Mulitple is : " + mulitple);
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            if(Validateinputs())
            {
                int div = calulator.div((int)meric1.Value, (int)meric2.Value);
                MessageBox.Show("Div is : " + div);
            }
        }
    }
}
