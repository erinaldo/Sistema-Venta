using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistemaventa.Class;

namespace Sistemaventa.ViewList
{
    public partial class FormDetallesCompra : Form
    {
        CodeRepeatClass repeatClass = new CodeRepeatClass();
        private static FormDetallesCompra ChildIntance = null;
        public static FormDetallesCompra Instance()
        {
            if (ChildIntance == null || ChildIntance.IsDisposed == true)
            {
                ChildIntance = new FormDetallesCompra();
            }
            ChildIntance.BringToFront();
            return ChildIntance;
        }
        public FormDetallesCompra()
        {
            InitializeComponent();
        }

        private void FormDetallesCompra_Load(object sender, EventArgs e)
        {
            if (xpDetallesCompra.Count == 0)
            {
                MessageBox.Show("Aún no hay registro de compras", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
