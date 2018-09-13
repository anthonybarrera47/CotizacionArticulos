using Microsoft.VisualStudio.TestTools.UnitTesting;
using CotizacionArticulos.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizacionArticulos.Entidades;

namespace CotizacionArticulos.BLL.Tests
{
    [TestClass()]
    public class ArticuloBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Articulo articulo = new Articulo();
            
            articulo.FechaVencimiento = DateTime.Now;
            articulo.Descripcion = "Probando";
            articulo.Precio = 0.0f;
            articulo.Existencia = 10f;
            articulo.CantidadCotizada = 5f;
            paso = ArticuloBLL.Guardar(articulo);
            Assert.AreEqual(paso, true);

        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Articulo articulo = new Articulo();
            articulo.FechaVencimiento = DateTime.Now;
            articulo.Descripcion = "Probando1234";
            articulo.ArticuloId = 1;
            articulo.Precio = 0.0f;
            articulo.Existencia = 10f;
            articulo.CantidadCotizada = 5f;
            paso = ArticuloBLL.Modificar(articulo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            Articulo articulo = new Articulo();
            articulo.ArticuloId = 1;
            paso = ArticuloBLL.Modificar(articulo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso;
            Articulo articulo = new Articulo();
            articulo.ArticuloId = 1;
            paso = ArticuloBLL.Modificar(articulo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}