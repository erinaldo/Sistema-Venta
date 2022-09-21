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

namespace Sistemaventa.ViewList
{
    public partial class FormListViewCompra : Form
    {
        CodeRepeatClass repeatClass = new CodeRepeatClass();
        private static FormListViewCompra ChildIntance = null;
        public static FormListViewCompra Instance()
        {
            if (ChildIntance == null || ChildIntance.IsDisposed == true)
            {
                ChildIntance = new FormListViewCompra();
            }
            ChildIntance.BringToFront();
            return ChildIntance;
        }
        public FormListViewCompra()
        {
            InitializeComponent();
        }

        private void FormListViewCompra_Load(object sender, EventArgs e)
        {
            if (xpCompra.Count == 0)
            {
                MessageBox.Show("Aún no hay registro de compras", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
