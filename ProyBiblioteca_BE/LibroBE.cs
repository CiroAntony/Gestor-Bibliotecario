using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBiblioteca_BE
{
    public class LibroBE
    {

        // Tabla Tb_Libro
        public String idLibro { get; set; }
        public String tituloLibro { get; set; }
        public Int16 canPaginas { get; set; }

        private DateTime mvarFechLanzamiento;
        public DateTime fechLanzamiento { 
            get { return mvarFechLanzamiento; }
            set { mvarFechLanzamiento = value; } 
        }
        public String idTema { get; set; }
        public String idEditorial { get; set; }
        public Byte[] fotoLibro { get; set; }
        public String empRegistro { get; set; }
        public DateTime fechRegistroo { get; set; }
        public String emplUltMod { get; set; }
        public DateTime fechUltMod { get; set; }
    }
}
