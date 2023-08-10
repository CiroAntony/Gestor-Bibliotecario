using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyBiblioteca_BE;

namespace ProyBiblioteca_ADO
{
    public  class LibroADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarLibro()
        {
            
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarLibro";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Libros");
                return dts.Tables["Libros"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public LibroBE ConsultarLibro (String strCodigo)
        {
            
            try
            {
                LibroBE objLibroBE = new LibroBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarLibro";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", strCodigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objLibroBE.idLibro = dtr["idLibro"].ToString();
                    objLibroBE.tituloLibro = dtr["tituloLibro"].ToString();
                    objLibroBE.canPaginas = Convert.ToInt16(dtr["canPaginas"]);
                    objLibroBE.idTema = dtr["idTema"].ToString();
                    objLibroBE.idEditorial = dtr["idEditorial"].ToString();
                    objLibroBE.empRegistro = dtr["empRegistro"].ToString();
                    objLibroBE.fotoLibro = (Byte[])(dtr["fotoLibro"]);
                    objLibroBE.fechLanzamiento = Convert.ToDateTime(dtr["fechLanzamiento"]);
                }
                dtr.Close();
                return objLibroBE;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }



        }

        public Boolean InsertarLibro(LibroBE objLibroBE)
        {
          
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarLibro";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom", objLibroBE.tituloLibro);
                cmd.Parameters.AddWithValue("@canpag", objLibroBE.canPaginas);
                cmd.Parameters.AddWithValue("@idEd", objLibroBE.idEditorial);
                cmd.Parameters.AddWithValue("@foto", objLibroBE.fotoLibro);
                cmd.Parameters.AddWithValue("@idTem", objLibroBE.idTema);
                cmd.Parameters.AddWithValue("@empR", objLibroBE.empRegistro);
                cmd.Parameters.AddWithValue("@fechlanz", objLibroBE.fechLanzamiento);
                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }


        public Boolean ActualizarLibro(LibroBE objLibroBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarLibro";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", objLibroBE.idLibro);
                cmd.Parameters.AddWithValue("@nom", objLibroBE.tituloLibro);
                cmd.Parameters.AddWithValue("@canpag", objLibroBE.canPaginas);
                cmd.Parameters.AddWithValue("@fechlanz", objLibroBE.fechLanzamiento);
                cmd.Parameters.AddWithValue("@idEd", objLibroBE.idEditorial);
                cmd.Parameters.AddWithValue("@foto", objLibroBE.fotoLibro);
                cmd.Parameters.AddWithValue("@idTem", objLibroBE.idTema);
                cmd.Parameters.AddWithValue("@empUlt", objLibroBE.emplUltMod);
                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }

        public Boolean EliminarLibro(String strCodigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarLibro";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", strCodigo);
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }

    }
}
