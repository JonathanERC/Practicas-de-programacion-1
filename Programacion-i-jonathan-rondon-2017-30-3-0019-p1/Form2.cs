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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txt1nombre, "Ingrese su Nombre y su Apellido");
            this.ttmensaje.SetToolTip(this.txt1edad, "Ingrese su Edad");
            this.ttmensaje.SetToolTip(this.txt1salario, "Ingrese su Salario");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btn1enviar_Click(object sender, EventArgs e)
        {
            if (is_validate())
            {
                erroricono.Clear();
                MessageBox.Show("Datos agregados correctamente", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool is_validate()
        {
            bool no_error = true;

            if (txt1nombre.Text==string.Empty)
            {
                erroricono.SetError(txt1nombre, "Ingrese su Nombre y Apellido");
                no_error = false;
            }
            else
            {
                try
                    {
                    int i = Convert.ToInt32(txt1edad.Text);
                    }
                catch
                    {
                    erroricono.Clear();
                    erroricono.SetError(txt1edad, "Ingrese Edad");
                    return false;
                    }
                try
                    {
                    double j = Convert.ToDouble(txt1salario.Text);
                    }
                catch
                    {
                    erroricono.Clear();
                    erroricono.SetError(txt1salario, "Ingrese un Salario válido");
                    return false;
                    }
            }
            return no_error;
        }

        private void btn1nuevo_Click(object sender, EventArgs e)
        {
            txt1descripcion.Clear();
            txt1edad.Clear();
            txt1nombre.Clear();
            txt1salario.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Declarar variables
            int numero;
            double suma, resta, mult, div;
            //Entrada de datos
            numero = Convert.ToInt32(txt2numero.Text);
            //Proceso
            cb2suma.Items.Clear();
            cb2resta.Items.Clear();
            cb2mult.Items.Clear();
            cb2div.Items.Clear();
            //Bucle
            for (int i = 1; i <=12; i++)
            {
                suma = numero + i;
                resta = numero - i;
                div = numero / i;
                mult = numero * i;
                //Resultados
                cb2suma.Items.Add(numero + "+" + i + "=" + suma);
                cb2resta.Items.Add(numero + "-" + i + "=" + resta);
                cb2mult.Items.Add(numero + "*" + i + "=" + mult);
                cb2div.Items.Add(numero + "/" + i + "=" + div);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb2suma.Items.Clear();
            cb2resta.Items.Clear();
            cb2mult.Items.Clear();
            cb2div.Items.Clear();
            txt2numero.Clear();
        }
    }
}
