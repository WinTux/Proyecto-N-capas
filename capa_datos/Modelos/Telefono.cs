using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace capa_datos.Modelos
{
    public class Telefono
    {
        [Key]
        public int idTelefono { get; set; }
        public int codigoEst { get; set; }
        public int numero { get; set; }
        public virtual Estudiante estudiante { get; set; }
    }
}
