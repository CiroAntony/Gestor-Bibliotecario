using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyBiblioteca_ADO;
namespace ProyBiblioteca_BL
{
    public  class EditorialBL
    {
        EditorialADO objEditorialADO = new EditorialADO();

        public DataTable ListarEditorial()
        {
            return objEditorialADO.ListarEditorial();
        }

    }
}
