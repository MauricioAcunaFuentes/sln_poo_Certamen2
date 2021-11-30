using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEmpleado.Models
{
    public class Empleado
    {
        //prop
        public string rut { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
    }
}