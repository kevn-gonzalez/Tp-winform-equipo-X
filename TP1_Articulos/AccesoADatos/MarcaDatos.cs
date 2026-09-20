using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Negocio
{
    public class MarcaDatos
    {
        public List<Marcas> Listar()
        {
            List<Marcas> lista = new List<Marcas>();
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marcas aux = new Marcas();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void agregar(string nuevo)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.setearConsulta("Insert into MARCAS (Descripcion) Values (@desc)");
                datos.setearParametro("@desc", nuevo);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void modificar(Marcas nuevo)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.setearConsulta("Update MARCAS Set Descripcion = @desc Where Id = @id");
                datos.setearParametro("@desc", nuevo.Descripcion);
                datos.setearParametro("@id", nuevo.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.setearConsulta("Delete from MARCAS Where Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void eliminarLogico(int id)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.setearConsulta("update MARCAS set Activo = 0  where Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}