using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LogicaPersistencia.DAO
{
    public class CategoriaDAO
    {
        public void InsertarCategoria(CategoriaVO catvo)
        {
            //aca va el insert y la conexion a la base de datos. 
            SqlConnection con = null;
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
                Console.Write(connectionString);
                Console.Read();
                con = new SqlConnection(connectionString);
                con.Open();
                String query = "INSERT INTO Categoria values(1,@Nombre,@Descripcion,@Habilitado)";
                SqlCommand comando = new SqlCommand(query, con);
                SqlParameter descripcionParameter = new SqlParameter()
                {
                    ParameterName = "@Descripcion",
                    Value = catvo.Descripcion,
                    SqlDbType = SqlDbType.VarChar
                };
                comando.Parameters.Add(descripcionParameter);
                SqlParameter nombreParameter = new SqlParameter()
                {
                    ParameterName = "@Nombre",
                    Value = catvo.Nombre,
                    SqlDbType = SqlDbType.VarChar
                };
                comando.Parameters.Add(nombreParameter);
                SqlParameter habilitadoParameter = new SqlParameter()
                {
                    ParameterName = "@Habilitado",
                    Value = catvo.Habilitado,
                    SqlDbType = SqlDbType.VarChar
                };
                comando.Parameters.Add(habilitadoParameter);
                comando.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.StackTrace);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
            }
            finally
            {
                con.Close();
            }
        }

        public void EliminarCategoria(int catid)
        {
            //aca va el delete y la conexion a la base de datos.    
        }

        public void ModificarCategoria(CategoriaVO catvo)
        {
            //aca va el update y la conexion a la base de datos.    
        }

        public List<CategoriaVO> ListarCategorias()
        {
            return null;
        }

        public CategoriaVO DarCategoria (int catid)
        {
            return null;
        }
    }
}
