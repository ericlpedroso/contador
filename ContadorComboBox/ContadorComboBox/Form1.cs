using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadorComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void cbValor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num1 = int.Parse(cbValor1.Text);
            int num2 = int.Parse(cbValor2.Text);

            if (num2 == 0)
            {
                txtResultado.Text = num1 + " ";
            }
            else
            {

                if (num1 < num2)
                {

                    txtResultado.Text = " ";
                    txtResultado.Text = num1 + " ";

                    while (num1 < num2)
                    {

                        num1++;
                        txtResultado.Text += num1 + " ";

                    }

                }
                else
                {

                    txtResultado.Text = " ";
                    txtResultado.Text = num1 + " ";

                    while (num1 > num2)
                    {
                        num1--;
                        txtResultado.Text += num1 + " ";

                    }
                }
            }
        }

        
        private void cbValor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num1 = int.Parse(cbValor1.Text);
            int num2 = int.Parse(cbValor2.Text);


            if (num1 < num2)
            {

                txtResultado.Text = " ";
                txtResultado.Text = num1 + " ";

                while (num1 < num2) {
                    
                    num1++;
                    txtResultado.Text += num1 + " ";
                    
                }

            }else
            {

                txtResultado.Text = " ";
                txtResultado.Text = num1 + " ";

                while (num1 > num2)
                {
                    num1--;
                    txtResultado.Text += num1 + " ";

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbValor1.Text = "0";
            cbValor2.Text = "0";
        }
    }
}
