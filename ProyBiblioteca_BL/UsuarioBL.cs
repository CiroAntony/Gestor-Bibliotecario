using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyBiblioteca_ADO;
using ProyBiblioteca_BE;

namespace ProyBiblioteca_BL
{
    public class UsuarioBL
    {
        UsuarioADO objUsuarioADO = new UsuarioADO();

        public UsuarioBE ConsultarUsuario(String strLogin)
        {
            return objUsuarioADO.ConsultarUsuario(strLogin);
        }
    }
}
