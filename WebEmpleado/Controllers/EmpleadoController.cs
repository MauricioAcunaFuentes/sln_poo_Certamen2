using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmpleadoLibrary;
using WebEmpleado.Models;
using System.Data;

namespace WebEmpleado.Controllers
{
    public class EmpleadoController : ApiController
    {
        [HttpGet]
        [Route("api/v1/Empleado")]
        public respuesta listar(string rut = "")
        {

            respuesta resp = new respuesta();
            try
            {
                List<Empleado> listado = new List<Empleado>();
                empleadoEntity empleadoData = new empleadoEntity();
                DataSet data = rut == "" ? empleadoData.listadoempleados() : empleadoData.listadoempleados(rut); 

                for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                {
                    Empleado item = new Empleado();
                    item.rut = data.Tables[0].Rows[i].ItemArray[0].ToString();
                    item.nombre = data.Tables[0].Rows[i].ItemArray[1].ToString();
                    item.apellido = data.Tables[0].Rows[i].ItemArray[2].ToString();
                    item.email = data.Tables[0].Rows[i].ItemArray[3].ToString();
                    item.telefono = data.Tables[0].Rows[i].ItemArray[4].ToString();
                    listado.Add(item);
                }
                //operacion correcta 
                resp.error = false;
                resp.mensaje = "ok";
                if (listado.Count > 0)
                    resp.data = listado;
                else
                    resp.data = "No se encontro empleado";
                return resp;
            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = "Error:" + e.Message;
                resp.data = null;
                return resp;
            }
        }

        [HttpPost]
        [Route("api/v1/setempleado")]
        public respuesta guardar(Empleado empleado)
        {
            respuesta resp = new respuesta();
            try
            {
                empleadoEntity empl = new empleadoEntity(empleado.rut, empleado.nombre, empleado.apellido, empleado.email, empleado.telefono);
                int estado = empl.guardar();

                if (estado == 1)
                {
                    resp.error = false;
                    resp.mensaje = "empleado ingresado";
                    resp.data = empleado;
                }
                else
                {
                    resp.error = true;
                    resp.mensaje = "No se realizo el ingreso";
                    resp.data = null;
                }
                return resp;
            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = "Error:" + e.Message;
                resp.data = null;
                return resp;
            }
        }

        [HttpDelete]
        [Route("api/v1/deleteempleado")]
        public respuesta eliminar(string rut)
        {
            respuesta resp = new respuesta();
            try
            {

                empleadoEntity empl = new empleadoEntity();
                empl.Rut = rut;
                int estado = empl.eliminar();

                if (estado == 1)
                {
                    resp.error = false;
                    resp.mensaje = "empleado eliminado";
                    resp.data = null;
                }
                else
                {
                    resp.error = true;
                    resp.mensaje = "No se realizo la eliminacion";
                    resp.data = null;
                }
                return resp;
            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = "Error:" + e.Message;
                resp.data = null;
                return resp;
            }
        }
    }
}