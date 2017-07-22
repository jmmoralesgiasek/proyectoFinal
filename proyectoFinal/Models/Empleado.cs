using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectoFinal.Models
{
    public class Empleado
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string domicilio { get; set; }
        public int edad { get; set; }
        public string ciudad { get; set; }
        public string estado { get; set; }
        public string id_departamento { get; set; }
    }

}