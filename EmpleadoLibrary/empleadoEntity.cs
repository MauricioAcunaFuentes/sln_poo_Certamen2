using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EmpleadoLibrary
{
    public class empleadoEntity
    {
        private string rut;
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;

        Datos data = new Datos();

        //ctor
        public empleadoEntity(string rut, string nombre, string apellido, string email, string telefono)
        {
            this.rut=rut;
            this.nombre= nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
        }
        //sobrecarga de metodo constructor
        public empleadoEntity()
        {

        }

        //metodos
        public DataSet listadoempleados()
        {
            return data.listado("select * from empleado");
        }
        public DataSet listadoempleados(string rut)
        {
            return data.listado("select * from empleado where rut='" + rut + "'");
        }
        public int buscaExiste()
        {
            return Convert.ToInt32(data.listado("select count(*) cantidad from empleado where rut='" + this.rut + "'").Tables[0].Rows[0].ItemArray[0]);
        }

        public int guardar(empleadoEntity empleado)
        {
            return data.ejecutar("insert into empleado(rut,nombre,apellido,mail,telefono) values('" + empleado.rut + "','" + empleado.nombre + "','" + empleado.apellido + "','" + empleado.email + "','" + empleado.telefono + "')");
        }
        public int guardar()
        {
            return data.ejecutar("Insert into empleado(rut, nombre, apellido,mail, telefono) values('" + this.rut + "','" + this.nombre + "','" + this.apellido + "','" + this.email + "','" + this.telefono + "')");
        }
        public int eliminar()
        {
            return data.ejecutar("DELETE FROM empleado WHERE RUT= '" + this.rut + "'");
        }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}

