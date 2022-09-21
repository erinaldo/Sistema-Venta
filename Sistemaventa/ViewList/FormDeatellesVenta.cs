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
    public partial class FormDeatellesVenta : Form
    {
        CodeRepeatClass repeatClass = new CodeRepeatClass();
        private static FormDeatellesVenta ChildIntance = null;
        public static FormDeatellesVenta Instance()
        {
            if (ChildIntance == null || ChildIntance.IsDisposed == true)
            {
                ChildIntance = new FormDeatellesVenta();
            }
            ChildIntance.BringToFront();
            return ChildIntance;
        }
        public FormDeatellesVenta()
        {
            InitializeComponent();
        }

        private void FormDeatellesVenta_Load(object sender, EventArgs e)
        {
            if (xpDetalleVenta.Count == 0)
            {
                MessageBox.Show("Aún no hay registro de ventas", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
