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
    public  class EmpleadoADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarEmpleado()
        {
            
            try
            {

                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEmpleado";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Empleado");
                return dts.Tables["Empleado"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public EmpleadoBE ConsultarEmpleado (String strCodigo)
        {
            
            try
            {

                EmpleadoBE objEmpleadoBE = new EmpleadoBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarEmpleado";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_emp", strCodigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objEmpleadoBE.idEmpleado = dtr["idEmpleado"].ToString();
                    objEmpleadoBE.nomEmpleado = dtr["nomEmpleado"].ToString();
                    objEmpleadoBE.apeEmpleado = dtr["apeEmpleado"].ToString();
                    objEmpleadoBE.fechIngreso = Convert.ToDateTime(dtr["fechIngreso"]);
                    objEmpleadoBE.fechNacimiento = Convert.ToDateTime(dtr["fechNacimiento"]);
                    objEmpleadoBE.numCelular = dtr["numCelular"].ToString();
                    objEmpleadoBE.Salario = Convert.ToSingle(dtr["Salario"]);
                    objEmpleadoBE.correo = dtr["correo"].ToString();
                    objEmpleadoBE.idUbigeo = dtr["idUbigeo"].ToString();
                    objEmpleadoBE.fotoEmpleado = (Byte[])(dtr["fotoEmpleado"]);
                }
                dtr.Close();
                return objEmpleadoBE;

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

        public Boolean InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {
          
            try
            {

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vnomEmple", objEmpleadoBE.nomEmpleado);
                cmd.Parameters.AddWithValue("@vapeEmple", objEmpleadoBE.apeEmpleado);
                cmd.Parameters.AddWithValue("@vfecIng", objEmpleadoBE.fechIngreso);
                cmd.Parameters.AddWithValue("@vfecNac", objEmpleadoBE.fechNacimiento);
                cmd.Parameters.AddWithValue("@vnumCel", objEmpleadoBE.numCelular);
                cmd.Parameters.AddWithValue("@vSalario", objEmpleadoBE.Salario);
                cmd.Parameters.AddWithValue("@vCorreo", objEmpleadoBE.correo);
                cmd.Parameters.AddWithValue("@vId_Ubigeo", objEmpleadoBE.idUbigeo);
                cmd.Parameters.AddWithValue("@vempReg", objEmpleadoBE.empRegistro);
                cmd.Parameters.AddWithValue("@vfoto", objEmpleadoBE.fotoEmpleado);
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
        public Boolean ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            try
            {

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vidEmple", objEmpleadoBE.idEmpleado);
                cmd.Parameters.AddWithValue("@vnomEmple", objEmpleadoBE.nomEmpleado);
                cmd.Parameters.AddWithValue("@vapeEmple", objEmpleadoBE.apeEmpleado);
                cmd.Parameters.AddWithValue("@vfecIng", objEmpleadoBE.fechIngreso);
                cmd.Parameters.AddWithValue("@vfecNac", objEmpleadoBE.fechNacimiento);
                cmd.Parameters.AddWithValue("@vnumCel", objEmpleadoBE.numCelular);
                cmd.Parameters.AddWithValue("@vSalario", objEmpleadoBE.Salario);
                cmd.Parameters.AddWithValue("@vCorreo", objEmpleadoBE.correo);
                cmd.Parameters.AddWithValue("@vId_Ubigeo", objEmpleadoBE.idUbigeo);
                cmd.Parameters.AddWithValue("@empUltMod", objEmpleadoBE.emplUltMod);
                cmd.Parameters.AddWithValue("@vfoto", objEmpleadoBE.fotoEmpleado);
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

        public Boolean EliminarEmpleado(String strCodigo)
        {
           

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vId", strCodigo);
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
