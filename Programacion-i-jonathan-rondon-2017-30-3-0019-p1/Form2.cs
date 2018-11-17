using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

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
            desactivarcontroles();
        }
        //Form 11
        private double monto;
        private void acivarcontroles()
        {
            txt11cliente.Enabled = false;
            txt11monto.Enabled = false;
            btn11cuenta.Enabled = false;
            btn11deposito.Enabled = true;
            btn11retiro.Enabled = true;
        }
        private void desactivarcontroles()
        {
            txt11cliente.Enabled = true;
            txt11monto.Enabled = true;
            btn11cuenta.Enabled = true;
            btn11deposito.Enabled = false;
            btn11retiro.Enabled = false;
        }
        //Form 0
        private int _numero1;
        public int Numero1
        {
            get { return _numero1; }
            set { _numero1 = value; }
        }

        private int _numero2;
        public int Numero2
        {
            get { return _numero2; }
            set { _numero2 = value; }
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

            if (txt1nombre.Text == string.Empty)
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
            for (int i = 1; i <= 12; i++)
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
                    nota = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese nota del alumno" + i, "Promedio Notas", "16", 100, 100));
                    sumanotas = sumanotas + nota;
                    if (nota < notabaja)
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
            while (stock >= 10)
            {
                cantentrega = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad entregada persona " + (cantpersonas + 1), "Reparto de vacunas"));
                if (stock >= cantentrega)
                {
                    cantpersonas = cantpersonas + 1;
                    stock = stock - cantentrega;
                }
                else
                {
                    MessageBox.Show("No hay suficiente Stock", "Reparto de Vacunas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("El Stock es inferior a 10 unidades", "Reparto de Vacunas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                gasto = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el gasto del dia " + dia, "Gastos"));
                vgastos[dia - 1] = gasto;
            }
            for (int i = 0; i < cantdias; i++)
            {
                if (vgastos[i] > gastomayor)
                {
                    gastomayor = vgastos[i];
                    diamayor = i + 1;
                }
                totalgasto = totalgasto + vgastos[i];
                cb7gastos.Items.Add("Día " + (i + 1) + " Total: " + vgastos[i]);
            }
            //Salida
            txt7mayorgasto.Text = Convert.ToString("RD$ " + gastomayor);
            txt7mayordia.Text = Convert.ToString("Día " + diamayor);
            txt7gastos.Text = Convert.ToString("RD$ " + totalgasto);
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
                if (mplatos[i, 0].Equals(plato))
                {
                    txt8precio.Text = mplatos[i, 1];
                    txt8disponible.Text = mplatos[i, 2];
                    index = i;
                    btn8vender.Enabled = true;
                    encuentra = 1;
                }
            }
            if (encuentra == 0)
            {
                MessageBox.Show("No existe el plato", "Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (cant <= stock)
            {
                mplatos[index, 2] = Convert.ToString(stock - cant);
            }
            else
            {
                MessageBox.Show("No hay suficiente Stock", "Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txt9pricaracter.Text = cadena.Substring(0, 1);
            txt9ultcaracter.Text = cadena.Substring(cadena.Length - 1, 1);
            txt9mayus.Text = cadena.ToUpper();
            txt9minus.Text = cadena.ToLower();
            txt9noespacios.Text = cadena.Replace(" ", "");
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

        private void btn0limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        //Procedimiento form 0
        struct cliente
        {
            public string nombre;
            public string apellidos;
            public string telefono;
        }
        private double operaciones(int num1, int num2, string op)
        {
            double resultado;
            if (op == "s")
            {
                resultado = num1 + num2;
            }
            else if (op == "r")
            {
                resultado = num1 - num2;
            }
            else if (op == "m")
            {
                resultado = num1 * num2;
            }
            else
            {
                resultado = num1 / num2;
            }
            return resultado;
        }

        private void limpiar()
        {
            txt0num1.Clear();
            txt0num2.Clear();
            txt0resultado.Clear();
        }

        private int sumar(int num1, int num2)
        {
            int resultado;
            resultado = num1 + num2;
            return resultado;
        }

        private void btn0sum_Click(object sender, EventArgs e)
        {
            int suma, numero1, numero2;
            //Entrada
            numero1 = Convert.ToInt32(txt0num1.Text);
            numero2 = Convert.ToInt32(txt0num2.Text);
            suma = sumar(numero1, numero2);
            txt0resultado.Text = Convert.ToString(suma);
        }

        private void btn0rest_Click(object sender, EventArgs e)
        {
            int numero1, numero2;
            double resultado;

            numero1 = Convert.ToInt32(txt0num1.Text);
            numero2 = Convert.ToInt32(txt0num2.Text);
            resultado = operaciones(numero1, numero2, "r");
            txt0resultado.Text = Convert.ToString(resultado);
        }

        private void btn0mult_Click(object sender, EventArgs e)
        {
            int numero1, numero2;
            double resultado;

            numero1 = Convert.ToInt32(txt0num1.Text);
            numero2 = Convert.ToInt32(txt0num2.Text);
            resultado = operaciones(numero1, numero2, "m");
            txt0resultado.Text = Convert.ToString(resultado);
        }

        private void btn0div_Click(object sender, EventArgs e)
        {
            int numero1, numero2;
            double resultado;

            numero1 = Convert.ToInt32(txt0num1.Text);
            numero2 = Convert.ToInt32(txt0num2.Text);
            resultado = operaciones(numero1, numero2, "d");
            txt0resultado.Text = Convert.ToString(resultado);
        }

        private void btn0prop_Click(object sender, EventArgs e)
        {
            Numero1 = 10;
            Numero2 = 30;
            int suma;
            suma = Numero1 + Numero2;
            txt0resultado.Text = Convert.ToString("La propiedad es: " + suma);
        }

        private void btn0estructura_Click(object sender, EventArgs e)
        {
            cliente cliente1;
            cliente1.nombre = "Jonathan";
            cliente1.apellidos = "Rondón";
            cliente1.telefono = "829-686-7410";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn11cuenta_Click(object sender, EventArgs e)
        {
            string cliente;
            //Inicio
            cliente = txt11cliente.Text;
            monto = Convert.ToDouble(txt11monto.Text);
            if (monto > 0)
            {
                acivarcontroles();
            }
            else
            {
                MessageBox.Show("El monto debe ser mayor o igual a cero", "Gestión de ahorros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double leer(string mensaje)
        {
            double cantidad;
            cantidad=Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese monto a "+mensaje,"Gestión de ahorros","0",100,0));
            return cantidad;
        }

        private void btn11deposito_Click(object sender, EventArgs e)
        {
            double deposito;
            deposito = leer("Depositar");
            monto = monto + deposito;
            lb111.Items.Add(deposito);
            mostrar();
        }
        private void mostrar()
        {
            txt11saldo.Text = Convert.ToString(monto);
        }

        private void btn11retiro_Click(object sender, EventArgs e)
        {
            double retiro;
            retiro = leer("Retirar");
            if (retiro <=monto)
            {
                monto = monto - retiro;
                lb112.Items.Add(retiro);
                mostrar();
            }
            else
            {
                MessageBox.Show("Cantidad de retiro es mayor que el monto disponible","Gestión de ahorros",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn11nuevo_Click(object sender, EventArgs e)
        {
            txt11cliente.Clear();
            txt11monto.Clear();
            txt11saldo.Clear();
            lb111.Items.Clear();
            lb112.Items.Clear();
            desactivarcontroles();
        }

        private void btn12objeto1_Click(object sender, EventArgs e)
        {
            perro perrito = new perro();
            perrito.Nombre = "Paco";
            perrito.Raza = "Viralata";
            perrito.Altura = "2";

            txt12resultado.Text = perrito.comer("Carne");
        }

        private void btn12objeto2_Click(object sender, EventArgs e)
        {
            perro perrito = new perro();
            perrito.Nombre = "Laika";
            perrito.Altura = "3";

            txt12resultado.Text = perrito.comer("Pollo");
        }

        private void btn12objeto3_Click(object sender, EventArgs e)
        {
            perro perrito = new perro("Cafe", "Chiguagua","0.5");
            txt12resultado.Text = perrito.comer("Pan");
        }

        private void btn13guardar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor1 = new Vendedor();
            vendedor1.Apellidos = txt13apellido.Text;
            vendedor1.Nombres = txt13nombre.Text;
            vendedor1.Documento = txt13documento.Text;
            vendedor1.Tipo = cb13tipo.Text;
            vendedor1.Tipocontrato = cb13contrato.Text;

            vendedor1.calcularsueldo(750);
            dg13vendedores.Rows.Insert(0, vendedor1.Tipo,vendedor1.Apellidos,vendedor1.Nombres,vendedor1.Documento,vendedor1.Sueldo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MDI _ver = new MDI();
            _ver.Show();
        }
    }
}
