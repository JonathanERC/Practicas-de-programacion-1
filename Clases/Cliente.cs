using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente : Persona
    {
        private string categoria;
        private string codigo;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        //public string Categoria { get => categoria; set => categoria = value; }
        //public string Codigo { get => codigo; set => codigo = value; }

        public void generarcodigo()
        {
            this.Codigo = "C" + this.Apellidos.Substring(0, 3) + "18";
        }
    }
}
