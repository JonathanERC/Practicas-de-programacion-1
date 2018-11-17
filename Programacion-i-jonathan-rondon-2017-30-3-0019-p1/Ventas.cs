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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private static Ventas _instancia;

        public static Ventas getinstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Ventas();
            }
            return _instancia;
        }

        public void setcliente(string cliente)
        {
            txt15cliente.Text = cliente;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void btn15cliente_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.ShowDialog();
        }

        private void Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }
    }
}
