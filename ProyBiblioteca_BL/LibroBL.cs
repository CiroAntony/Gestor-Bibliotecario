using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyBiblioteca_ADO;
using ProyBiblioteca_BE;

namespace ProyBiblioteca_BL
{
    public  class LibroBL
    {
        LibroADO objLibroADO = new LibroADO();

        public DataTable ListarLibro()
        { 
           return objLibroADO.ListarLibro();
        }
        public LibroBE ConsultarLibro(String strCodigo)
        {
            return objLibroADO.ConsultarLibro(strCodigo );
        }

        public Boolean InsertarLibro(LibroBE objLibroBE)
        {
            return objLibroADO.InsertarLibro(objLibroBE);
        }
        public Boolean ActualizarLibro(LibroBE objLibroBE)
        {
            return objLibroADO.ActualizarLibro(objLibroBE);
        }
        public Boolean EliminarLibro(String strCodigo)
        {
            return objLibroADO.EliminarLibro(strCodigo);
        }
    }
}
