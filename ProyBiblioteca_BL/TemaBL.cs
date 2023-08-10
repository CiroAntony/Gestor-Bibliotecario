using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyBiblioteca_ADO;
namespace ProyBiblioteca_BL
{
    public  class TemaBL
    {
        TemaADO objTemaADO = new TemaADO();

        public DataTable ListarTema()
        {
            return objTemaADO.ListarTema();
        }
    }
}
