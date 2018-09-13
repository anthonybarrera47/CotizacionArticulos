using CotizacionArticulos.UI.Consulta;
using CotizacionArticulos.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizacionArticulos
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void cotizacionDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroArticulo registro = new RegistroArticulo();
            registro.MdiParent = this;
            registro.Show();
        }

        private void consultaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarArticulo consulta = new ConsultarArticulo();
            consulta.MdiParent = this;
            consulta.Show();
        }
    }
}
