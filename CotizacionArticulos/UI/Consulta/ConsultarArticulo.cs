using CotizacionArticulos.BLL;
using CotizacionArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizacionArticulos.UI.Consulta
{
    public partial class ConsultarArticulo : Form
    {
        public ConsultarArticulo()
        {
            InitializeComponent();
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Articulo>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {

                    case 0://Todo
                        listado = ArticuloBLL.GetList(p => true);
                        break;
                    case 1://ID
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = ArticuloBLL.GetList(p => p.ArticuloId == id);
                        break;

                    case 2://Descripcion
                        listado = ArticuloBLL.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
                        break;
                }

                listado = listado.Where(c => c.FechaVencimiento.Date >= DesdeDateTimePicker.Value.Date && c.FechaVencimiento.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = ArticuloBLL.GetList(p => true);
            }


            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}
