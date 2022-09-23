using Sistemaventa.Sistema_Venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistemaventa.Class;
using Sistemaventa.Validations;

namespace Sistemaventa.Forms
{
    public partial class FormEmpleado : Form
    {
        DateTime FechaRegistro;
        int ValorRol, ValorTema;
        bool IsEditar = false;

        CodeRepeatClass repeatClass = new CodeRepeatClass();

        Empleado objtEmpleado;
        private static FormEmpleado ChilInstance = null;
        public static FormEmpleado Instance()
        {
            if (ChilInstance == null || ChilInstance.IsDisposed == true)
            {
                ChilInstance = new FormEmpleado();
            }
            ChilInstance.BringToFront();
            return ChilInstance;
        }
        public FormEmpleado()
        {
            InitializeComponent();
        }
        private void FnClearDatosGuardar()
        {
            txtCedula.Clear();
            txtCelular.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            comboBoxSexo.SelectedIndex = 0;
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            searchRol.EditValue = null;
            comboBoxEstado.SelectedIndex = 0;
            pictureBoxFoto.Image = Properties.Resources.subir;
            checkBoxMostrar.Checked = false;
        }
        private void FnEnableDatosGuardar(bool v)
        {
            txtCedula.Enabled = v;
            txtCelular.Enabled = v;
            txtNombre.Enabled = v;
            txtApellido.Enabled = v;
            comboBoxSexo.Enabled = v;
            txtDireccion.Enabled = v;
            txtCorreo.Enabled = v;
            txtUsuario.Enabled = v;
            txtContraseña.Enabled = v;
            searchRol.Enabled = v;
            comboBoxEstado.Enabled = v;
            pictureBoxFoto.Enabled = v;
            checkBoxMostrar.Enabled = v;
        }
        private void FnEnableModificar(bool v)
        {
            searchRol.Enabled = v;
            comboBoxEstado.Enabled = v;
        }
        private void FnEnableButton(bool v)
        {
            btnNuevo.Enabled = v;
            btnGuardar.Enabled = !v;
            btnModificar.Enabled = v;
        }
        private void FnEnableCancelar(bool v)
        {
            btnCancelar.Enabled = v;
        }
        private bool FnValidarCamposVacios()
        {
            return (txtNombre.Text.Trim().Length == 0 || txtApellido.Text.Trim().Length == 0 ||
                txtCorreo.Text.Trim().Length == 0 || txtCelular.Text.Trim().Length == 0 ||
                txtCedula.Text.Trim().Length == 0 || searchRol.EditValue == null ||
                txtUsuario.Text.Trim().Length == 0 || txtContraseña.Text.Trim().Length == 0);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (IsEditar == true)
            {
                FnClearDatosGuardar();
                IsEditar = false;
            }
            FnEnableButton(false);
            FnEnableDatosGuardar(true);
            FnEnableCancelar(true);
            txtCedula.Focus();
        }
        private void FnLoadRoles()
        {
            foreach (Rol rol in xpRol)
            {
                rol.Reload();
            }
        }
        private void FnLoadEmpleado()
        {
            foreach (Empleado person in xpEmpleado)
            {
                person.Reload();
            }
        }
        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            pictureBoxFoto.AllowDrop = true;

            var MensajeAyuda = new ToolTip();
            MensajeAyuda.SetToolTip(txtNombre, "Agrega el nombre del registro");
            MensajeAyuda.SetToolTip(txtApellido, "Agrega el apellido del registro");
            MensajeAyuda.SetToolTip(txtCorreo, "Agrega el correo del registro");
            MensajeAyuda.SetToolTip(searchRol, "Permite seleccinar el Rol");
            MensajeAyuda.SetToolTip(comboBoxEstado, "Permite seleccinar el estado del Usuario");
            MensajeAyuda.SetToolTip(txtDireccion, "Agrega la dirección del registro");
            MensajeAyuda.SetToolTip(txtUsuario, "Agrega el acceso del usuario");
            MensajeAyuda.SetToolTip(txtContraseña, "Agrega la contraseña del usuario");
            MensajeAyuda.SetToolTip(checkBoxMostrar, "Muestra la contraseña del usuario");
            MensajeAyuda.SetToolTip(txtCedula, "Agrega el cedula de identidad del registro");
            MensajeAyuda.SetToolTip(txtCelular, "Agrega el celular del registro");
            MensajeAyuda.SetToolTip(btnNuevo, "Crea un nuevo registro");
            MensajeAyuda.SetToolTip(btnGuardar, "Guarda el registro");
            MensajeAyuda.SetToolTip(btnModificar, "Modifica el registro");
            MensajeAyuda.SetToolTip(btnCancelar, "Cancela cualquier opción que haya realizado");
            MensajeAyuda.SetToolTip(pictureBoxFoto, "Agrega la foto para el perfil, puedes arrastrar y soltar");

