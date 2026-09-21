using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Negocio
{
    public class GenericoDatos
    {
        protected string tablaNombre;

        public GenericoDatos(string tablaNombre) {
            this.tablaNombre = tablaNombre;
        }


        public virtual List<EntidadBase> Listar()
        {
            
            List<EntidadBase> lista = new List<EntidadBase>();
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from " + tablaNombre );
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    EntidadBase aux = new EntidadBase();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public virtual void agregar(string nuevo)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.setearConsulta("Insert into " + tablaNombre + " (Descripcion) Values (@desc)");
                datos.setearParametro("@desc", nuevo);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public virtual void modificar(EntidadBase nuevo)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.setearConsulta("Update " + tablaNombre + " Set Descripcion = @desc Where Id = @id");
                datos.setearParametro("@desc", nuevo.Descripcion);
                datos.setearParametro("@id", nuevo.Id);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public virtual void eliminar(int id)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.setearConsulta("Delete from " + tablaNombre + " Where Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public virtual void eliminarLogico(int id)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.setearConsulta("update " + tablaNombre + " set Activo = 0  where Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}