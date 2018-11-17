using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        private string apellidos;
        private string nombres;
        private string documento;
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        //public string Tipo { get => Tipo; set => tipo = value; }
        //public string Documento { get => documento; set => documento = value; }
        //public string Nombres { get => nombres; set => nombres = value; }
        //public string Apellidos { get => apellidos; set => apellidos = value; }
    }
}
