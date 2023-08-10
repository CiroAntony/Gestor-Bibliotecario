using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBiblioteca_ADO
{
    public class UbigeoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        Boolean blnexito = false;

        public DataTable ListarDepartamento()
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarDepartamento";
                cmd.Parameters.Clear();
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Departamentos");
                return dts.Tables["Departamentos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarProvincia(String strIdDepartamento)
        {

            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProvincia";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDepartamento", strIdDepartamento);
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Provincias");
                return dts.Tables["Provincias"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarDistritos(String strIdDepartamento, String strIdProvincia)
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarDistrito";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDepartamento", strIdDepartamento);
                cmd.Parameters.AddWithValue("@IdProvincia", strIdProvincia);
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Distritos");
                return dts.Tables["Distritos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
