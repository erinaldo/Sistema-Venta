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
    public partial class FormCliente : Form
    {
        bool IsEditar = false;


        Cliente objtCliente;
        CodeRepeatClass repeatClass = new CodeRepeatClass();
        private static FormCliente ChilInstance = null;
        public static FormCliente Instance()
        {
            if (ChilInstance == null || ChilInstance.IsDisposed == true)
            {
                ChilInstance = new FormCliente();
            }
            ChilInstance.BringToFront();
            return ChilInstance;
        }
        public FormCliente()
        {
            InitializeComponent();
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
        private void FnEnableDatosGuardar(bool v)
        {
            txtNombre.Enabled = v;
            txtApellido.Enabled = v;
            comboBoxEstado.Enabled = v;
            txtDocumento.Enabled = v;
            txtCelular.Enabled = v;
            txtCorreo.Enabled = v;
            comboBoxEstado.Enabled = v;
        }
        private void FnClearDatosGuardar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            comboBoxEstado.SelectedIndex = 0;
            txtDocumento.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            comboBoxEstado.SelectedIndex = 0;
        }
        private bool FnValidarCamposVacio()
        {
            return (txtNombre.Text.Trim().Length == 0 || txtApellido.Text.Trim().Length == 0 || comboBoxSexo.SelectedIndex == -1 ||
                txtCelular.Text.Trim().Length == 0 || txtCorreo.Text.Trim().Length == 0 || comboBoxEstado.SelectedIndex == -1);
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
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IsEditar = false;
            FnClearDatosGuardar();
            FnEnableButton(true);
            FnEnableDatosGuardar(false);
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            comboBoxSexo.SelectedIndex = 0;
            comboBoxEstado.SelectedIndex = 0;

            var MensajeAyuda = new ToolTip();
            MensajeAyuda.SetToolTip(txtNombre, "Agrega el nombre del cliente");
            MensajeAyuda.SetToolTip(txtApellido, "Agrega el apellido del cliente");
            MensajeAyuda.SetToolTip(comboBoxSexo, "Agrega el sexo del cliente");
            MensajeAyuda.SetToolTip(txtDocumento, "Agrega el documento del cliente");
            MensajeAyuda.SetToolTip(txtCelular, "Agrega el celular del cliente");
            MensajeAyuda.SetToolTip(txtCorreo, "Agrega el correo del cliente");
            MensajeAyuda.SetToolTip(comboBoxEstado, "Agrega el estado del cliente");

            FnEnableButton(true);
            FnEnableDatosGuardar(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (IsEditar == true)
            {
                MessageBox.Show("Usted esta editando un registro", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FnValidarCamposVacio())
            {
                MessageBox.Show("Debe de llenar los campos vacios", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Cliente item in xpCliente)
            {
                if(item.DocumentoCLient == txtDocumento.Text)
                {
                    MessageBox.Show("Este número de documento ya existe", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string texto = txtCorreo.Text;
            bool verificar = texto.Contains("@") && texto.Contains(".com");
            if (verificar == true)
            {
                if (MessageBox.Show("¿Seguro desea guardar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objtCliente = new Cliente(SesionVenta);
                    objtCliente.NombreClient = txtNombre.Text;
                    objtCliente.ApellidoClient = txtApellido.Text;
                    objtCliente.SexoClient = comboBoxSexo.Text;
                    objtCliente.CorreoClient = txtCorreo.Text;
                    objtCliente.DocumentoCLient = txtDocumento.Text;
                    objtCliente.CelularClient = txtCelular.Text;
                    objtCliente.Estado = comboBoxEstado.Text;

                    objtCliente.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

                    objtCliente.Save();
                    SesionVenta.CommitChanges();
                    MessageBox.Show("Su registro se guardo correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xpCliente.Reload();
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

        private void gridViewCliente_DoubleClick(object sender, EventArgs e)
        {
            if (xpCliente.Count == 0)
            {
                MessageBox.Show("No existe ningún registro", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IsEditar = true;

            objtCliente = (Cliente)gridViewCliente.GetFocusedRow();
            txtNombre.Text = objtCliente.NombreClient;
            txtApellido.Text = objtCliente.ApellidoClient;
            txtCorreo.Text = objtCliente.CorreoClient;
            txtDocumento.Text = objtCliente.DocumentoCLient;
            txtCelular.Text = objtCliente.CelularClient;
            comboBoxEstado.Text = objtCliente.Estado;
            FnEnableDatosGuardar(true);
            txtNombre.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (IsEditar == false)
            {
                MessageBox.Show("Debes de seleccionar un registro de la tabla", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Seguro desea modificar su registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtCliente = (Cliente)gridViewCliente.GetFocusedRow();

                objtCliente.NombreClient = txtNombre.Text;
                objtCliente.ApellidoClient = txtApellido.Text;
                objtCliente.SexoClient = comboBoxSexo.Text;
                objtCliente.CorreoClient = txtCorreo.Text;
                objtCliente.DocumentoCLient = txtDocumento.Text;
                objtCliente.CelularClient = txtCelular.Text;
                objtCliente.Estado = comboBoxEstado.Text;

                objtCliente.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

                objtCliente.Save();
                SesionVenta.CommitChanges();
                MessageBox.Show("Su registro se modifico correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpCliente.Reload();
                FnClearDatosGuardar();
                FnEnableButton(true);
                FnEnableDatosGuardar(false);
            }
        }

        private void txtNombre_Enter_1(object sender, EventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.SelectAll();
        }

        private void txtCelular_Enter(object sender, EventArgs e)
        {
            MaskedTextBox texto = (MaskedTextBox)sender;
            texto.SelectAll();
        }
    }
}
