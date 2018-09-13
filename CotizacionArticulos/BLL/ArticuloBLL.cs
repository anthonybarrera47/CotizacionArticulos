using CotizacionArticulos.DAL;
using CotizacionArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionArticulos.BLL
{
   public class ArticuloBLL
    {

        /// <summary>
        /// Este metodo Permite Guardar un Articulo en la DB
        /// </summary>
        /// <param name="articulo">una instancia de Articulos</param>
        /// <returns>Retorna True si Guardo o Falso si Fallo</returns>
        public static bool Guardar(Articulo articulo)
        {
            bool paso = false;
            //Creamos una instancia del Contexto para conectar con la base de datos.
            Contexto db = new Contexto();
            try
            {
                if(db.articulo.Add(articulo)!=null)
                {
                    db.SaveChanges();
                    paso = true;
                }
                db.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return paso;
        }
        /// <summary>
        /// Este metodo permite Modificar un Articulo en la DB
        /// </summary>
        /// <param name="articulo">una instancia de Articulos</param>
        /// <returns>Retorna True si Modifico o Falso si Fallo</returns>
        public static bool Modificar(Articulo articulo)
        {
            bool paso = false;
            //Creamos una instancia de contexto para conectar con la DB
            Contexto db = new Contexto();
            try
            {
                db.Entry(articulo).State = System.Data.Entity.EntityState.Modified;
                if(db.SaveChanges()>0)
                {
                    paso = true;
                }
                db.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return paso;
        }
        /// <summary>
        /// E
        /// </summary>
        /// <param name="id">El Id que se desea Eliminar</param>
        /// <returns>Retorna True si Eliminoo Falso si Fallo</returns>
        public static bool Eliminar(int id)
        {
            bool paso = false;
            //Creamos una instancia de Contexto para conectar con la DB
            Contexto db = new Contexto();
            try
            {
                Articulo articulo = db.articulo.Find(id);
                db.articulo.Remove(articulo);
                if(db.SaveChanges()>0)
                {
                    paso = true;
                }
                db.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return paso;
        }
        /// <summary>
        /// Permite Buscar una Entidad En la DB
        /// </summary>
        /// <param name="id">El Id del articulo que se desea encontrar</param>
        /// <returns>Retorna el articulo encontrado</returns>
        public static Articulo Buscar(int id)
        {
            //Creamos una instancia de Contexto para conectar con la DB
            Contexto db = new Contexto();
            Articulo articulo = new Articulo();
            try
            {
                articulo = db.articulo.Find(id);
                db.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return articulo;
        }
        public static List<Articulo> GetList(Expression<Func<Articulo,bool>>expression)
        {
            List<Articulo> articulos = new List<Articulo>();
            Contexto db = new Contexto();
            try
            {
                articulos = db.articulo.Where(expression).ToList();
                db.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return articulos;
        }
    }
}
