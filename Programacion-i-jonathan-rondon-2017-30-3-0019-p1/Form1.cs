using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_i_jonathan_rondon_2017_30_3_0019_p1
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            //declarar variables
            double num1, num2, sum, rest, mult, div, pot, rai;
            //entrada de datos
            num1 = double.Parse(txtvalor1.Text);
            num2 = Convert.ToDouble(txtvalor2.Text);
            //proceso
            sum = num1 + num2;
            rest = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;
            pot = Math.Pow(num1, num2);
            rai = Math.Pow(num1, (1/num2));
            //salida de info
            txtsum.Text = Convert.ToString(sum);
            txtrest.Text = Convert.ToString(rest);
            txtdiv.Text = Convert.ToString(rest);
            txtmult.Text = Convert.ToString(mult);
            txtpot.Text = Convert.ToString(pot);
            txtrai.Text = Convert.ToString(rai);
            
        }

        private void btncln_Click(object sender, EventArgs e)
        {
            txtvalor1.Clear();
            txtvalor2.Clear();
            txtsum.Clear();
            txtrest.Clear();
            txtmult.Clear();
            txtdiv.Clear();
            txtpot.Clear();
            txtrai.Clear();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            txtresultado.Text = Convert.ToString("1");
        }
    }
}
