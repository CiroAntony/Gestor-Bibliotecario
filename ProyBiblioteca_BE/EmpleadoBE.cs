using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBiblioteca_BE
{
    public class EmpleadoBE
    {
        public String idEmpleado { get; set; }
        public String nomEmpleado { get; set; }
        public String apeEmpleado { get; set; }
        public DateTime fechIngreso { get; set; }
        public DateTime fechNacimiento { get; set; }
        public String numCelular { get; set; }
        public Single Salario { get; set; }
        public String correo { get; set; }
        public String idUbigeo { get; set; }
        public Byte[] fotoEmpleado { get; set; }
        public String empRegistro { get; set; }
        public DateTime fechRegistro { get; set; }
        public String emplUltMod { get; set; }
        public DateTime fechUltMod { get; set; }
    }
}
