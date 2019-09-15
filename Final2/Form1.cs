using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double hor = double.Parse(txthoras.Text);
            double val = double.Parse(txtvalor.Text);
            double total;

            total = val * hor;

            if (total < 700000)
            {
                total = (total * 0.10) + total;
                txttotal.Text = total.ToString()  ;
                MessageBox.Show("Incremento del salario del 10%" );
            }

            else
            {
                if (total <= 1000000)
                {
                    total = (total * 0.2) - total;
                    txttotal.Text = total.ToString();
                    MessageBox.Show("Descuento del salario del 2%");
                }
                else
                {

                    if (total >= 1000001)
                    {
                        total = (total / 0.5) * 0.2;
                        txttotal.Text = total.ToString();
                        MessageBox.Show("Descuento del salario del 5% y se le aumentó el 2%");
                    }
                }

                
            }

        }
    }
}