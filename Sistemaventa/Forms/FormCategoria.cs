using Sistemaventa.Class;
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
using Sistemaventa.Validations;

namespace Sistemaventa.Forms
{
    public partial class FormCategoria : Form
    {
        bool IsEditar = false;
        DateTime dateFechaRegistro;

        Categoria objtCategoria;
        CodeRepeatClass repeatClass = new CodeRepeatClass();
        private static FormCategoria ChilInstance = null;
        public static FormCategoria Instance()
        {
            if (ChilInstance == null || ChilInstance.IsDisposed == true)
            {
                ChilInstance = new FormCategoria();
            }
            ChilInstance.BringToFront();
            return ChilInstance;
        }
        public FormCategoria()
        {
            InitializeComponent();
        }
        private void FnClearDatos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            comboBoxEstado.SelectedIndex = 0;
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
            comboBoxEstado.SelectedIndex = 0;
            var MensajeAyuda = new ToolTip();
            MensajeAyuda.SetToolTip(txtNombre, "Agrega el nombre de la Categoria");
            MensajeAyuda.SetToolTip(txtDescripcion, "Agrega el descripción de la Categoria");
            MensajeAyuda.SetToolTip(comboBoxEstado, "Agrega el estado de la Categoria");
            MensajeAyuda.SetToolTip(btnGuardar, "Nos permite guardar el registro Categoria");
            MensajeAyuda.SetToolTip(btnModificar, "Nos permite modificar el registro Categoria");
            MensajeAyuda.SetToolTip(btnCancelar, "Nos permite cancelar cualquier acción que se haya realizado");
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.SelectAll();
        }
        private bool FnValidarCamposVacios()
        {

            return (txtNombre.Text.Trim().Length == 0 || txtDescripcion.Text.Trim().Length == 0);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (IsEditar == true)
            {
                MessageBox.Show("Usted esta editando una categoria", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Categoria item in xpCategoria)
            {
                if (item.NombreCateg.Trim().ToLower() == txtNombre.Text.Trim().ToLower())
                {
                    MessageBox.Show("El Nombre ya existe en la base de datos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                    return;
                }
            }

            if (FnValidarCamposVacios())
            {
                MessageBox.Show("Debes de llenar todos los campos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Seguro desea guardar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtCategoria = new Categoria(SesionVenta);
                objtCategoria.NombreCateg = txtNombre.Text;
                objtCategoria.Descripcion = txtDescripcion.Text;
                objtCategoria.Estado = comboBoxEstado.Text;

                objtCategoria.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

                objtCategoria.Save();
                SesionVenta.CommitChanges();
                MessageBox.Show("Su registro se guardo correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpCategoria.Reload();
                FnClearDatos();
                txtNombre.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (IsEditar == false)
            {
                MessageBox.Show("Debes de seleccionar un registro de la tabla de registro", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FnValidarCamposVacios())
            {
                MessageBox.Show("Debes de llenar todos los campos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Seguro desea modificar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtCategoria = (Categoria)gridViewCategoria.GetFocusedRow();

                objtCategoria.NombreCateg = txtNombre.Text;
                objtCategoria.Descripcion = txtDescripcion.Text;
                objtCategoria.Estado = comboBoxEstado.Text;

                objtCategoria.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

                objtCategoria.Save();
                SesionVenta.CommitChanges();
                MessageBox.Show("Su registro se modifico correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpCategoria.Reload();
                FnClearDatos();
                IsEditar = false;
                txtNombre.Focus();
            }
        }

        private void gridViewCategoria_DoubleClick(object sender, EventArgs e)
        {
            if (xpCategoria.Count == 0)
            {
                MessageBox.Show("Aún no hay registro, debes de agregar uno para editarlo", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IsEditar = true;

            objtCategoria = (Categoria)gridViewCategoria.GetFocusedRow();

            txtNombre.Text = objtCategoria.NombreCateg;
            txtDescripcion.Text = objtCategoria.Descripcion;
            comboBoxEstado.Text = objtCategoria.Estado;
            dateFechaRegistro = objtCategoria.FechaRegistro;
            txtNombre.Focus();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassValidations.LettersValidation(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IsEditar = false;
            FnClearDatos();
        }
    }
}
