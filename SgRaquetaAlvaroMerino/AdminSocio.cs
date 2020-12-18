using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SgRaquetaAlvaroMerino
{
    public partial class AdminSocio : Form
    {
        public AdminSocio()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var dni = txtDni.Text.ToUpper().Trim();
            var email = txtEmail.Text.ToUpper().Trim();
            var nombre = txtNombre.Text.ToUpper().Trim();
            var apellidos = txtApellidos.Text.ToUpper().Trim();
            var domicilio = txtDomicilio.Text.ToUpper().Trim();
            var telefono = txtTelefono.Text.Trim();
            var cuenta = txtCuentaCorriente.Text.ToUpper().Trim();

            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                if (dni.Equals(string.Empty) || email.Equals(string.Empty) ||
                    nombre.Equals(string.Empty) || apellidos.Equals(string.Empty) ||
                    domicilio.Equals(string.Empty) || telefono.Equals(string.Empty) ||
                    cuenta.Equals(string.Empty))
                {
                    MessageBox.Show("No puede dejar campos vacios");
                }
                else
                {
                    //compruebo que no exista ningún socio con la misma clave primaria
                    bool existe = objBD.socios.Any(x => x.DNI.ToUpper().Equals(dni));
                    if (!existe)
                    {
                        //creamos el objeto socio
                        socios Socio = new socios(); ;
                        Socio.DNI = txtDni.Text;
                        Socio.email = txtEmail.Text;
                        Socio.nombre = txtNombre.Text;
                        Socio.apellidos = txtApellidos.Text;
                        Socio.domicilio = txtDomicilio.Text;
                        Socio.telefono = txtTelefono.Text;
                        Socio.cuentaCorriente = txtCuentaCorriente.Text;

                        //lo añadimos a la tabla, como nuevo registro
                        objBD.socios.Add(Socio);
                        //guardamos cambios
                        objBD.SaveChanges();
                        MessageBox.Show("Socio insertado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("El socio no se puede insertar ya que ya existe...","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {

                try
                {
                    var dni = txtDni.Text.ToUpper().Trim();
                    var email = txtEmail.Text.ToUpper().Trim();
                    var nombre = txtNombre.Text.ToUpper().Trim();
                    var apellidos = txtApellidos.Text.ToUpper().Trim();
                    var domicilio = txtDomicilio.Text.ToUpper().Trim();
                    var telefono = txtTelefono.Text.Trim();
                    var cuenta = txtCuentaCorriente.Text.ToUpper().Trim();

                    //compruebo que no exista ningun socio con el mismo DNI
                    bool existe = objBD.socios.Any(x => x.DNI.Equals(dni));

                    bool vacio = dni.Equals(string.Empty) || email.Equals(string.Empty) ||
                    nombre.Equals(string.Empty) || apellidos.Equals(string.Empty) ||
                    domicilio.Equals(string.Empty) || telefono.Equals(string.Empty) ||
                    cuenta.Equals(string.Empty);

                    //Recuperamos el objeto de la BD, filtrando por el campo categoria
                    if (!vacio && existe)
                    {
                        socios obSocio = objBD.socios.First(x => x.DNI.ToUpper().Equals(dni));
                        //Se añade el objeto a la tabla, para incluirlo como nuevo registro
                        obSocio.DNI = txtDni.Text;
                        obSocio.email = txtEmail.Text;
                        obSocio.nombre = txtNombre.Text;
                        obSocio.apellidos = txtApellidos.Text;
                        obSocio.domicilio = txtDomicilio.Text;
                        obSocio.telefono = txtTelefono.Text;
                        obSocio.cuentaCorriente = txtCuentaCorriente.Text;
                        //Se guardan los cambios
                        objBD.SaveChanges();
                        MessageBox.Show("Socio modificado correctamente");
                    }
                    else if (vacio)
                    {
                        MessageBox.Show("Alguno de los campos está vacio");
                    }
                    else if (!existe)
                    {
                        MessageBox.Show("El socio no existe");
                    }

                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("No existe numero de DNI");
                }

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {

                var dni = txtDni.Text.ToUpper().Trim();

                if (txtDni.Text.Equals(string.Empty))
                {
                    MessageBox.Show("El campo DNI no puede estar vacio");
                }
                else
                {
                    bool exists = objBD.socios.Any(x => x.DNI.ToUpper().Equals(dni));

                    if (exists)
                    {
                        exists = objBD.reservas.Any(x => x.socio.ToUpper().Equals(dni));

                        if (exists)
                        {
                            MessageBox.Show("El dni que has insertado del socio tiene alguna reserva");
                        }
                        else
                        {
                            //Recuperamo el objeto de la BD
                            socios obSocio = objBD.socios.First(x => x.DNI.ToUpper().Equals(dni));

                            //Eliminar objeto de la tabla, para quitarlo como registro
                            objBD.socios.Remove(obSocio);

                            //Se guardan los cambios
                            objBD.SaveChanges();
                            MessageBox.Show("Socio eliminado correctamente");
                        }
                    }

                    else
                    {
                        MessageBox.Show("No existe ese socio");
                    }
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                dgvSocios.DataSource = null;
                dgvSocios.Refresh();

                var consulta = from s in objBD.socios
                               orderby s.apellidos, s.nombre
                               select new
                               {
                                   IDENTIFICADOR = s.DNI,
                                   NOMBRE = s.nombre,
                                   APELLIDOS = s.apellidos,
                                   TELÉFONO = s.telefono,
                                   EMAIL = s.email
                               };

                dgvSocios.DataSource = consulta.ToList();
                dgvSocios.Refresh();
            }
        }
    }
}
