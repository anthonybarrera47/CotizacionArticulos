using CotizacionArticulos.BLL;
using CotizacionArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizacionArticulos.UI.Registro
{
    public partial class RegistroArticulo : Form
    {
        public RegistroArticulo()
        {
            InitializeComponent();
        }
        public void validarTextBox(int i, KeyPressEventArgs e)
        {
           switch(i)
            {
                case 1:
                    try
                    {
                        //Para Validar Solo numeros
                        CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
                        if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                            e.Handled = false;
                        else if (char.IsControl(e.KeyChar))
                            e.Handled = false;
                        else if (char.IsWhiteSpace(e.KeyChar))
                            e.Handled = true;
                        else
                            e.Handled = true;

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    break;
                case 2:
                    try
                    {   //Para Validar Solo letras
                        CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
                        if (char.IsLetter(e.KeyChar))
                            e.Handled = false;
                        else if (char.IsControl(e.KeyChar))
                            e.Handled = false;
                        else if (char.IsWhiteSpace(e.KeyChar))
                            e.Handled = false;
                        else
                            e.Handled = true;

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    break;
            }
           
        }
        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTextBox(1,e);
        }

        private void ExistenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTextBox(1, e);
        }

        private void DescripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTextBox(2, e);
        }

        private void CantidadCotizadaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTextBox(1, e);
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            PrecioTextBox.Text = Convert.ToString(0.0f);
            ExistenciaTextBox.Text = Convert.ToString(0.0f);
            CantidadCotizadaTextBox.Text = Convert.ToString(0.0f);
            FechaVencimientoDateTImePicker.Value = DateTime.Now;

        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Articulo llenaClase()
        {
            Articulo articulo = new Articulo()
            {
                ArticuloId = Convert.ToInt32(IdNumericUpDown.Value),
                Descripcion = DescripcionTextBox.Text,
                Precio = Convert.ToSingle(PrecioTextBox.Text),
                Existencia = Convert.ToSingle(ExistenciaTextBox.Text),
                CantidadCotizada = Convert.ToSingle(CantidadCotizadaTextBox.Text),
                FechaVencimiento = FechaVencimientoDateTImePicker.Value
            };
            return articulo;
        }
        private void LlenaCampo(Articulo articulo)
        {
            IdNumericUpDown.Value = articulo.ArticuloId;
            DescripcionTextBox.Text = articulo.Descripcion;
            PrecioTextBox.Text = Convert.ToString(articulo.Precio);
            ExistenciaTextBox.Text = Convert.ToString(articulo.Existencia);
            CantidadCotizadaTextBox.Text = Convert.ToString(articulo.CantidadCotizada);
            FechaVencimientoDateTImePicker.Value = articulo.FechaVencimiento;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Articulo articulo;
            bool paso = false;
            if (!Validar())
                return;
            articulo = llenaClase();

            if (IdNumericUpDown.Value == 0)
                paso = ArticuloBLL.Guardar(articulo);
            else
            {
                if(!ExisteEnLBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Articulo Inexistente", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = ArticuloBLL.Modificar(articulo);
            }

            if(paso)
            {
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            if(!ExisteEnLBaseDeDatos())
            {
                errorProvider.SetError(IdNumericUpDown, "No se puede eliminar un Articulo Inexistente");
                return;
            }
            if(ArticuloBLL.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Eliminado", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ExisteEnLBaseDeDatos()
        {
            Articulo articulo = ArticuloBLL.Buscar((int)IdNumericUpDown.Value);
            return (articulo != null);
        }

        private bool Validar()
        {
            bool paso = true;

            if(String.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                errorProvider.SetError(DescripcionTextBox, "No puede dejar este campo Vacio");
                paso = false;
            }
            if(String.IsNullOrWhiteSpace(PrecioTextBox.Text))
            {
                errorProvider.SetError(PrecioTextBox, "No puede dejar este campo Vacio");
                paso = false;
            }
            if(String.IsNullOrWhiteSpace(ExistenciaTextBox.Text))
            {
                errorProvider.SetError(ExistenciaTextBox, "No puede dejar este campo Vacio");
                paso = false;
            }
            if(String.IsNullOrWhiteSpace(CantidadCotizadaTextBox.Text))
            {
                errorProvider.SetError(CantidadCotizadaTextBox, "No puede dejar este campo Vacio");
                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Articulo articulo = new Articulo();
            int.TryParse(IdNumericUpDown.Text, out id);
            articulo = ArticuloBLL.Buscar(id);

            if(articulo != null)
            {
                LlenaCampo(articulo);
                MessageBox.Show("Articulo Encontrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Articulo no Encontrado", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

       
    }   
}