            FnEnableButton(true);
            FnEnableDatosGuardar(false);
            FnEnableCancelar(true);
            FnClearDatosGuardar();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IsEditar = false;
            FnEnableButton(true);
            FnClearDatosGuardar();
            FnEnableDatosGuardar(false);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(IsEditar == false)
            {
                MessageBox.Show("Debes de seleccionar una registro de la tabla", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FnValidarCamposVacios())
            {
                MessageBox.Show("Debes llenar todos los campos vacíos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Seguro desea modificar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtEmpleado = (Empleado)gridViewEmpleado.GetFocusedRow();

                objtEmpleado.Nombre = txtNombre.Text.Trim();
                objtEmpleado.Apellido = txtApellido.Text.Trim();
                objtEmpleado.Sexo = comboBoxSexo.Text;
                objtEmpleado.Cedula = txtCedula.Text;
                objtEmpleado.Celular = txtCelular.Text;
                objtEmpleado.Direccion = txtDireccion.Text;
                objtEmpleado.Correo = txtCorreo.Text.Trim();
                objtEmpleado.NombreAcceso = txtUsuario.Text;

                objtEmpleado.Contrasena = txtContraseña.Text;

                if (searchRol.EditValue == null || Convert.ToInt32(searchRol.EditValue) != ValorRol)
                {
                    objtEmpleado.IdRol = (Rol)searchViewRol.GetFocusedRow();
                }
                else
                {
                    objtEmpleado.IdRol.IdRol = ValorRol;
                }

                if (comboBoxEstado.SelectedIndex == 0)
                {
                    objtEmpleado.Estado = true;
                }
                else
                {
                    objtEmpleado.Estado = false;
                }

                foreach (Tema item in xpTema)
                {
                    int ValorId = 1;
                    if (item.IdTema == ValorId)
                    {
                        objtEmpleado.IdTema = item;
                    }
                }

                objtEmpleado.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());
                objtEmpleado.Foto = repeatClass.ConvertImag(pictureBoxFoto);

                objtEmpleado.Save();
                SesionVenta.CommitChanges();
                MessageBox.Show("Su registro se edito correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpEmpleado.Reload();
                FnEnableButton(true);
                FnEnableModificar(false);
                FnEnableCancelar(true);
                FnClearDatosGuardar();
                IsEditar = false;
            }
        }

        private void searchRol_EditValueChanged(object sender, EventArgs e)
        {
            if (xpRol.Count == 0)
            {
                MessageBox.Show("Aún no hay registros", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            MaskedTextBox texto = (MaskedTextBox)sender;
            texto.SelectAll();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.SelectAll();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (Empleado item in xpEmpleado)
            {
                if (txtCedula.Text == item.Cedula)
                {
                    MessageBox.Show("Esta cedula de identidad esta en la base de datos, ingrese una cedula que no este en la base de datos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCedula.Focus();
                    return;
                }
            }
            if(FnValidarCamposVacios())
            {
                MessageBox.Show("Debes llenar todos los campos vacíos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string texto = txtCorreo.Text;
                bool verificar = texto.Contains("@") && texto.Contains(".com");
                if (verificar == true)
                {
                    if (MessageBox.Show("¿Seguro desea guardar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objtEmpleado = new Empleado(SesionVenta);

                        objtEmpleado.Nombre = txtNombre.Text.Trim();
                        objtEmpleado.Apellido = txtApellido.Text.Trim();
                        objtEmpleado.Sexo = comboBoxSexo.Text;
                        objtEmpleado.Cedula = txtCedula.Text;
                        objtEmpleado.Celular = txtCelular.Text;
                        objtEmpleado.Direccion = txtDireccion.Text;
                        objtEmpleado.Correo = txtCorreo.Text.Trim();
                        objtEmpleado.NombreAcceso = txtUsuario.Text;

                        objtEmpleado.Contrasena = txtContraseña.Text;

                        objtEmpleado.IdRol = (Rol)searchViewRol.GetFocusedRow();

                        if (comboBoxEstado.SelectedIndex == 0)
                        {
                            objtEmpleado.Estado = true;
                        }
                        else
                        {
                            objtEmpleado.Estado = true;
                        }

                        foreach (Tema item in xpTema)
                        {
                            int ValorId = 1;
                            if (item.IdTema == ValorId)
                            {
                                objtEmpleado.IdTema = item;
                            }
                        }

                        objtEmpleado.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());
                        objtEmpleado.Foto = repeatClass.ConvertImag(pictureBoxFoto);

                        objtEmpleado.Save();
                        SesionVenta.CommitChanges();
                        MessageBox.Show("Su registro se guardo correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        xpEmpleado.Reload();
                        FnClearDatosGuardar();
                        FnEnableButton(true);
                        FnEnableDatosGuardar(false);
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

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FnLoadRoles();
            FnLoadEmpleado();
        }

        private void FormEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                FnLoadEmpleado();
                FnLoadRoles();
            }
        }

        private void gridViewEmpleado_DoubleClick(object sender, EventArgs e)
        {
            FnClearDatosGuardar();

            if (xpEmpleado.Count == 0)
            {
                MessageBox.Show("Aún no existe ningún registro, debes de agregar registros", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IsEditar = true;

            objtEmpleado = (Empleado)gridViewEmpleado.GetFocusedRow();
            txtNombre.Text = objtEmpleado.Nombre;
            txtApellido.Text = objtEmpleado.Apellido;
            comboBoxEstado.Text = objtEmpleado.Sexo;
            txtCorreo.Text = objtEmpleado.Correo;
            txtCelular.Text = objtEmpleado.Celular;
            txtDireccion.Text = objtEmpleado.Direccion;
            txtCedula.Text = objtEmpleado.Cedula;
            txtUsuario.Text = objtEmpleado.NombreAcceso;

            txtContraseña.Text = objtEmpleado.Contrasena;

            comboBoxSexo.Text = objtEmpleado.Sexo;
            if (objtEmpleado.Estado == true)
            {
                comboBoxEstado.SelectedIndex = 0;
            }
            else if (objtEmpleado.Estado == false)
            {
                comboBoxEstado.SelectedIndex = 1;
            }

            searchRol.EditValue = objtEmpleado.IdRol.IdRol;
            ValorRol = objtEmpleado.IdRol.IdRol;

            ValorTema = objtEmpleado.IdTema.IdTema;

            FechaRegistro = objtEmpleado.FechaRegistro;

            pictureBoxFoto.Image = repeatClass.ByteToImage(objtEmpleado.Foto);

            FnEnableModificar(true);
            FnEnableButton(true);
            txtCedula.Focus();
        }
    }
}
