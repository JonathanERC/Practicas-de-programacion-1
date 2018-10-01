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
        double num1, num2, result;
        string op;
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
            ////declarar variables
            //double num1, num2, sum, rest, mult, div, pot, rai;
            ////entrada de datos
            //num1 = double.Parse(txtvalor1.Text);
            //num2 = Convert.ToDouble(txtvalor2.Text);
            ////proceso
            //sum = num1 + num2;
            //rest = num1 - num2;
            //mult = num1 * num2;
            //div = num1 / num2;
            //pot = Math.Pow(num1, num2);
            //rai = Math.Pow(num1, (1/num2));
            ////salida de info
            //txtsum.Text = Convert.ToString(sum);
            //txtrest.Text = Convert.ToString(rest);
            //txtdiv.Text = Convert.ToString(rest);
            //txtmult.Text = Convert.ToString(mult);
            //txtpot.Text = Convert.ToString(pot);
            //txtrai.Text = Convert.ToString(rai);            
        }

        private void btncln_Click(object sender, EventArgs e)
        {
            //txtvalor1.Clear();
            //txtvalor2.Clear();
            //txtsum.Clear();
            //txtrest.Clear();
            //txtmult.Clear();
            //txtdiv.Clear();
            //txtpot.Clear();
            //txtrai.Clear();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            //txtresultado.Text = Convert.ToString("1");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtvalor.Clear();
            btnpunto.Enabled = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "1";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "2";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "3";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "4";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "5";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "6";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "7";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "8";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "9";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text.Length == 0)
            {
                txtvalor.Text = "0";
            }
            else if (txtvalor.Text.Substring(0) != "0")
            {
                txtvalor.Text = txtvalor.Text + "0";
            }
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "+";
        }

        private void btnrest_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "-";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "*";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "/";
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {          
            btnpunto.Enabled = txtvalor.Text.Contains(".") && txtvalor.Text != "";
            
            if (txtvalor.Text == "")
            {
                btnpunto.Enabled = true;
                return;
            }
            else
            {
                txtvalor.Text = txtvalor.Text.Remove(txtvalor.Text.Length - 1, 1);
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {

        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "0.";
            }
            //else
            //{
            //    txtvalor.Text = txtvalor.Text + ".";
            //}
            if (txtvalor.Text.Contains("."))
            {
                btnpunto.Enabled = false;
            }
            else
            {
                txtvalor.Text = txtvalor.Text + ".";
            }
        }

        private void btncalc_Click_1(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtvalor.Text);
            if (op == "+")
            {
                result = (num1 + num2);
                txtvalor.Text = Convert.ToString(result);
                num1 = result;
            }
            if (op == "-")
            {
                result = (num1 - num2);
                txtvalor.Text = Convert.ToString(result);
                num1 = result;
            }
            if (op == "*")
            {
                result = (num1 * num2);
                txtvalor.Text = Convert.ToString(result);
                num1 = result;
            }
            if (op == "/")
            {
                if (num2 == 0)
                {
                    txtvalor.Text = "No se puede dividir entre cero";
                }
                else
                {
                    result = (num1 / num2);
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
            }
        }
    }
}
