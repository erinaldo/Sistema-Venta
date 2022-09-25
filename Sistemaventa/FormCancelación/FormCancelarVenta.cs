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

namespace Sistemaventa.FormCancelación
{
    public partial class FormCancelarVenta : Form
    {
        int IdVenta, Resultado;
        bool IsEliminar = false;

        Venta objtVenta;
        DetalleVenta objtDetalleVenta;
        CodeRepeatClass repeatClass = new CodeRepeatClass();
        private static FormCancelarVenta ChilInstance = null;
        public static FormCancelarVenta Instance()
        {
            if (ChilInstance == null || ChilInstance.IsDisposed == true)
            {
                ChilInstance = new FormCancelarVenta();
            }
            ChilInstance.BringToFront();
            return ChilInstance;
        }
        public FormCancelarVenta()
        {
            InitializeComponent();
        }
        private void gridViewVenta_Click(object sender, EventArgs e)
        {
            objtVenta = (Venta)gridViewVenta.GetFocusedRow();
            IdVenta = objtVenta.IdVenta;

            IsEliminar = true;
        }
        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (IsEliminar == false)
            {
                MessageBox.Show("Debes de seleccionar el registro a cancelar", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Seguro desea cancelar esta venta?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtVenta = (Venta)gridViewVenta.GetFocusedRow();
                SesionVenta.Delete(objtVenta);
                SesionVenta.CommitChanges();
                MessageBox.Show("La venta se cancelo correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpVenta.Reload();
                IsEliminar = false;
            }
        }
    }
}
