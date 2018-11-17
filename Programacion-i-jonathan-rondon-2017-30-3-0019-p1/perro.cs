using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_i_jonathan_rondon_2017_30_3_0019_p1
{
    public class perro
    {
        //Declaración
        private string nombre;
        private string raza;
        private string altura;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        public string Altura
        {
            get { return altura; }
            set { altura = value+"mts"; }
        }

        //Operaciones
        public string comer(string carne)
        {
            return this.Nombre + " mide " + this.Altura + " y va a comer " + carne;
        }
        public void dormir()
        {

        }
        public void ladrar()
        {

        }

        public perro()
        {

        }
        public perro(string nombre, string raza, string altura)
        {
            this.Nombre = nombre;
            this.Raza = raza;
            this.Altura = altura;
        }
    }
}
