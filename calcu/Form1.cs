using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcu
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += Timer1_Tick;
            botresposta();
        }

        void atvop(string Op)
        {
            sinal.Text = Op;
            igual.Enabled = true;   
        }
        void botresposta()
        {
            usarresp.Enabled = !(result.Text == "");
        }
        void travasemsinal()
        {
            igual.Enabled = !(sinal.Text == "..." || (sinal.Text == div.Text && num2.Value == 0));
        }

        private void mais_Click(object sender, EventArgs e)
        {
            atvop(mais.Text);   
        }

        private void menos_Click(object sender, EventArgs e)
        {
           atvop(menos.Text);   
        }

        private void mult_Click(object sender, EventArgs e)
        {
            atvop(mult.Text);
        }

        private void div_Click(object sender, EventArgs e)
        {
            atvop(div.Text);
            travasemsinal();
        }

        private void igual_Click(object sender, EventArgs e)
        {
            double n1, n2, resul = 0;
            n1 = (double)num1.Value;
            n2 = (double)num2.Value;
            if (sinal.Text == mais.Text)
                resul = n1 + n2;
            else if (sinal.Text == menos.Text)
                resul = n1 - n2;
            else if (sinal.Text == mult.Text)
                resul = n1 * n2;
            else if (sinal.Text == div.Text)
                resul = n1 / n2;
            result.Text = resul.ToString();
            botresposta();
        }

        private void num2_ValueChanged(object sender, EventArgs e)
        {
            travasemsinal();
            if (num2.Value == 69 || num1.Value == 69 || result.Text == "69")
            {
                wow.Visible = true;
                timer1.Interval = 3400;
                timer1.Start();
            }
            
        }

        private void num1_ValueChanged(object sender, EventArgs e)
        {
            if (num2.Value == 69 || num1.Value == 69 || result.Text == "69")
            {
                wow.Visible = true;
                timer1.Interval = 3400;
                timer1.Start();
            }
        }

        private void result_TextChanged(object sender, EventArgs e)
        {
            if (num2.Value == 69 || num1.Value == 69 || result.Text == "69")
            {
                wow.Visible = true;
                timer1.Interval = 3400;
                timer1.Start();
            }
        }

        private void num1_ValueChanged_1(object sender, EventArgs e)
        {
            if (num2.Value == 69 || num1.Value == 69 || result.Text == "69")
            {
                wow.Visible = true; 
                timer1.Interval = 3400; 
                timer1.Start();
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            wow.Visible = false;
            timer1.Stop(); 
        }

        private void usarresp_Click(object sender, EventArgs e)
        {
            double d = Double.Parse(result.Text);
            num1.Value = (decimal)d;
            result.Text = "";
            System.Threading.Thread.Sleep(3400);
            botresposta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1.Value = 0;
            num2.Value = 0;
            result.Text = "";
            sinal.Text = "...";
            System.Threading.Thread.Sleep(2000);
            botresposta();
            travasemsinal();
        }
    }
}
