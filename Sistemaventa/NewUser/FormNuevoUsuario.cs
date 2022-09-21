using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo.DB;
using Sistemaventa.Class;
using Sistemaventa.Sistema_Venta;
using Sistemaventa.Validations;

namespace Sistemaventa.NewUser
{
    public partial class FormNuevoUsuario : Form
    {
        CodeRepeatClass repeatClass = new CodeRepeatClass();

        bool IsValorEstado = true;
        public FormNuevoUsuario()
        {
            InitializeComponent();
        }
        private void checkBoxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            string Contraseña = txtContraseña.Text;
            if (checkBoxMostrar.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
                txtContraseña.Text = Contraseña;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
                txtContraseña.Text = Contraseña;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            TextBox Text = (TextBox)sender;
            Text.SelectAll();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                MessageBox.Show("Debes de agregar su número de cedula de identidad", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCedula.Focus();
                return;
            }
            else if (txtCelular.Text == "")
            {
                MessageBox.Show("Debes de agregar su número de celular", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCelular.Focus();
                return;
            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("Debes de agregar su primer nombre", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            else if (txtApellido.Text == "")
            {
                MessageBox.Show("Debes de agregar su primer apellido", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return;
            }
            else if (comboBoxSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Debes de seleccionar el tipo de sexo", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxSexo.Focus();
                return;
            }
            else if (txtDireccion.Text == "")
            {
                MessageBox.Show("Debes de agregar la dirección", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDireccion.Focus();
                return;
            }
            else if (txtCorreo.Text == "")
            {
                MessageBox.Show("Debes de agregar el correo", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
                return;
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debes de agregar el acceso(login)", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return;
            }
            else if (txtContraseña.Text == "")
            {
                MessageBox.Show("Debes de agregar tu contraseña", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
                return;
            }
            else if (pictureBoxFoto == null)
            {
                MessageBox.Show("Debes de agregar una foto o imagen que te haga representación", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBoxFoto.Focus();
                return;
            }
            else
            {
                string Correo = txtCorreo.Text;
                bool verificar = Correo.Contains("@") && Correo.Contains(".com");
                if(verificar == true)
                {
                    if (MessageBox.Show("¿Seguro desea guardar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Empleado objEmpleado = new Empleado(SesionVenta);
                        objEmpleado.Nombre = txtNombre.Text;
                        objEmpleado.Apellido = txtApellido.Text;
                        objEmpleado.Sexo = comboBoxSexo.Text;
                        objEmpleado.Correo = txtCorreo.Text;
                        objEmpleado.Direccion = txtDireccion.Text;
                        objEmpleado.Celular = txtCelular.Text;
                        objEmpleado.Cedula = txtCedula.Text;
                        objEmpleado.NombreAcceso = txtUsuario.Text;

                        objEmpleado.Contrasena = txtContraseña.Text;

                        objEmpleado.Foto = repeatClass.ConvertImag(pictureBoxFoto);

                        foreach (Rol item in xpRol)
                        {
                            if (item.IdRol != 0)
                            {
                                objEmpleado.IdRol = item;
                            }
                        }
                        bool IsValorEstado = true;
                        objEmpleado.Estado = IsValorEstado;

                        foreach (Tema item in xpTema)
                        {
                            int ValorId = 1;
                            if (item.IdTema == ValorId)
                            {
                                objEmpleado.IdTema = item;
                            }
                        }
                        objEmpleado.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

                        objEmpleado.Save();
                        SesionVenta.CommitChanges();
                        MessageBox.Show("Su registro se guardo correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        xpEmpleado.Reload();
                        MessageBox.Show("El sistema se reiniciara, para guardar cambios", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("El correo que desea guardar no es valido" + " \r\n" + " \r\n" + " \r\n" + "Le falta @ o .com", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCorreo.Focus();
                    return;
                }
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                MessageBox.Show("No se permite espacio", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCedula.Clear();
                txtCedula.Focus();
                return;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                MessageBox.Show("No se permite espacio", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCelular.Clear();
                txtCelular.Focus();
                return;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                MessageBox.Show("No se permite espacio", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Clear();
                txtCorreo.Focus();
                return;
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                MessageBox.Show("No se permite espacio", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtNombre.Focus();
                return;
            }
            ClassValidations.LettersValidation(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                MessageBox.Show("No se permite espacio", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Text = "";
                txtApellido.Focus();
                return;
            }
            ClassValidations.LettersValidation(e);
        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {
            repeatClass.FnAbrirImangen(pictureBoxFoto);
        }

        private void pictureBoxFoto_DragDrop(object sender, DragEventArgs e)
        {
            repeatClass.FnDragDropPictureBox(sender, e, pictureBoxFoto);
        }

        private void pictureBoxFoto_DragEnter(object sender, DragEventArgs e)
        {
            repeatClass.FnCopyPictureBox(sender, e);
        }

        private void FormNuevoUsuario_Load(object sender, EventArgs e)
        {
            pictureBoxFoto.AllowDrop = true;
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            MaskedTextBox Text = (MaskedTextBox)sender;
            Text.SelectAll();
        }
    }
}
