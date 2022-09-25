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
    public partial class FormCancelarCompra : Form
    {
        bool IsEliminar = false;

        Compra objtCompra;
        CodeRepeatClass repeatClass = new CodeRepeatClass();
        private static FormCancelarCompra ChilInstance = null;
        public static FormCancelarCompra Instance()
        {
            if (ChilInstance == null || ChilInstance.IsDisposed == true)
            {
                ChilInstance = new FormCancelarCompra();
            }
            ChilInstance.BringToFront();
            return ChilInstance;
        }
        public FormCancelarCompra()
        {
            InitializeComponent();
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            if(IsEliminar == false)
            {
                MessageBox.Show("Debes de seleccionar el registro a cancelar", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Seguro desea cancelar esta compra?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtCompra = (Compra)gridViewCompra.GetFocusedRow();
                SesionVenta.Delete(objtCompra);
                SesionVenta.CommitChanges();
                MessageBox.Show("La compra se cancelo correctamente", repeatClass.Mensaje,MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpCompra.Reload();
                IsEliminar = false;
            }
        }

        private void gridViewCompra_Click(object sender, EventArgs e)
        {
            IsEliminar = true;
        }
    }
}
