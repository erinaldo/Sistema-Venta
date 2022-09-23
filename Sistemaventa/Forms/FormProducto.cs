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
    public partial class FormProducto : Form
    {
        bool IsEditar = false;
        int ValorCategoria, ValorMarca;

        Producto objtProducto;
        public static Empleado objtEmpleado;
        CodeRepeatClass repeatClass = new CodeRepeatClass();

        private static FormProducto ChilInstance = null;
        public static FormProducto Instance(Empleado empleado = null)
        {
            objtEmpleado = empleado;
            if (ChilInstance == null || ChilInstance.IsDisposed == true)
            {
                ChilInstance = new FormProducto();
            }
            ChilInstance.BringToFront();
            return ChilInstance;
        }
        public FormProducto()
        {
            InitializeComponent();
        }
        private void FnEnableDatosGuardar(bool v)
        {
            txtCodigo.Enabled = v;
            txtNombre.Enabled = v;
            txtDescripcion.Enabled = v;
            searchCategoria.Enabled = v;
            searchMarca.Enabled = v;
            comboBoxEstado.Enabled = v;
            radioButtonVence.Enabled = v;
            radioButtonNoVence.Enabled = v;
            pictureBoxFoto.Enabled = v;
        }
        private void FnEnableButton(bool v)
        {
            btnNuevo.Enabled = v;
            btnGuardar.Enabled = !v;
            btnModificar.Enabled = v;
        }
        private void FnEnableButtonCancelar(bool v)
        {
            btnCancelar.Enabled = v;
        }
        private void FnEnablefechaVencimiento(bool v)
        {
            dateFechaVencimiento.Enabled = v;
        }
        private void FnClearDatosGuardar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            searchCategoria.EditValue = null;
            searchMarca.EditValue = null;
            comboBoxEstado.SelectedIndex = 0;
            radioButtonVence.Checked = false;
            radioButtonNoVence.Checked = false;
            dateFechaVencimiento.Text = "";
            pictureBoxFoto.Image = Properties.Resources.subir;
        }
        private bool FnValidacionCamposVacios()
        {
            return (txtCodigo.Text.Trim().Length == 0 || txtNombre.Text.Trim().Length == 0 || txtDescripcion.Text.Trim().Length == 0 ||
                  comboBoxEstado.Text.Trim().Length == 0 || searchCategoria.EditValue == null || searchMarca.EditValue == null);
        }
        private void FnFiltroCategoria()
        {
            searchViewCategoria.ActiveFilterString = "[Estado] = 'Activo'";
            xpCategoria.Reload();
        }
        private void FnFilterProductosVencidos()
        {
            string FechaVence = "";
            FechaVence = DateTime.Now.ToLongDateString();
            searchViewCategoria.ActiveFilterString = "[FechaVence] = 'No-Vence' || [FechaVence] != 'FechaVence'";
            xpCategoria.Reload();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (IsEditar == true)
            {
                FnClearDatosGuardar();
                IsEditar = false;
            }

            FnEnableDatosGuardar(true);
            FnEnableButton(false);
            FnEnableButtonCancelar(true);
            txtCodigo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IsEditar = false;
            FnEnableButton(true);
            FnClearDatosGuardar();
            FnEnableDatosGuardar(false);
        }
        private void FormProducto_Load(object sender, EventArgs e)
        {
            pictureBoxFoto.AllowDrop = true;

            var MensajeAyuda = new ToolTip();
            MensajeAyuda.SetToolTip(txtCodigo, "Agrega código del producto");
            MensajeAyuda.SetToolTip(txtNombre, "Agrega nombre del producto");
            MensajeAyuda.SetToolTip(txtDescripcion, "Agrega descripción del producto");
            MensajeAyuda.SetToolTip(searchCategoria, "Agrega la categoria de los productos");
            MensajeAyuda.SetToolTip(searchMarca, "Agrega la marca de los productos");
            MensajeAyuda.SetToolTip(comboBoxEstado, "Agrega el estado de los productos");
            MensajeAyuda.SetToolTip(btnNuevo, "Permite agregar un nuevo registro");
            MensajeAyuda.SetToolTip(btnGuardar, "Permite guardar un nuevo registro");
            MensajeAyuda.SetToolTip(btnModificar, "Permite modificar un nuevo registro");
            MensajeAyuda.SetToolTip(btnCancelar, "Cancela cualquier acción que se haya realizado");
            MensajeAyuda.SetToolTip(radioButtonVence, "Nos indica si el producto tiene Vencimiento");
            MensajeAyuda.SetToolTip(radioButtonNoVence, "Nos indica si el producto tiene o no Vencimiento");

            if (objtEmpleado.IdRol.NombreRol != "Administración")
            {
                FnFilterProductosVencidos();
            }

            FnEnableButton(true);
            FnEnableDatosGuardar(false);
            FnEnablefechaVencimiento(false);
            FnEnablefechaVencimiento(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (Producto item in xpProducto)
            {
                if (item.Codigo.Trim().ToLower() == txtCodigo.Text.Trim().ToLower())
                {
                    MessageBox.Show("Este código ya se esta usando", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigo.Focus();
                    return;
                }
                else if(item.Nombre.Trim().ToLower() == txtNombre.Text.Trim().ToLower())
                {
                    MessageBox.Show("Este producto ya se encuentra en la base de datos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                    return;
                }
            }
            if (FnValidacionCamposVacios())
            {
                MessageBox.Show("Debes de llenar todos los campos vacios", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radioButtonVence.Checked == false && radioButtonNoVence.Checked == false)
            {
                MessageBox.Show("Debes de seleccionar si vence o no vence el producto", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                radioButtonVence.Focus();
                return;
            }
            else if (radioButtonVence.Checked && dateFechaVencimiento.Text == "")
            {
                MessageBox.Show("Debes agregar la fecha producto", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                radioButtonNoVence.Focus();
                return;
            }

            if (MessageBox.Show("¿Seguro desea guardar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtProducto = new Producto(SesionVenta);

                objtProducto.Codigo = txtCodigo.Text;
                objtProducto.Nombre = txtNombre.Text;
                objtProducto.Descripcion = txtDescripcion.Text;
                objtProducto.IdCateg = (Categoria)searchViewCategoria.GetFocusedRow();
                objtProducto.IdMarca = (Marca)searchViewMarca.GetFocusedRow();
                objtProducto.Estado = comboBoxEstado.Text;
                objtProducto.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

                if (radioButtonVence.Checked)
                {
                    objtProducto.FechaVence = dateFechaVencimiento.Text;
                }
                else
                {
                    objtProducto.FechaVence = radioButtonNoVence.Text;
                }

                objtProducto.ImagenArticulo = repeatClass.ConvertImag(pictureBoxFoto);

                objtProducto.Save();
                SesionVenta.CommitChanges();
                MessageBox.Show("Su registro se guardo correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpProducto.Reload();
                FnClearDatosGuardar();
                FnEnableButton(true);
                FnEnableDatosGuardar(false);
            }
        }

        private void radioButtonVence_CheckedChanged(object sender, EventArgs e)
        {
            FnEnablefechaVencimiento(true);
        }

        private void radioButtonNoVence_CheckedChanged(object sender, EventArgs e)
        {
            FnEnablefechaVencimiento(false);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (IsEditar == false)
            {
                MessageBox.Show("Debes de seleccionar de la tabla el registro a editar", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridProcucto.Focus();
                return;
            }

            if (FnValidacionCamposVacios())
            {
                MessageBox.Show("Debes de llenar todos los campos vacios", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radioButtonVence.Checked == false && radioButtonNoVence.Checked == false)
            {
                MessageBox.Show("Debes de seleccionar si vence o no vence el producto", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                radioButtonVence.Focus();
                return;
            }
            else if (radioButtonVence.Checked && dateFechaVencimiento.Text == "")
            {
                MessageBox.Show("Debes agregar la fecha producto", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                radioButtonNoVence.Focus();
                return;
            }
            if (MessageBox.Show("¿Seguro dese editar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtProducto = (Producto)gridViewProducto.GetFocusedRow();

                objtProducto.Codigo = txtCodigo.Text;
                objtProducto.Nombre = txtNombre.Text;
                objtProducto.Descripcion = txtDescripcion.Text;

                if (searchCategoria.EditValue == null || Convert.ToInt32(searchCategoria.EditValue) != ValorCategoria)
                {
                    objtProducto.IdCateg = (Categoria)searchViewCategoria.GetFocusedRow();
                }
                else
                {
                    objtProducto.IdCateg.IdCateg = ValorCategoria;
                }

                if (searchMarca.EditValue == null || Convert.ToInt32(searchMarca.EditValue) != ValorMarca)
                {
                    objtProducto.IdMarca = (Marca)searchViewMarca.GetFocusedRow();
                }
                else
                {
                    objtProducto.IdMarca.IdMarca = ValorMarca;
                }

                objtProducto.Estado = comboBoxEstado.Text;
                objtProducto.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

                if (radioButtonVence.Checked)
                {
                    objtProducto.FechaVence = dateFechaVencimiento.Text;
                }
                else
                {
                    objtProducto.FechaVence = radioButtonNoVence.Text;
                }

                objtProducto.ImagenArticulo = repeatClass.ConvertImag(pictureBoxFoto);

                objtProducto.Save();
                SesionVenta.CommitChanges();
                MessageBox.Show("Su registro se edito correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpProducto.Reload();
                FnClearDatosGuardar();
                FnEnableButton(true);
                FnEnableDatosGuardar(false);
                IsEditar = false;
            }
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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassValidations.NumberValidation(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassValidations.LettersValidation(e);
        }

        private void searchCategoria_Popup(object sender, EventArgs e)
        {
            if (objtEmpleado.IdRol.NombreRol != "Administración")
            {
                FnFiltroCategoria();
            }
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            TextBox Text = (TextBox)sender;
            Text.SelectAll();
        }

        private void searchCategoria_Properties_Click(object sender, EventArgs e)
        {
            foreach (Categoria categoria in xpCategoria)
            {
                categoria.Reload();
            }
        }

        private void searchMarca_Properties_Click(object sender, EventArgs e)
        {
            foreach (Marca marca in xpMarca)
            {
                marca.Reload();
            }
        }

        private void gridViewProducto_DoubleClick(object sender, EventArgs e)
        {
            if (xpProducto.Count == 0)
            {
                MessageBox.Show("Aun no hay registro", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IsEditar = true;

            objtProducto = (Producto)gridViewProducto.GetFocusedRow();

            txtCodigo.Text = objtProducto.Codigo;
            txtNombre.Text = objtProducto.Nombre;
            txtDescripcion.Text = objtProducto.Descripcion;

            searchCategoria.EditValue = objtProducto.IdCateg.IdCateg;
            ValorCategoria = objtProducto.IdCateg.IdCateg;
            searchMarca.EditValue = objtProducto.IdMarca.IdMarca;
            ValorMarca = objtProducto.IdMarca.IdMarca;

            pictureBoxFoto.Image = repeatClass.ByteToImage(objtProducto.ImagenArticulo);

            comboBoxEstado.Text = objtProducto.Estado;

            if (objtProducto.FechaVence == "No-Vence")
            {
                radioButtonNoVence.Checked = true;
            }
            else
            {
                radioButtonVence.Checked = true;
                dateFechaVencimiento.Text = objtProducto.FechaVence;
            }

            FnEnableDatosGuardar(true);
            FnEnableButton(true);
            txtCodigo.Focus();
        }
    }
}
