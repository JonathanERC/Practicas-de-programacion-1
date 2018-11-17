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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int horasTrabajadas;
            float costoHora;
            float sueldo;
            string linea;
            Console.Write("Ingrese Horas trabajadas: ");
            linea = Console.ReadLine();
            horasTrabajadas = int.Parse(linea);
            Console.Write("Ingrese pago por hora: ");
            linea = Console.ReadLine();
            costoHora = float.Parse(linea);
            sueldo = horasTrabajadas * costoHora;
            Console.Write("El sueldo total es: ");
            Console.Write(sueldo);
            Console.ReadKey();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnprograma3_Click(object sender, EventArgs e)
        {
            float sueldo;
            string linea;
            Console.Write("Ingrese el sueldo: ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
            if (sueldo > 33000)
            {
                Console.Write("Esta persona debe abonar impuestos: ");
            }
            Console.ReadKey();
        }

        private void btnprograma2_Click(object sender, EventArgs e)
        {
            int lado;
            int superficie;
            String linea;
            Console.Write("Ingrese el valor del lado del cuadrado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
            superficie = lado * lado;
            Console.Write("La superficie del cuadrado es: ");
            Console.Write(superficie);
            Console.ReadKey();
        }

        private void btnprograma4_Click(object sender, EventArgs e)
        {
            int num1, num2, suma, producto;
            string linea;
            Console.Write("Ingrese primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            suma = num1 + num2;
            producto = num1 * num2;
            Console.Write("La suma de los dos valores es: ");
            Console.WriteLine(suma);
            Console.Write("El producto de los dos valores es: ");
            Console.WriteLine(producto);
            Console.ReadKey();
        }

        private void btnprograma5_Click(object sender, EventArgs e)
        {
            int nota1, nota2, nota3;
            string linea;
            Console.Write("Ingrese primera nota: ");
            linea = Console.ReadLine();
            nota1 = int.Parse(linea);
            Console.Write("Ingrese segunda nota: ");
            linea = Console.ReadLine();
            nota2 = int.Parse(linea);
            Console.Write("Ingrese tercer nota: ");
            linea = Console.ReadLine();
            nota3 = int.Parse(linea);
            int promedio = (nota1 + nota2 + nota3) / 3;
            if (promedio >= 7)
            {
                Console.Write("Aprobado");
            }
            else
            {
                if (promedio >= 4)
                {
                    Console.Write("Regular");
                }
                else
                {
                    Console.Write("Reprobado");
                }
            }
            Console.ReadKey();
        }
    }
}