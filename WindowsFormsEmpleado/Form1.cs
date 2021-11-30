using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpleadoLibrary;
namespace WindowsFormsEmpleado
{
    public partial class Form1 : Form
    {
        empleadoEntity empleado = new empleadoEntity();
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                empleado.Rut = tx_rut.Text;
                empleado.Nombre = tx_nombre.Text;
                empleado.Apellido = tx_apellido.Text;
                empleado.Email = tx_email.Text;
                empleado.Telefono = tx_telefono.Text;
                tx_rut.ForeColor = Color.Black;

                int cantidad = empleado.buscaExiste();

                if (cantidad == 0)
                {
                    int resultado = empleado.guardar(empleado);

                    //''''''

                    if (resultado == 1)
                    {
                        MessageBox.Show("Empleado Guardado", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        empleado.Rut = "";
                        empleado.Nombre = "";
                        empleado.Apellido = "";
                        empleado.Email = "";
                        empleado.Telefono = "";
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    tx_rut.ForeColor = Color.Red;
                    MessageBox.Show("El RUT ingresado ya existe en la base de datos", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
        }
    }
}
