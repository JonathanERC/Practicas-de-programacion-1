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
            btn8vender.Enabled = false;
            txt8precio.Enabled = false;
            txt8disponible.Enabled = false;
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

        private void txt3calcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            int numalumnos;
            double nota, sumanotas, notabaja, promedio;
            if (txt3alumnos.Text != "")
            {
                //Etrada de datos
                numalumnos = Convert.ToInt32(txt3alumnos.Text);
                //Inicializar
                sumanotas = 0.0;
                notabaja = 20.0;
                for (int i = 1; i <= numalumnos; i++)
                {
                    nota = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese nota del alumno" + i, "Promedio Notas", "16",100,100));
                    sumanotas = sumanotas + nota;
                    if (nota<notabaja)
                    {
                        notabaja = nota;
                    }
                }
                promedio = sumanotas / numalumnos;
                //Salida de informacion
                txt3promedio.Text = Convert.ToString(promedio);
                txt3notabaja.Text = Convert.ToString(notabaja);
            }
            else
            {
                MessageBox.Show("Ingrese un número válido", "Promedio Notas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn3nuevo_Click(object sender, EventArgs e)
        {
            txt3alumnos.Clear();
            txt3notabaja.Clear();
            txt3promedio.Clear();
        }

        private void btn4ingresar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            int alumnos, nota;
            double promedio = 0;
            //Entrada de datos
            alumnos = Convert.ToInt32(txt4alumnos.Text);
            //Proceso
            for (int i = 1; i <= alumnos; i++)
            {
                do
                {
                    nota = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese nota del alumno " + i, "Registro Notas"));
                } while (nota < 0 || nota > 20);
                promedio = promedio + nota;
            }
            //Salida
            txt4promedio.Text = Convert.ToString(promedio / alumnos);
        }

        private void btn4nuevo_Click(object sender, EventArgs e)
        {
            txt4alumnos.Clear();
            txt4promedio.Clear();
        }

        private void btn5ingresar_Click(object sender, EventArgs e)
        {
            //Declrar variables
            int stock, cantpersonas, cantentrega;
            //Entrada de datos
            stock = Convert.ToInt32(txt5inicial.Text);
            cantpersonas = 0;
            //Proceso
            while (stock>=10)
            {
                cantentrega = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad entregada persona "+(cantpersonas+1), "Reparto de vacunas"));
                if (stock>=cantentrega)
                {
                    cantpersonas = cantpersonas + 1;
                    stock = stock - cantentrega;
                }
                else
                {
                    MessageBox.Show("No hay suficiente Stock", "Reparto de Vacunas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("El Stock es inferior a 10 unidades","Reparto de Vacunas",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //Salida
            txt5stock.Text = Convert.ToString(stock);
            txt5personas.Text = Convert.ToString(cantpersonas);
        }

        private void btn5nuevo_Click(object sender, EventArgs e)
        {
            txt5inicial.Clear();
            txt5personas.Clear();
            txt5stock.Clear();
        }

        private void btn6vector_Click(object sender, EventArgs e)
        {
            //Declarar variables
            int[] notas = new int[5];
            //Inicio
            notas[0] = 15;
            notas[1] = 13;
            notas[2] = 11;
            notas[3] = 16;
            notas[4] = 18;
            //Proceso
            int suma = 0;
            double promedio;

            cb6notas.Items.Clear();
            for (int i = 0; i <= 4; i++)
            {
                cb6notas.Items.Add(notas[i]);
                suma = suma + notas[i];
            }
            promedio = suma / 5;
            //Salida
            txt6promedio.Text = Convert.ToString(promedio);
        }

        private void btn6nuevo_Click(object sender, EventArgs e)
        {
            txt6promedio.Clear();
            cb6notas.Items.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn7calcular_Click(object sender, EventArgs e)
        {
            //Declaracion
            double[] vgastos;
            double gasto, totalgasto, diamayor, gastomayor;
            int cantdias;
            //Inicio
            totalgasto = 0;
            diamayor = 1;
            gastomayor = 0;
            //proceso
            cantdias = Convert.ToInt32(txt7dias.Text);
            vgastos = new double[cantdias];
            for (int dia = 1; dia <= cantdias; dia++)
            {
               gasto = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el gasto del dia "+dia,"Gastos"));
                vgastos[dia - 1] = gasto;
            }
            for (int i = 0; i < cantdias; i++)
            {
                if (vgastos[i]>gastomayor)
                {
                    gastomayor = vgastos[i];
                    diamayor = i + 1;
                }
                totalgasto = totalgasto + vgastos[i];
                cb7gastos.Items.Add("Día "+(i+1)+" Total: "+vgastos[i]);
            }
            //Salida
            txt7mayorgasto.Text = Convert.ToString("RD$ "+gastomayor);
            txt7mayordia.Text = Convert.ToString("Día "+diamayor);
            txt7gastos.Text = Convert.ToString("RD$ "+totalgasto);
        }

        private void btn7nuevo_Click(object sender, EventArgs e)
        {
            txt7dias.Clear();
            txt7gastos.Clear();
            txt7mayordia.Clear();
            txt7mayorgasto.Clear();
            cb7gastos.Items.Clear();
        }

        private void btn8datos_Click(object sender, EventArgs e)
        {
            //Entrada
            cantplatos = Convert.ToInt32(txt8cantplatos.Text);
            //Inicio
            mplatos = new string[cantplatos, 3];
            for (int i = 0; i < cantplatos; i++)
            {
                mplatos[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Nombre del plato " + (i + 1), "Restaurante");
                mplatos[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Precio del plato " + (i + 1), "Restaurante");
                mplatos[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Stock del plato " + (i + 1), "Restaurante");
            }
        }
        
        //Declarar Form8
        private string[,] mplatos;
        private int cantplatos;
        private int index;
        private int encuentra = 0;
        private void txt8disponible_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn8buscar_Click(object sender, EventArgs e)
        {
            //Variables
            string plato;
            //Entrada
            plato = txt8plato.Text;
            //Inicio
            for (int i = 0; i < cantplatos; i++)
            {
                if (mplatos[i,0].Equals(plato))
                {
                    txt8precio.Text = mplatos[i, 1];
                    txt8disponible.Text = mplatos[i,2];
                    index = i;
                    btn8vender.Enabled = true;
                    encuentra = 1;
                }
            }
            if (encuentra==0)
            {
                MessageBox.Show("No existe el plato","Restaurante",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btn8vender.Enabled = false;
            }
        }

        private void btn8vender_Click(object sender, EventArgs e)
        {
            //Variables
            int cant, stock;
            //Entrada
            cant = Convert.ToInt32(txt8cantidad.Text);
            stock = Convert.ToInt32(txt8disponible.Text);
            if (cant<=stock)
            {
                mplatos[index, 2] = Convert.ToString(stock - cant);
            }
            else
            {
                MessageBox.Show("No hay suficiente Stock","Restaurante",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn8nuevo_Click(object sender, EventArgs e)
        {
            txt8cantidad.Clear();
            txt8cantplatos.Clear();
            txt8disponible.Clear();
            txt8plato.Clear();
            txt8precio.Clear();
        }

        private void btn9nuevo_Click(object sender, EventArgs e)
        {
            txt91a.Clear();
            txt926caracter.Clear();
            txt9cadena.Clear();
            txt9longitud.Clear();
            txt9mayus.Clear();
            txt9minus.Clear();
            txt9noespacios.Clear();
            txt9pricaracter.Clear();
            txt9ultcaracter.Clear();
        }

        private void btn9procesar_Click(object sender, EventArgs e)
        {
            //Variables
            string cadena = txt9cadena.Text;
            //Inicio
            txt9longitud.Text = Convert.ToString(cadena.Length);
            txt9pricaracter.Text = cadena.Substring(0,1);
            txt9ultcaracter.Text = cadena.Substring(cadena.Length-1,1);
            txt9mayus.Text = cadena.ToUpper();
            txt9minus.Text = cadena.ToLower();
            txt9noespacios.Text = cadena.Replace(" ","");
            if (cadena.Contains("A"))
            {
                txt91a.Text = Convert.ToString(cadena.IndexOf("A", 0) + 1);
            }
            else
            {
                txt91a.Text = Convert.ToString("No hay 'A'");
            }

            if (cadena.Length >= 6)
            {
                txt926caracter.Text = cadena.Substring(1, 5);
            }
            else
            {
                txt926caracter.Text = Convert.ToString("No hay suficientes caracteres");
            }
        }
    }
}
