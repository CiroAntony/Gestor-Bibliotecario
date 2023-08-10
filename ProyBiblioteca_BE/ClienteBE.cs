using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBiblioteca_BE
{
    public class ClienteBE
    {
        // Tabla Tb_Libro
        public String idCliente { get; set; }
        public String nomCliente { get; set; }
        public String apeCliente { get; set; }
        public String dni { get; set; }
        public String idUbigeo { get; set; }
        public String direccion { get; set; }
        public String correo { get; set; }
        public String celular { get; set; }
        public String ocupacion { get; set; }
        public Int16 estCliente { get; set; }
        public String empRegistro { get; set; }
        public DateTime fechRegistro { get; set; }
        public String emplUltMod { get; set; }
        public Byte[] fotoCliente { get; set; }
        public DateTime fechUltMod { get; set; }
    }
}
