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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void cb15clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ventas venta = Ventas.getinstancia();
            string par1 = cb15clientes.Text;
            venta.setcliente(par1);
            this.Hide();
        }
    }
}
