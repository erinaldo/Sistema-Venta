using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistemaventa.Sistema_Venta;
using Sistemaventa.Class;

namespace Sistemaventa.Forms
{
    public partial class FormEditarEmpleado : Form
    {
        DateTime FechaRegistro;
        int ValorRol, ValorTema, EditarPress = 0;

        CodeRepeatClass repeatClass = new CodeRepeatClass();
        public static bool IsEditarActivo = false;
        public static Empleado objtEmpleado;
        private static FormEditarEmpleado ChilInstance = null;
        public static FormEditarEmpleado Instance()
        {
            if (ChilInstance == null || ChilInstance.IsDisposed == true)
            {
                ChilInstance = new FormEditarEmpleado();
            }
            ChilInstance.BringToFront();
            return ChilInstance;
        }
        public FormEditarEmpleado(Empleado empleado = null)
        {
            objtEmpleado = empleado;
            InitializeComponent();

            if (IsEditarActivo == true)
            {
                FnClearDatosModificar();    
            }
        }
        private void FnClearDatosModificar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtCelular.Clear();
            comboBoxSexo.SelectedIndex = 0;
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtUsuario.Clear();
            txtContraseñaAntigua.Clear();
            txtConfirmarContraseña.Clear();
            txtNuevaContraseña.Clear();
            checkBoxMostrar.Checked = false;
            searchRol.EditValue = null;
            comboBoxEstado.SelectedIndex = -1;
            pictureBoxFoto.Image = Properties.Resources.subir;
        }
        private void FnEnableDatos(bool v)
        {
            txtNombre.Enabled = v;
            txtApellido.Enabled = v;
            txtCedula.Enabled = v;
            txtCelular.Enabled = !v;
            comboBoxSexo.Enabled = !v;
            txtDireccion.Enabled = !v;
            txtCorreo.Enabled = !v;
            txtUsuario.Enabled = !v;
            txtContraseñaAntigua.Enabled = v;
            checkBoxMostrar.Enabled = !v;
            searchRol.Enabled = v;
            comboBoxEstado.Enabled = v;
            pictureBoxFoto.Enabled = !v;
        }

        private void FnEnablePassword(bool v)
        {
            txtNuevaContraseña.Enabled = v;
            txtConfirmarContraseña.Enabled = v;
        }
        private void FormEditarEmpleado_Load(object sender, EventArgs e)
        {
            pictureBoxFoto.AllowDrop = true;

            objtEmpleado = FormPrincipal.objtEmpleado;
            FnLlenarDatos();
            IsEditarActivo = true;
            FnEnableDatos(false);
            FnEnablePassword(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            IsEditarActivo = false;
        }

        private void checkBoxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            string NuevaContraseña = txtNuevaContraseña.Text;
            if (checkBoxMostrar.Checked)
            {
                txtNuevaContraseña.UseSystemPasswordChar = false;
                txtNuevaContraseña.Text = NuevaContraseña;
            }
            else
            {
                txtNuevaContraseña.UseSystemPasswordChar = true;
                txtNuevaContraseña.Text = NuevaContraseña;
            }
        }

        private void FormEditarEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsEditarActivo = false;
            e.Cancel = false;
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

