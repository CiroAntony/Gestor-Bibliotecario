using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyBiblioteca_ADO;
namespace ProyBiblioteca_BL
{
    public class UbigeoBL
    {
        UbigeoADO objUbigeoADO = new UbigeoADO();

        public DataTable ListarDepartamento()
        {
            return objUbigeoADO.ListarDepartamento();
        }
        public DataTable ListarProvincia(String strIdDepartamento)
        {
            return objUbigeoADO.ListarProvincia(strIdDepartamento);
        }
        public DataTable ListarDistritos(String strIdDepartamento, String strIdProvincia)
        {
            return objUbigeoADO.ListarDistritos(strIdDepartamento, strIdProvincia);
        }
    }
}
