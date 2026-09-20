using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Negocio
{
    public class CategoriaDatos
    {
        public List<Categorias> Listar()
        {
            List<Categorias> lista = new List<Categorias>();
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categorias aux = new Categorias();

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
                datos.setearConsulta("Insert into CATEGORIAS (Descripcion) Values (@desc)");
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

        public void modificar(Categorias nuevo)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.setearConsulta("Update CATEGORIAS Set Descripcion = @desc Where Id = @id");
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
                datos.setearConsulta("Delete from CATEGORIAS Where Id = @id");
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
                datos.setearConsulta("update CATEGORIAS set Activo = 0 where Id = @id");
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