        private void FnLlenarDatos()
        {
            if (xpEmpleado.Count == 0)
            {
                MessageBox.Show("Aún no hay registros", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtNombre.Text = FormPrincipal.objtEmpleado.Nombre;
                txtApellido.Text = FormPrincipal.objtEmpleado.Apellido;
                comboBoxSexo.Text = FormPrincipal.objtEmpleado.Sexo;
                txtCedula.Text = FormPrincipal.objtEmpleado.Cedula;
                txtCelular.Text = FormPrincipal.objtEmpleado.Celular;
                txtDireccion.Text = FormPrincipal.objtEmpleado.Direccion;
                txtCorreo.Text = FormPrincipal.objtEmpleado.Correo;
                txtUsuario.Text = FormPrincipal.objtEmpleado.NombreAcceso;
                txtContraseñaAntigua.Text = FormPrincipal.objtEmpleado.Contrasena;
                searchRol.EditValue = FormPrincipal.objtEmpleado.IdRol;

                ValorRol = FormPrincipal.objtEmpleado.IdRol.IdRol;
                ValorTema = FormPrincipal.objtEmpleado.IdTema.IdTema;

                if (FormPrincipal.objtEmpleado.Estado == true)
                {
                    comboBoxEstado.SelectedIndex = 0;
                }
                else
                {
                    comboBoxEstado.SelectedIndex = 1;
                }

                pictureBoxFoto.Image = repeatClass.ByteToImage(FormPrincipal.objtEmpleado.Foto);
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.SelectAll();
        }

        private void checkBoxCambiarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCambiarContraseña.Checked)
            {
                FnEnablePassword(true);
            }
            else
            {
                FnEnablePassword(false);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            EditarPress = 1;

            if (EditarPress == 1)
            {
                string texto = txtCorreo.Text;
                bool verificar = texto.Contains("@") && texto.Contains(".com");
                if (verificar == true)
                {
                    if( txtContraseñaAntigua.Text != txtConfirmarContraseña.Text)
                    {
                        MessageBox.Show("La antigua contraseña no es correcta, las contraseñas no coinciden", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtConfirmarContraseña.Focus();
                        EditarPress = 0;
                        return;
                    }
                    else if (txtNuevaContraseña.Text.Length > 20)
                    {
                        MessageBox.Show("La contraseña debe de tener 20 caracteres como maximo", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNuevaContraseña.Focus();
                        EditarPress = 0;
                        return;
                    }
                    else if (txtCelular.Text == "")
                    {
                        MessageBox.Show("Debes de agregar un número de celular", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCelular.Focus();
                        EditarPress = 0;
                        return;
                    }
                    else if (txtDireccion.Text == "")
                    {
                        MessageBox.Show("Debes de agregar la dirección del empleado", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDireccion.Focus();
                        return;
                    }
                    else if (txtCorreo.Text == "")
                    {
                        MessageBox.Show("Debes de agregar el correo del empleado", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCorreo.Focus();
                        EditarPress = 0;
                        return;
                    }
                    else if (txtUsuario.Text == "")
                    {
                        MessageBox.Show("Debes de agregar el login o acceso del empleado", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Focus();
                        EditarPress = 0;
                        return;
                    }
                    else
                    {
                        FnModifcarDatos();
                        if (MessageBox.Show("¿Desea modificar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FnModifcarDatos();

                            MessageBox.Show("Su registro se modifico correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show("El sistema se reiniciara para guardar los cambios en la base de datos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Restart();
                        }
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

        private void FnModifcarDatos()
        {
            objtEmpleado.Nombre = txtNombre.Text.Trim();
            objtEmpleado.Apellido = txtApellido.Text.Trim();
            objtEmpleado.Sexo = comboBoxSexo.Text;
            objtEmpleado.Cedula = txtCedula.Text;
            objtEmpleado.Celular = txtCelular.Text;
            objtEmpleado.Direccion = txtDireccion.Text;
            objtEmpleado.Correo = txtCorreo.Text.Trim();
            objtEmpleado.NombreAcceso = txtUsuario.Text;

            if (checkBoxCambiarContraseña.Checked)
            {
                objtEmpleado.Contrasena = txtNuevaContraseña.Text;
            }
            else
            {
                objtEmpleado.Contrasena = txtContraseñaAntigua.Text;
            }

            if (comboBoxEstado.SelectedIndex == 0)
            {
                objtEmpleado.Estado = true;
            }
            else
            {
                objtEmpleado.Estado = true;
            }

            objtEmpleado.IdRol.IdRol = ValorRol;
            objtEmpleado.IdTema.IdTema = ValorTema;

            objtEmpleado.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());
            objtEmpleado.Foto = repeatClass.ConvertImag(pictureBoxFoto);

            objtEmpleado.Save();
            objtEmpleado = SesionVenta.GetObjectByKey<Empleado>(objtEmpleado.Id);
            SesionVenta.CommitChanges();
            xpEmpleado.Reload();
        }
    }
}
