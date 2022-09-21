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
using System.Data.SqlClient;

namespace Sistemaventa.Forms
{
    public partial class FormVenta : Form
    {
        bool IsEditar = false, IsEliminar = false, KeypressCalcular = false, keypresscompra = false, keypressEliminar = false;
        decimal ResultadoNumericUpDown = 0, Resultado;
        int Subtotal, PrecioVenta, ValorCantidad, Cantidad, TotalStockProducto, IdDetalleCompra = 0, ResultadoStock = 0, CantidadStock;

        CodeRepeatClass repeatClass = new CodeRepeatClass();
        List<EntidadClass> entidads = new List<EntidadClass>();
        EntidadClass entidad;

        DetalleVenta objtDetalleVenta;
        DetalleCompra objtDetalleCompra;
        Venta objtVenta;
        Compra objtCompra;
        public static Empleado objtEmpleado;
        public static CambioDolar objtCambioDolar;
        private static FormVenta ChilInstance = null;
        public static FormVenta Instance(Empleado empleado = null, CambioDolar cambioDolar = null)
        {
            objtEmpleado = empleado;
            objtCambioDolar = cambioDolar;
            if (ChilInstance == null || ChilInstance.IsDisposed == true)
            {
                ChilInstance = new FormVenta();
            }
            ChilInstance.BringToFront();
            return ChilInstance;
        }
        public FormVenta()
        {
            InitializeComponent();
        }
        private void FnEnableTextBoxCambio(bool v)
        {
            txtCordoba.Enabled = v;
            txtDolar.Enabled = !v;
        }
        private void FnEnableDescuento(bool v)
        {
            txtDescuento.Enabled = v;
        }
        private void FnClearDatosGuardar()
        {
            searchCliente.EditValue = null;
            comboBoxDocumento.SelectedIndex = 0;
            txtDocumento.Clear();
            searchProducto.EditValue = null;
            txtPrecio.Text = "0";
            txtCantidad.Value = 0;
            txtCalculoSubtotal.Text = "0";

            txtCordoba.Text = "0";
            txtDolar.Text = "0";
            radioButtonCordoba.Checked = true;
            txtMontoCambio.Text = "0";

            txtDescuento.Clear();
            if (checkBoxDescuento.Checked)
            {
                checkBoxDescuento.Checked = false;
            }

            txtSubtotal.Text = "0";
            txtMontototal.Text = "0";
            txtStock.Text = "0";
        }
        private void FnClearDatosAgregar()
        {
            searchProducto.EditValue = null;
            txtPrecio.Text = "0";
            txtCantidad.Value = 0;
            txtCalculoSubtotal.Text = "0";
            txtStock.Text = "0";
        }
        private bool FnValidarCamposVaciosAgregar()
        {
            return (searchProducto.EditValue == null || txtPrecio.Text.Trim().Length == 0 || txtCantidad.Value == 0);
        }
        private bool FnValidarCamposVacioGuardar()
        {
            return (searchCliente.EditValue == null || comboBoxDocumento.SelectedIndex == -1 || txtDocumento.Text.Trim().Length == 0);
        }
        private void FnEnableButtonCancelar(bool v)
        {
            btnCancelar.Enabled = v;
        }
        private void FnEditarCancelar()
        {
            if (txtSubtotal.Text == "")
            {
                txtSubtotal.Text = Subtotal.ToString();
            }
            else
            {
                txtSubtotal.Text = (Convert.ToDecimal(txtSubtotal.Text) + objtDetalleVenta.SubTotal).ToString();
            }
            FnClearDatosAgregar();
            IsEditar = false;
        }
        private void FnCalcularSubtotal()
        {
            objtDetalleCompra = (DetalleCompra)searchViewProducto.GetFocusedRow();

            if (objtDetalleCompra == null)
            {
                MessageBox.Show("Debes de seleccionar un producto", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cantidad = int.Parse(txtCantidad.Value.ToString());
            PrecioVenta = Convert.ToInt32(txtPrecio.Text);

            txtCalculoSubtotal.Text = Convert.ToDecimal(PrecioVenta * Cantidad).ToString();

            Subtotal = Convert.ToInt32(txtCalculoSubtotal.Text);
        }
        private void FnCalcularStock()
        {
            if (txtCantidad.Value > ResultadoNumericUpDown)
            {

                Resultado = int.Parse(txtStock.Text) - 1;
                txtStock.Text = Resultado.ToString();
            }
            else
            {
                Resultado = int.Parse(txtStock.Text) + 1;
                txtStock.Text = Resultado.ToString();
            }

            if (txtCantidad.Value > TotalStockProducto)
            {
                MessageBox.Show("Has ocupado todos los productos que se encuentran en el stock", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Value = TotalStockProducto;
                txtCantidad.Focus();
                txtStock.Text = "0";
                return;
            }

            ResultadoNumericUpDown = txtCantidad.Value;
        }
        private void FnCalcularDescuento()
        {
            decimal ResultadoPorcentaje, Resultado, Subtotal, Descuentototal;
            int DescuentototalInt;

            if (checkBoxDescuento.Checked)
            {
                ResultadoPorcentaje = Convert.ToDecimal(txtDescuento.Text) / 100;

                Resultado = ResultadoPorcentaje * Convert.ToDecimal(txtSubtotal.Text);

                DescuentototalInt = Convert.ToInt32(Resultado);

                txtDescuentoTotal.Text = DescuentototalInt.ToString();

                Subtotal = Convert.ToDecimal(txtSubtotal.Text);
                Descuentototal = Convert.ToDecimal(txtDescuentoTotal.Text);

                txtMontototal.Text = (Subtotal - Descuentototal).ToString();
            }
        }
        private void FnCalcularCambio()
        {
            int ResultadoCambio, Montopago, MontoTotal;

            if (radioButtonDolar.Checked)
            {
                if (txtMontototal.Text == "0")
                {
                    MontoTotal = Convert.ToInt32(txtSubtotal.Text);
                }
                else
                {
                    MontoTotal = Convert.ToInt32(txtMontototal.Text);
                }
                Montopago = Convert.ToInt32(txtMontoPago.Text);
                ResultadoCambio = Montopago - MontoTotal;

                if (MontoTotal > Montopago)
                {
                    MessageBox.Show("Su monto de pago es mayor, que el pago realizado", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    txtMontoCambio.Text = ResultadoCambio.ToString();
                }
            }
            else
            {
                if (txtMontototal.Text == "0")
                {
                    MontoTotal = Convert.ToInt32(txtSubtotal.Text);
                }
                else
                {
                    MontoTotal = Convert.ToInt32(txtMontototal.Text);
                }
                Montopago = Convert.ToInt32(txtCordoba.Text);
                ResultadoCambio = Montopago - MontoTotal;

                if (MontoTotal > Montopago)
                {
                    MessageBox.Show("Su monto de pago es mayor, que el pago realizado", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    txtMontoCambio.Text = ResultadoCambio.ToString();
                }
            }
        }
        private void FnUpdateDetalleCompra()
        {
            int Resultado;

            if(keypressEliminar == true)
            {
                Resultado = objtDetalleCompra.Cantidad + CantidadStock;
                objtDetalleCompra.Cantidad = Resultado;
                keypressEliminar = false;
            }

            Resultado = objtDetalleCompra.Cantidad - Convert.ToInt32(txtCantidad.Value);
            objtDetalleCompra.Cantidad = Resultado;
        }
        private void FnFilterCliente()
        {
            searchViewCliente.ActiveFilterString = "[Estado] = 'Activo'";
        }
        private void radioButtonCordoba_CheckedChanged(object sender, EventArgs e)
        {
            txtDolar.Text = "0";
            FnEnableTextBoxCambio(true);
            txtCordoba.Focus();
        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            FnCalcularStock();
            FnCalcularSubtotal();
            KeypressCalcular = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ValorCantidad = int.Parse(txtPrecio.Text);
            if (ValorCantidad <= 0)
            {
                MessageBox.Show("El precio del producto no debe de ser menor cero", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
                return;
            }
            else
            {
                KeypressCalcular = true;
                FnCalcularSubtotal();
            }
        }

        private void gridViewDetalleVenta_DoubleClick(object sender, EventArgs e)
        {
            if (objtDetalleVenta == null)
            {
                MessageBox.Show("Aún no hay registro en la tabla", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IsEditar = true;
            FnEnableButtonCancelar(true);
            objtDetalleVenta = (DetalleVenta)gridViewDetalleVenta.GetFocusedRow();

            searchProducto.EditValue = objtDetalleVenta.IdProd.IdProd;
            txtPrecio.Text = objtDetalleVenta.PrecioVenta.ToString();
            txtCantidad.Value = objtDetalleVenta.Stock;

            txtStock.Text = (Convert.ToDecimal(TotalStockProducto) - txtCantidad.Value).ToString();

            if (IsEditar == true)
            {
                txtSubtotal.Text = (Convert.ToDecimal(txtSubtotal.Text) - objtDetalleVenta.SubTotal).ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (IsEditar == false)
            {
                MessageBox.Show("Debes de seleccionar un registro de la tabla", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Seguro desea editar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtDetalleVenta = (DetalleVenta)gridViewDetalleVenta.GetFocusedRow();

                objtDetalleVenta.IdProd = objtDetalleCompra.IdProd;
                objtDetalleVenta.PrecioVenta = decimal.Parse(txtPrecio.Text);
                objtDetalleVenta.Stock = int.Parse(txtCantidad.Value.ToString());
                ValorCantidad = ValorCantidad + Cantidad;
                objtDetalleVenta.SubTotal = decimal.Parse(txtCalculoSubtotal.Text);

                objtDetalleVenta.Save();
                objtVenta.DetalleVentas.Add(objtDetalleVenta);
                gridDetalleVenta.RefreshDataSource();

                FnEditarCancelar();
                FnEnableButtonCancelar(false);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IsEliminar == true)
            {
                if (MessageBox.Show("¿Seguro desea quitar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    objtDetalleVenta = (DetalleVenta)gridViewDetalleVenta.GetFocusedRow();
                    ValorCantidad = ValorCantidad - objtDetalleVenta.Stock;
                    txtSubtotal.Text = (Convert.ToDecimal(txtSubtotal.Text) - objtDetalleVenta.SubTotal).ToString();
                    SesionVenta.Delete(objtDetalleVenta);
                    MessageBox.Show("Su registro se quito correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xpDetalleVenta.Reload();
                    IsEliminar = false;
                    keypressEliminar = true;
                    FnUpdateDetalleCompra();                    
                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un registro de la tabla", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FnEditarCancelar();
            FnEnableButtonCancelar(false);
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            if (radioButtonCordoba.Checked)
            {
                MessageBox.Show("Usted no puede pegar el valor del cambio del dolar, porque su pago es en cordoba", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtMontoPago.Text = Clipboard.GetText();
            }
        }

        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.SelectAll();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            FnCalcularDescuento();
            FnCalcularCambio();
            keypresscompra = true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassValidations.NumberValidation(e);
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassValidations.NumberValidation(e);
        }

        private void searchCliente_Popup(object sender, EventArgs e)
        {
            if (objtEmpleado.IdRol.NombreRol != "Administración")
            {
                FnFilterCliente();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(FnValidarCamposVacioGuardar())
            {
                MessageBox.Show("Debes de llenar todos los campos vacios", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (xpDetalleVenta == null)
            {
                MessageBox.Show("Debes de agregar los detalles de su venta", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (keypresscompra == false)
            {
                MessageBox.Show("Debes de ralizar el pago de la venta para terminar de realizar la compra", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnPagar.Focus();
                return;
            }

            if (MessageBox.Show("¿Seguro desea realizar la compra?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Empleado item in xpEmpleado)
                {
                    if (item.Id == objtEmpleado.Id)
                    {
                        objtVenta.IdEmpleado = item;
                    }
                }

                objtVenta.IdClient = (Cliente)searchViewCliente.GetFocusedRow();
                objtVenta.TipoDocumento = comboBoxDocumento.Text;
                objtVenta.DocumentoVenta = txtDocumento.Text;

                if (radioButtonCordoba.Checked)
                {
                    objtVenta.MontoPago = Convert.ToDecimal(txtCordoba.Text);
                    objtVenta.TipoPago = radioButtonCordoba.Text;
                }
                else if (radioButtonDolar.Checked)
                {
                    objtVenta.MontoPago = Convert.ToDecimal(txtDolar.Text);
                    objtVenta.TipoPago = radioButtonDolar.Text;
                }

                objtVenta.MontoCambio = Convert.ToDecimal(txtMontoCambio.Text);

                foreach (CambioDolar item in xpDolar)
                {
                    if (item.Id == objtCambioDolar.Id)
                    {
                        objtVenta.IdCambio = item;
                    }
                }

                objtVenta.Descuento = Convert.ToInt32(txtDescuento.Text);

                if(txtSubtotal.Text == "0")
                {
                    objtVenta.MontoTotal = Convert.ToDecimal(txtMontototal.Text);
                }
                else
                {
                    objtVenta.MontoTotal = Convert.ToDecimal(txtSubtotal.Text);
                }

                objtVenta.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

                objtVenta.Save();
                SesionVenta.CommitChanges();
                MessageBox.Show("Su compra se realizo correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpVenta.Reload();

                FnUpdateDetalleCompra();
                objtDetalleCompra.Save();
                objtDetalleCompra = SesionVenta.GetObjectByKey<DetalleCompra>(objtDetalleCompra.IdDetalleCompra);
                xpDetalleCompra.Reload();
                FnClearDatosGuardar();

                objtVenta = new Venta(SesionVenta);
                gridDetalleVenta.DataSource = null;
                gridDetalleVenta.Refresh();
                gridDetalleVenta.DataSource = objtVenta.DetalleVentas;
            }
        }

        private void searchProducto_Properties_EditValueChanged(object sender, EventArgs e)
        {
            objtDetalleCompra = (DetalleCompra)searchViewProducto.GetFocusedRow();

            foreach (DetalleCompra detalle in xpDetalleCompra)
            {
                foreach (Producto item in xpProducto)
                {
                    if (item.Descripcion == detalle.IdProd.Descripcion)
                    {
                        TotalStockProducto = int.Parse(objtDetalleCompra.Cantidad.ToString());
                        txtStock.Text = TotalStockProducto.ToString();
                        IdDetalleCompra = objtDetalleCompra.IdDetalleCompra;
                    }
                }
            }
        }

        private void gridViewDetalleVenta_Click(object sender, EventArgs e)
        {
            IsEliminar = true;
            CantidadStock = objtDetalleVenta.Stock;

            objtDetalleVenta = (DetalleVenta)gridViewDetalleVenta.GetFocusedRow();
        }

        private void radioButtonDolar_CheckedChanged(object sender, EventArgs e)
        {
            txtCordoba.Text = "0";
            FnEnableTextBoxCambio(false);
            txtDolar.Focus();
        }

        private void checkBoxDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDescuento.Checked)
            {
                FnEnableDescuento(true);
            }
            else
            {
                FnEnableDescuento(false);
            }
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            var MensajeAyuda = new ToolTip();
            MensajeAyuda.SetToolTip(searchCliente, "Nos permite seleccionar el cliente que se realizara la venta");
            MensajeAyuda.SetToolTip(comboBoxDocumento, "Nos permite seleccionar el documento de la venta");
            MensajeAyuda.SetToolTip(txtDocumento, "Agrega número del documento de la venta");
            MensajeAyuda.SetToolTip(searchProducto, "Nos permite agregar el producto de la venta");
            MensajeAyuda.SetToolTip(txtStock, "Stock de nustros productos");
            MensajeAyuda.SetToolTip(txtPrecio, "Agregar el precio del producto a vender");
            MensajeAyuda.SetToolTip(txtCantidad, "Agrega la cantidad de los productos a vender");
            MensajeAyuda.SetToolTip(btnCalcular, "Nos permite calcular el subtota de cada producto que se vendera");
            MensajeAyuda.SetToolTip(txtCalculoSubtotal, "Muestra el subtota de cada producto que se vendera");
            MensajeAyuda.SetToolTip(btnAgregar, "Agrega nuestros productos que se venderan");
            MensajeAyuda.SetToolTip(btnModificar, "Modifica los productos agregados a la tabla");
            MensajeAyuda.SetToolTip(btnEliminar, "Retira los productos agregados a la tabla");
            MensajeAyuda.SetToolTip(btnCancelar, "Cancela la modificación de productos agregados a la tabla");
            MensajeAyuda.SetToolTip(txtSubtotal, "Muestra el subtotal de la venta");
            MensajeAyuda.SetToolTip(txtDescuento, "Muestra el porcentaje del descuento de la venta");
            MensajeAyuda.SetToolTip(txtDescuentoTotal, "Muestra el descuento de la venta");
            MensajeAyuda.SetToolTip(txtMontototal, "Muestra el monto total de la venta");
            MensajeAyuda.SetToolTip(txtCordoba, "Moneda nacional para realizar el pago de la venta");
            MensajeAyuda.SetToolTip(txtDolar, "Moneda extranjera para realizar el pago de la venta");
            MensajeAyuda.SetToolTip(radioButtonCordoba, "Habilita la caja para agregar el pago cordoba");
            MensajeAyuda.SetToolTip(radioButtonDolar, "Habilita la caja para agregar el pago dolar");
            MensajeAyuda.SetToolTip(radioButtonDolar, "Habilita la caja para agregar el pago dolar");
            MensajeAyuda.SetToolTip(txtMontoPago, "Nos permite agregar el total del cambio realizado de dolar a cordoba");
            MensajeAyuda.SetToolTip(btnPegar, "Nos permite pegar lo que obtenemos del cambio del dolar, que esta en menu principal");
            MensajeAyuda.SetToolTip(txtMontoCambio, "Obtine el vuelto de la venta");
            MensajeAyuda.SetToolTip(btnPagar, "Realiza la venta si todo esta bien");
            MensajeAyuda.SetToolTip(btnGuardar, "Guarda la información de la venta en la base de datos");


            FnEnableButtonCancelar(false);
            comboBoxDocumento.SelectedIndex = 0;
            objtVenta = new Venta(SesionVenta);
            gridDetalleVenta.DataSource = objtVenta.DetalleVentas;

            FnEnableTextBoxCambio(true);
            FnEnableDescuento(false);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (FnValidarCamposVaciosAgregar())
            {
                MessageBox.Show("Debes de llenar todos los campos vacios", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (KeypressCalcular == false)
            {
                MessageBox.Show("Usted no ha calculado el subtotal del producto", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCalcular.Focus();
                return;
            }

            if (IsEditar == true)
            {
                MessageBox.Show("Usted esta editando un registro", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Seguro desea agregar el producto?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtDetalleVenta = new DetalleVenta(SesionVenta);

                objtDetalleVenta.IdProd = objtDetalleCompra.IdProd;
                objtDetalleVenta.PrecioVenta = decimal.Parse(txtPrecio.Text);
                objtDetalleVenta.Stock = int.Parse(txtCantidad.Value.ToString());
                ValorCantidad = ValorCantidad + Cantidad;
                objtDetalleVenta.SubTotal = decimal.Parse(txtCalculoSubtotal.Text);

                objtDetalleVenta.Save();
                objtVenta.DetalleVentas.Add(objtDetalleVenta);
                gridDetalleVenta.RefreshDataSource();

                if (txtCalculoSubtotal.Text == "")
                {
                    txtCalculoSubtotal.Text = Subtotal.ToString();
                }
                else
                {
                    txtCalculoSubtotal.Text = (Convert.ToDecimal(txtCalculoSubtotal.Text) + objtDetalleVenta.SubTotal).ToString();
                }

                if (txtSubtotal.Text == "")
                {
                    txtSubtotal.Text = Subtotal.ToString();
                }
                else
                {
                    txtSubtotal.Text = (Convert.ToDecimal(txtSubtotal.Text) + objtDetalleVenta.SubTotal).ToString();
                }
                FnUpdateDetalleCompra();
                FnClearDatosAgregar();
            }
        }
    }
}
