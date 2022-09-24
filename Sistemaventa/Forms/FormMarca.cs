using Sistemaventa.Class;
using Sistemaventa.Sistema_Venta;
using Sistemaventa.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemaventa.Forms
{
    public partial class FormMarca : Form
    {
        bool IsEditar = false;

        Marca objtMarca;
        CodeRepeatClass repeatClass = new CodeRepeatClass();
        private static FormMarca ChilInstance = null;
        public static FormMarca Instance()
        {
            if (ChilInstance == null || ChilInstance.IsDisposed == true)
            {
                ChilInstance = new FormMarca();
            }
            ChilInstance.BringToFront();
            return ChilInstance;
        }
        public FormMarca()
        {
            InitializeComponent();
        }
        private void FnClearDatos()
        {
            txtNombre.Clear();
            pictureBoxLogo.Image = Properties.Resources.subir;
        }
        private bool FnValidarCamposVacios()
        {
            return (txtNombre.Text.Trim().Length == 0);
        }
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            repeatClass.FnAbrirImangen(pictureBoxLogo);
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            pictureBoxLogo.AllowDrop = true;

            var MensajeAyuda = new ToolTip();
            MensajeAyuda.SetToolTip(txtNombre, "Permite agregar el nombre de la Marca");
            MensajeAyuda.SetToolTip(btnGuardar, "Permite guardar el registrro de la Marca");
            MensajeAyuda.SetToolTip(btnModificar, "Permite modificar el registrro de la Marca");
            MensajeAyuda.SetToolTip(btnCancelar, "Permite cancelar cualquier acción que se haya realizado");

            txtNombre.Focus();
        }

        private void pictureBoxLogo_DragDrop(object sender, DragEventArgs e)
        {
            repeatClass.FnDragDropPictureBox(sender, e, pictureBoxLogo);
        }

        private void pictureBoxLogo_DragEnter(object sender, DragEventArgs e)
        {
            repeatClass.FnCopyPictureBox(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FnClearDatos();
            IsEditar = false;
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (IsEditar == true)
            {
                MessageBox.Show("Este registro ya existe y esta editandose" + "\r\n" + "\r\n" + "Si lo desea editar presione el boton Modificar", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnModificar.Focus();
                return;
            }

            if (FnValidarCamposVacios())
            {
                MessageBox.Show("Debes de llenar todos los campos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Marca item in xpMarca)
            {
                if (item.Nombre.Trim().ToLower() == txtNombre.Text.Trim().ToLower())
                {
                    MessageBox.Show("El Nombre ya existe en la base de datos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                    return;
                }
            }

            if (MessageBox.Show("¿Seguro desea guardar su registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtMarca = new Marca(SesionVenta);
                objtMarca.Nombre = txtNombre.Text;
                objtMarca.Logotipo = repeatClass.ConvertImag(pictureBoxLogo);
                objtMarca.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

                objtMarca.Save();
                SesionVenta.CommitChanges();
                MessageBox.Show("Su registro se guardo correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpMarca.Reload();
                FnClearDatos();
                txtNombre.Focus();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (xpMarca.Count == 0)
            {
                MessageBox.Show("No existe ningún registro, debes de agregar registros", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IsEditar = true;

            txtNombre.Focus();

            objtMarca = (Marca)gridViewMarca.GetFocusedRow();

            txtNombre.Text = objtMarca.Nombre;

            pictureBoxLogo.Image = repeatClass.ByteToImage(objtMarca.Logotipo);

            txtNombre.Focus();
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

            if (MessageBox.Show("¿Seguro desea modificar su registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtMarca = (Marca)gridViewMarca.GetFocusedRow();
                objtMarca.Nombre = txtNombre.Text;

                CodeRepeatClass codeRepeatClass = new CodeRepeatClass();
                objtMarca.Logotipo = codeRepeatClass.ConvertImag(pictureBoxLogo);
                objtMarca.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

                objtMarca.Save();
                SesionVenta.CommitChanges();
                MessageBox.Show("Su registro se modifico correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpMarca.Reload();
                FnClearDatos();
                IsEditar = false;
                txtNombre.Focus();
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.SelectAll();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassValidations.Number_Letters(e);
        }
    }
}
