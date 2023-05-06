using capaDominio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class ArticulosNegocio
    {
        public List<Articulo> listar()
        {

            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "Data Source=localhost;Initial Catalog=CATALOGO_DB;Integrated Security=True";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE M.Id = A.IdMarca AND C.Id = A.IdCategoria";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    if (!(lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)lector["ImagenUrl"];

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)lector["Categoria"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion,IdMarca, IdCategoria, ImagenUrl, Precio) VALUES('\" + nuevo.Codigo + \"', '\" + nuevo.Nombre + \"', '\" + nuevo.Descripcion + \"', @idMarca, @idCategoria, @imagenUrl)");
                datos.setearParametro("@idMarca", nuevo.Marca.Id);
                datos.setearParametro("@idCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@imagenUrl", nuevo.ImagenUrl);
                datos.ejecutarAccion();

                

            }
            catch(Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }

        }
        public void modificar (Articulo modificar) { }
    }
}
