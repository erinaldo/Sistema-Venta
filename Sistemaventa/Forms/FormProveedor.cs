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
using Sistemaventa.Validations;

namespace Sistemaventa.Forms
{
    public partial class FormProveedor : Form
    {
        DateTime FechaRegistro;
        bool IsEditar = false;

        CodeRepeatClass repeatClass = new CodeRepeatClass();

        Proveedor objtProveedor;

        private static FormProveedor ChilInstance = null;
        public static FormProveedor Instance()
        {
            if (ChilInstance == null || ChilInstance.IsDisposed == true)
            {
                ChilInstance = new FormProveedor();
            }
            ChilInstance.BringToFront();
            return ChilInstance;
        }
        public FormProveedor()
        {
            InitializeComponent();
        }
        private void FnEnableDatosGuardar(bool v)
        {
            txtNombre.Enabled = v;
            txtDocumento.Enabled = v;
            txtRazonSocial.Enabled = v;
            txtTelefono.Enabled = v;
            txtCorreo.Enabled = v;
            txtDireccion.Enabled = v;
            comboBoxEstado.Enabled = v;
            pictureBoxLogo.Enabled = v;
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
        private void FnClearDatosGuardar()
        {
            txtNombre.Clear();
            txtDocumento.Clear();
            txtRazonSocial.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            comboBoxEstado.SelectedIndex = 0;
            pictureBoxLogo.Image = Properties.Resources.subir;
        }
        private bool FnValidarCamposVacios()
        {
            return ( txtNombre.Text.Trim().Length == 0 || txtDocumento.Text.Trim().Length == 0 || txtRazonSocial.Text.Trim().Length == 0 ||
                txtTelefono.Text.Trim().Length == 0 || txtCorreo.Text.Trim().Length == 0 || txtDireccion.Text.Trim().Length == 0);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if(IsEditar == true)
            {
                FnClearDatosGuardar();
                IsEditar = false;
            }

            FnEnableButton(false);
            FnEnableDatosGuardar(true);
            FnEnableCancelar(true);
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(IsEditar == true)
            {
                IsEditar = false;
            }

            FnEnableButton(true);
            FnClearDatosGuardar();
            FnEnableDatosGuardar(false);
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            pictureBoxLogo.AllowDrop = true;

            var MensajeAyuda = new ToolTip();
            MensajeAyuda.SetToolTip(txtNombre, "Agrega el nombre del registro");
            MensajeAyuda.SetToolTip(txtDocumento, "Agrega el documento del registro");
            MensajeAyuda.SetToolTip(txtRazonSocial, "Agrega la razón social del proveedor");
            MensajeAyuda.SetToolTip(txtTelefono, "Agrega el teléfono del proveedor");
            MensajeAyuda.SetToolTip(txtCorreo, "Agrega el correo del registro");
            MensajeAyuda.SetToolTip(txtDireccion, "Agrega la dirección del registro");
            MensajeAyuda.SetToolTip(comboBoxEstado, "Permite seleccinar el estado del Usuario");
            MensajeAyuda.SetToolTip(btnNuevo, "Crea un nuevo registro");
            MensajeAyuda.SetToolTip(btnGuardar, "Guarda el registro");
            MensajeAyuda.SetToolTip(btnModificar, "Modifica el registro");
            MensajeAyuda.SetToolTip(btnCancelar, "Cancela cualquier opción que haya realizado");
            MensajeAyuda.SetToolTip(pictureBoxLogo, "Agrega la foto para el perfil, puedes arrastrar y soltar");

            FnEnableButton(true);
            FnEnableDatosGuardar(false);
            FnEnableCancelar(true);
            FnClearDatosGuardar();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            repeatClass.FnAbrirImangen(pictureBoxLogo);
        }

        private void pictureBoxLogo_DragDrop(object sender, DragEventArgs e)
        {
            repeatClass.FnDragDropPictureBox(sender, e, pictureBoxLogo);
        }

        private void pictureBoxLogo_DragEnter(object sender, DragEventArgs e)
        {
            repeatClass.FnCopyPictureBox(sender, e);
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassValidations.NumberValidation(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassValidations.LettersValidation(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(FnValidarCamposVacios())
            {
                MessageBox.Show("Debes de llenar todos los campos vacios", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string texto = txtCorreo.Text;
            bool verificar = texto.Contains("@") && texto.Contains(".com");
            if (verificar == true)
            {
                if (MessageBox.Show("¿Seguro desea guardar el registro?", repeatClass.Mensaje,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objtProveedor = new Proveedor(SesionVenta);
                    objtProveedor.NombreProv = txtNombre.Text.Trim();
                    objtProveedor.Direccion = txtDireccion.Text;
                    objtProveedor.DocumentoProv = txtDocumento.Text.Trim();
                    objtProveedor.RazonSocialProv = txtRazonSocial.Text;
                    objtProveedor.CorreoProv = txtCorreo.Text.Trim();
                    objtProveedor.TelefonoProv = txtTelefono.Text;
                    objtProveedor.EstadoProv = comboBoxEstado.Text;

                    objtProveedor.Logotipo = repeatClass.ConvertImag(pictureBoxLogo);
                    objtProveedor.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

                    objtProveedor.Save();
                    SesionVenta.CommitChanges();
                    MessageBox.Show("Su registro se guardo correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xpProveedor.Reload();
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

        private void gridViewProveedor_DoubleClick(object sender, EventArgs e)
        {
            FnClearDatosGuardar();

            if(xpProveedor.Count == 0)
            {
                MessageBox.Show("Aún no existe ningún registro, debes de agregar registros", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IsEditar = true;

            objtProveedor = (Proveedor)gridViewProveedor.GetFocusedRow();

            txtNombre.Text = objtProveedor.NombreProv;
            txtDocumento.Text = objtProveedor.DocumentoProv;
            txtRazonSocial.Text = objtProveedor.RazonSocialProv;
            txtTelefono.Text = objtProveedor.TelefonoProv;
            txtCorreo.Text = objtProveedor.CorreoProv;
            txtDireccion.Text = objtProveedor.Direccion;
            comboBoxEstado.Text = objtProveedor.EstadoProv;

            pictureBoxLogo.Image = repeatClass.ByteToImage(objtProveedor.Logotipo);

            FnEnableDatosGuardar(true);
            FnEnableButton(true);
            txtNombre.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (IsEditar == false)
            {
                MessageBox.Show("Debes de seleccionar un registro de la tabla", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FnValidarCamposVacios())
            {
                MessageBox.Show("Debes de llenar todos los campos vacios", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string texto = txtCorreo.Text;
            bool verificar = texto.Contains("@") && texto.Contains(".com");
            if (verificar == true)
            {
                if (MessageBox.Show("¿Seguro desea editar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objtProveedor = (Proveedor)gridViewProveedor.GetFocusedRow();
                    objtProveedor.NombreProv = txtNombre.Text.Trim();
                    objtProveedor.Direccion = txtDireccion.Text;
                    objtProveedor.DocumentoProv = txtDocumento.Text.Trim();
                    objtProveedor.RazonSocialProv = txtRazonSocial.Text;
                    objtProveedor.CorreoProv = txtCorreo.Text.Trim();
                    objtProveedor.TelefonoProv = txtTelefono.Text;
                    objtProveedor.EstadoProv = comboBoxEstado.Text;

                    objtProveedor.Logotipo = repeatClass.ConvertImag(pictureBoxLogo);
                    objtProveedor.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

                    objtProveedor.Save();
                    SesionVenta.CommitChanges();
                    MessageBox.Show("Su registro se edito correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xpProveedor.Reload();
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
}
