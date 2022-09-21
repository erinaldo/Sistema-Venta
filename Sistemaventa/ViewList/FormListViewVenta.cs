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
    public partial class FormListViewVenta : Form
    {
        CodeRepeatClass repeatClass = new CodeRepeatClass();
        private static FormListViewVenta ChildIntance = null;
        public static FormListViewVenta Instance()
        {
            if (ChildIntance == null || ChildIntance.IsDisposed == true)
            {
                ChildIntance = new FormListViewVenta();
            }
            ChildIntance.BringToFront();
            return ChildIntance;
        }
        public FormListViewVenta()
        {
            InitializeComponent();
        }

        private void FormListViewVenta_Load(object sender, EventArgs e)
        {
            if (xpVenta.Count == 0)
            {
                MessageBox.Show("Aún no hay registro de ventas", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
