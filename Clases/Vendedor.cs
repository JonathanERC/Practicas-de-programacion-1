using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Vendedor:Persona
    {
        private string tipocontrato;
        private double sueldo;

        public string Tipocontrato
        {
            get { return tipocontrato; }
            set { tipocontrato = value; }
        }

        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        //public string Tipocontrato { get => tipocontrato; set => tipocontrato = value; }
        //public double Sueldo { get => sueldo; set => sueldo = value; }

        public void calcularsueldo(double sueldobase)
        {
            if (this.Tipocontrato=="C")
            {
                this.Sueldo = sueldobase + 350;
            }
            else if (this.Tipocontrato=="N")
            {
                this.Sueldo = sueldobase + 750;
            }
            else
            {
                this.Sueldo = 0;
            }
        }
    }
}
