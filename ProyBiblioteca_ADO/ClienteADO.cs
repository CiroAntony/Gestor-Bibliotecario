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
    public  class ClienteADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarCliente()
        {
            
            try
            {

                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCliente";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Clientes");
                return dts.Tables["Clientes"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public ClienteBE ConsultarCliente (String strCodigo)
        {
            
            try
            {

                ClienteBE objClienteBE = new ClienteBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarCliente";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCliente", strCodigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objClienteBE.idCliente = dtr["idCliente"].ToString();
                    objClienteBE.nomCliente = dtr["nomCliente"].ToString();
                    objClienteBE.apeCliente = dtr["apeCliente"].ToString();
                    objClienteBE.dni = dtr["dni"].ToString();
                    objClienteBE.idUbigeo = dtr["idUbigeo"].ToString();
                    objClienteBE.direccion = dtr["direccion"].ToString();
                    objClienteBE.correo = dtr["correo"].ToString();
                    objClienteBE.celular = dtr["celular"].ToString();
                    objClienteBE.ocupacion = dtr["ocupacion"].ToString();
                    objClienteBE.estCliente = Convert.ToInt16(dtr["estCliente"]);
                    objClienteBE.fotoCliente = (Byte[])(dtr["fotoCliente"]);
                }
                dtr.Close();
                return objClienteBE;

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

        public Boolean InsertarCliente(ClienteBE objClienteBE)
        {
          
            try
            {

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomCliente", objClienteBE.nomCliente);
                cmd.Parameters.AddWithValue("@apeCliente", objClienteBE.apeCliente);
                cmd.Parameters.AddWithValue("@dni", objClienteBE.dni);
                cmd.Parameters.AddWithValue("@ubigeo", objClienteBE.idUbigeo);
                cmd.Parameters.AddWithValue("@direccion", objClienteBE.direccion);
                cmd.Parameters.AddWithValue("@correo", objClienteBE.correo);
                cmd.Parameters.AddWithValue("@celular", objClienteBE.celular);
                cmd.Parameters.AddWithValue("@ocupacion", objClienteBE.ocupacion);
                cmd.Parameters.AddWithValue("@foto", objClienteBE.fotoCliente);
                cmd.Parameters.AddWithValue("@estCli", objClienteBE.estCliente);
                cmd.Parameters.AddWithValue("@empRegistro", objClienteBE.empRegistro);
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
        public Boolean ActualizarCliente(ClienteBE objClienteBE)
        {
            try
            {

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCliente", objClienteBE.idCliente);
                cmd.Parameters.AddWithValue("@nomCliente", objClienteBE.nomCliente);
                cmd.Parameters.AddWithValue("@apeCliente", objClienteBE.apeCliente);
                cmd.Parameters.AddWithValue("@dni", objClienteBE.dni);
                cmd.Parameters.AddWithValue("@ubigeo", objClienteBE.idUbigeo);
                cmd.Parameters.AddWithValue("@direccion", objClienteBE.direccion);
                cmd.Parameters.AddWithValue("@correo", objClienteBE.correo);
                cmd.Parameters.AddWithValue("@celular", objClienteBE.celular);
                cmd.Parameters.AddWithValue("@ocupacion", objClienteBE.ocupacion);
                cmd.Parameters.AddWithValue("@estCli", objClienteBE.estCliente);
                cmd.Parameters.AddWithValue("@empUltMod", objClienteBE.emplUltMod);
                cmd.Parameters.AddWithValue("@foto", objClienteBE.fotoCliente);
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

        public Boolean EliminarCliente(String strCodigo)
        {
           

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCliente", strCodigo);
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
