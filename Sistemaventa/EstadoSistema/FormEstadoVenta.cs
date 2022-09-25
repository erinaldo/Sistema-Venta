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

namespace Sistemaventa.EstadoSistema
{
    public partial class FormEstadoVenta : Form
    {
        bool IsEditar = false;
        int Valorventa, ValorProducto;

        Producto objtProducto;
        Venta objtVenta;
        EstadoVenta objtEstadoventa;
        CodeRepeatClass repeatClass = new CodeRepeatClass();
        private static FormEstadoVenta ChilInstance = null;
        public static FormEstadoVenta Instance()
        {
            if (ChilInstance == null || ChilInstance.IsDisposed == true)
            {
                ChilInstance = new FormEstadoVenta();
            }
            ChilInstance.BringToFront();
            return ChilInstance;
        }
        public FormEstadoVenta()
        {
            InitializeComponent();
        }
        private bool FnCamposVacios()
        {
            return (searchLookProductos.EditValue == null || searchLookVentas.EditValue == null || comboBoxEstado.SelectedIndex == -1);
        }
        private void FnClearDatosGuardar()
        {
            searchLookProductos.EditValue = null;
            searchLookVentas.EditValue = null;
            comboBoxEstado.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(IsEditar == true)
            {
                MessageBox.Show("Usted se encuentra modificando, si desea editar presione el boton modificar", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnModificar.Focus();
                return;
            }

            if(FnCamposVacios())
            {
                MessageBox.Show("Debes de llenar todos los campos vacíos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Seguro desea guardar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtEstadoventa = new EstadoVenta(SesionVenta);
                objtEstadoventa.IdVenta = (Venta)searchLookViewVentas.GetFocusedRow();
                objtEstadoventa.IdProducto = (Producto)searchLookViewProductos.GetFocusedRow();
                objtEstadoventa.Estado = comboBoxEstado.Text;
                objtEstadoventa.FechaDevolucion = Convert.ToDateTime(DateTime.Now.ToString());

                objtEstadoventa.Save();
                SesionVenta.CommitChanges();
                MessageBox.Show("Su registro se guardo correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpEstadoVenta.Reload();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (FnCamposVacios())
            {
                MessageBox.Show("Debes de llenar todos los campos vacíos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Seguro desea modificar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtEstadoventa = (EstadoVenta)gridViewEstadoVenta.GetFocusedRow();
                objtEstadoventa.IdVenta = (Venta)searchLookViewVentas.GetFocusedRow();
                objtEstadoventa.IdProducto = (Producto)searchLookViewProductos.GetFocusedRow();
                objtEstadoventa.Estado = comboBoxEstado.Text;
                objtEstadoventa.FechaDevolucion = Convert.ToDateTime(DateTime.Now.ToString());

                objtEstadoventa.Save();
                SesionVenta.CommitChanges();
                MessageBox.Show("Su registro se modifico correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpEstadoVenta.Reload();
            }
        }

        private void gridViewEstadoVenta_DoubleClick(object sender, EventArgs e)
        {
            if (xpEstadoVenta.Count == 0)
            {
                MessageBox.Show("Aún no existe ningún registro, debes de agregar registros", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IsEditar = true;

            objtEstadoventa = (EstadoVenta)gridViewEstadoVenta.GetFocusedRow();

            searchLookVentas.EditValue = objtEstadoventa.IdVenta.IdVenta;
            searchLookProductos.EditValue = objtEstadoventa.IdProducto.IdProd;
            Valorventa = objtEstadoventa.IdVenta.IdVenta;
            ValorProducto = objtEstadoventa.IdProducto.IdProd;

            comboBoxEstado.Text = objtEstadoventa.Estado;
        }
    }
}
