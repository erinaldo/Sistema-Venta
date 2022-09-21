using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemaventa.EstadoSistema
{
    public partial class FormEstadoProducto : Form
    {
        private static FormEstadoProducto ChilInstance = null;
        public static FormEstadoProducto Instance()
        {
            if (ChilInstance == null || ChilInstance.IsDisposed == true)
            {
                ChilInstance = new FormEstadoProducto();
            }
            ChilInstance.BringToFront();
            return ChilInstance;
        }
        public FormEstadoProducto()
        {
            InitializeComponent();
        }
    }
}
