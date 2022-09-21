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
    public partial class FormCompra : Form
    {
        bool IsEditar = false, IsEliminar = false, IsKeyPressCalcular = false;
        int ValorCantidad, Cantidad;
        decimal PrecioCompra = 0m, Subtotal = 0m;

        CodeRepeatClass repeatClass = new CodeRepeatClass();

        Producto objtProducto;
        Compra objtCompra;
        DetalleCompra objtDetalleCompra;
        public static Empleado objtEmpleado;
        private static FormCompra ChilInstance = null;
        public static FormCompra Instance(Empleado empleado = null)
        {
            objtEmpleado = empleado;
            if (ChilInstance == null || ChilInstance.IsDisposed == true)
            {
                ChilInstance = new FormCompra();
            }
            ChilInstance.BringToFront();
            return ChilInstance;
        }
       
        public FormCompra()
        {
            InitializeComponent();
        }
        private void FnClearDatosGuardar()
        {
            searchProveedor.EditValue = null;
            searchProducto.EditValue = null;
            comboBoxTipoDocumento.SelectedIndex = 0;
            txtDocumento.Clear();
            txtPrecioCompra.Text = "0";
            txtCantidad.Value = 1;
            txtSubTotal.Text = "0";
            txtMontoTotal.Text = "0";
        }
        private void FnClearDatosAgregar()
        {
            searchProducto.EditValue = null;
            txtPrecioCompra.Text = "0";
            txtCantidad.Value = 1;
        }
        private bool FnValidationCamposVacios()
        {
            return (searchProveedor.EditValue == null || searchProducto.EditValue == null || comboBoxTipoDocumento.Text.Trim().Length == 0
                || txtDocumento.Text.Trim().Length == 0 || txtPrecioCompra.Text == "0" || txtCantidad.Value == 0);
        }

        private void FnCalcularSubtotal()
        {
            objtProducto = (Producto)searchViewProducto.GetFocusedRow();

            if (objtProducto == null)
            {
                MessageBox.Show("Debes de seleccionar un producto", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (txtPrecioCompra.Text == "")
                {
                    txtPrecioCompra.Text = "0";
                }
                else
                {
                    Cantidad = int.Parse(txtCantidad.Value.ToString());

                    PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text.ToString());

                    txtSubTotal.Text = Convert.ToDecimal(PrecioCompra * Cantidad).ToString();

                    Subtotal = Convert.ToDecimal(txtSubTotal.Text.ToString());
                }
            }
        }
        private void FnEditCancelar()
        {

            if (txtMontoTotal.Text == "")
            {
                txtMontoTotal.Text = Convert.ToDecimal(Subtotal.ToString()).ToString();
            }
            {
                txtMontoTotal.Text = (Convert.ToDecimal(txtMontoTotal.Text) + objtDetalleCompra.SubTotal).ToString();
            }
            FnClearDatosAgregar();
            IsEditar = false;
        }
        private void FnEnableButtonCancelar(bool v)
        {
            btnCancelar.Enabled = v;
        }
        private void FnFilterProveedor()
        {
            searchViewProveedor.ActiveFilterString = "[EstadoProv] = 'Activo'";
            //xpProveedor.Reload();
        }
        private void FnFilterProducto()
        {
            searchViewProducto.ActiveFilterString = "[Estado] = 'Activo'";
        }
        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            IsKeyPressCalcular = true;
            FnCalcularSubtotal();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            IsKeyPressCalcular = true;
            FnCalcularSubtotal();
        }

        private void gridViewCompra_DoubleClick(object sender, EventArgs e)
        {
            if (objtDetalleCompra == null)
            {
                MessageBox.Show("Aún no hay registro en la trabla", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IsEditar = true;

            objtDetalleCompra = (DetalleCompra)gridViewCompra.GetFocusedRow();

            searchProducto.EditValue = objtDetalleCompra.IdProd.IdProd;
            txtPrecioCompra.Text = objtDetalleCompra.PrecioCompra.ToString();
            txtCantidad.Value = objtDetalleCompra.Cantidad;

            if (IsEditar == true)
            {
                txtMontoTotal.Text = (Convert.ToDecimal(txtMontoTotal.Text) - objtDetalleCompra.SubTotal).ToString();
            }
            FnEnableButtonCancelar(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea realizar la compra?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Empleado item in xpEmpleado)
                {
                    if (item.Id == objtEmpleado.Id)
                    {
                        objtCompra.IdEmpleado = item;
                    }
                }

                objtCompra.IdProv = (Proveedor)searchViewProveedor.GetFocusedRow();

                objtCompra.TipoDocumento = comboBoxTipoDocumento.Text;
                objtCompra.Documento = txtDocumento.Text;

                objtCompra.Cantidad = ValorCantidad;
                objtCompra.MontoTotal = Convert.ToDecimal(txtMontoTotal.Text);

                objtCompra.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

                objtCompra.Save();
                SesionVenta.CommitChanges();
                MessageBox.Show("Su compra se realizo correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpCompra.Reload();
                FnClearDatosGuardar();

                objtCompra = new Compra(SesionVenta);
                gridCompra.DataSource = null;
                gridCompra.Refresh();
                gridCompra.DataSource = objtCompra.DetalleCompras;
                IsKeyPressCalcular = false;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FnEditCancelar();
            FnEnableButtonCancelar(false);
        }

        private void gridViewCompra_Click(object sender, EventArgs e)
        {
            IsEliminar = true;
        }

        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.SelectAll();
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassValidations.NumberValidation(e);
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassValidations.NumberValidation(e);
        }

        private void searchProveedor_Popup(object sender, EventArgs e)
        {
            if (objtEmpleado.IdRol.NombreRol != "Administración")
            {
                FnFilterProveedor();
            }
        }

        private void searchProducto_Popup(object sender, EventArgs e)
        {
            if (objtEmpleado.IdRol.NombreRol != "Administración")
            {
                FnFilterProducto();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (IsEditar == false)
            {
                if (FnValidationCamposVacios())
                {
                    MessageBox.Show("Debes de llenar los parametros requeridos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (FnValidationCamposVacios())
                {
                    MessageBox.Show("Debes de llenar toda a infomación, para realizar la compra", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                objtDetalleCompra = new DetalleCompra(SesionVenta);

                objtDetalleCompra.Cantidad = int.Parse(txtCantidad.Value.ToString());
                Cantidad = int.Parse(txtCantidad.Value.ToString());
                ValorCantidad = ValorCantidad + Cantidad;
                objtDetalleCompra.IdProd = (Producto)searchViewProducto.GetFocusedRow();
                objtDetalleCompra.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);

                objtDetalleCompra.SubTotal = Convert.ToDecimal(Subtotal);

                objtDetalleCompra.Save();

                objtCompra.DetalleCompras.Add(objtDetalleCompra);
                gridCompra.RefreshDataSource();

                if (txtMontoTotal.Text == "")
                {
                    txtMontoTotal.Text = Subtotal.ToString();
                }
                else
                {
                    txtMontoTotal.Text = (Convert.ToDecimal(txtMontoTotal.Text) + objtDetalleCompra.SubTotal).ToString();
                }
                FnClearDatosAgregar();

            }
            else
            {
                MessageBox.Show("En este momento se encuentra editano" + "\r\n" + "Para ediatar precione el boton Modificar", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (IsEditar == false)
            {
                MessageBox.Show("Debes de seleccionar un registro de la tabla", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (FnValidationCamposVacios())
            {
                MessageBox.Show("Debes de llenar los parametros requeridos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            objtDetalleCompra = (DetalleCompra)gridViewCompra.GetFocusedRow();

            objtDetalleCompra.Cantidad = int.Parse(txtCantidad.Value.ToString());
            Cantidad = int.Parse(txtCantidad.Value.ToString());
            objtDetalleCompra.IdProd = (Producto)searchViewProducto.GetFocusedRow();
            objtDetalleCompra.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);

            objtDetalleCompra.SubTotal = Convert.ToDecimal(Subtotal);

            objtDetalleCompra.Save();

            objtCompra.DetalleCompras.Add(objtDetalleCompra);
            gridCompra.RefreshDataSource();

            FnEditCancelar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objtDetalleCompra == null)
            {
                MessageBox.Show("Aun no hay registro guardados", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsEliminar == false)
            {
                MessageBox.Show("Debes de seleccionar un registro de la tabla", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Seguro desea quitar el registro de la tabla?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtDetalleCompra = (DetalleCompra)gridViewCompra.GetFocusedRow();
                SesionVenta.Delete(objtDetalleCompra);
                if (IsEliminar == true)
                {
                    ValorCantidad = ValorCantidad - objtDetalleCompra.Cantidad;
                    txtMontoTotal.Text = (Convert.ToDecimal(txtMontoTotal.Text) - objtDetalleCompra.SubTotal).ToString();
                }
                MessageBox.Show("Su registro se quito de la tabla correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpDetalleCompra.Reload();

                IsEliminar = false;
            }
        }
        private void FormCompra_Load(object sender, EventArgs e)
        {
            var MensaAyuda = new ToolTip();
            MensaAyuda.SetToolTip(searchProveedor, "Nos permite seleccionar el proveedor para realizar la compra");
            MensaAyuda.SetToolTip(searchProducto, "Nos permite seleccionar el producto para realizar la compra");
            MensaAyuda.SetToolTip(comboBoxTipoDocumento, "Nos permite seleccionar el tipo de documento que tendra la compra");
            MensaAyuda.SetToolTip(txtDocumento, "Agrega el número del documento que tendra la compra");
            MensaAyuda.SetToolTip(txtPrecioCompra, "Agrega el precio que tendra el producto");
            MensaAyuda.SetToolTip(txtCantidad, "Agrega la cantidad producto que se comprará");
            MensaAyuda.SetToolTip(btnCalcular, "Hace el calculo del subtotal de los productos");
            MensaAyuda.SetToolTip(txtSubTotal, "Muestra el subtotal de compra");
            MensaAyuda.SetToolTip(txtMontoTotal, "Muestra el total de compra");
            MensaAyuda.SetToolTip(btnAgregar, "Agrega los productos ala tabla");
            MensaAyuda.SetToolTip(btnModificar, "Modifica los productos ala tabla");
            MensaAyuda.SetToolTip(btnEliminar, "Retira los productos ala tabla");
            MensaAyuda.SetToolTip(btnCancelar, "Cancela las mofificaciones de los productos de la tabla");

            comboBoxTipoDocumento.SelectedIndex = 0;
            FnEnableButtonCancelar(false);

            objtCompra = new Compra(SesionVenta);
            gridCompra.DataSource = objtCompra.DetalleCompras;
        }
    }
}
