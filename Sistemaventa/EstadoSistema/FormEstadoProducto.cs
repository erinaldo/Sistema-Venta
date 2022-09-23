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
    public partial class FormEstadoProducto : Form
    {
        bool IsEditar = false;
        int ValorRol;

        CodeRepeatClass repeatClass = new CodeRepeatClass();
        Producto objtProducto;
        EstadoProducto objtEstadoProducto;
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
        private bool FnValidarCamposGuardar()
        {
            return (searchProducto.EditValue == null || comboBoxEstado.SelectedIndex == -1);
        }
        private void FnClearDatos()
        {
            searchProducto.EditValue = null;
            comboBoxEstado.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(IsEditar == true)
            {
                MessageBox.Show("En este momento usted esta modificando, si desea modificar presione el boton modificar", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(FnValidarCamposGuardar())
            {
                MessageBox.Show("Debes de llenar todos los campos vacíos", repeatClass.Mensaje,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Seguro desea guardar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtEstadoProducto = new EstadoProducto(SesionVenta);
                objtEstadoProducto.IdProducto = (Producto)searchViewProducto.GetFocusedRow();
                objtEstadoProducto.Estado = comboBoxEstado.Text;
                objtEstadoProducto.Fecha = Convert.ToDateTime(DateTime.Now.ToString());

                objtEstadoProducto.Save();
                SesionVenta.CommitChanges();
                MessageBox.Show("Su registro se guardo correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpEstadoProducto.Reload();
            }
        }

        private void gridViewEstadoProducto_DoubleClick(object sender, EventArgs e)
        {
            if (xpEstadoProducto.Count == 0)
            {
                MessageBox.Show("Aún no existe ningún registro, debes de agregar registros", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IsEditar = true;

            objtEstadoProducto = (EstadoProducto)gridViewEstadoProducto.GetFocusedRow();

            searchProducto.EditValue = objtEstadoProducto.IdProducto.IdProd;
            ValorRol = objtEstadoProducto.IdProducto.IdProd;

            comboBoxEstado.Text = objtEstadoProducto.Estado;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (FnValidarCamposGuardar())
            {
                MessageBox.Show("Debes de llenar todos los campos vacíos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Seguro desea editar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtEstadoProducto = (EstadoProducto)gridViewEstadoProducto.GetFocusedRow();
                objtEstadoProducto.IdProducto = (Producto)searchViewProducto.GetFocusedRow();
                objtEstadoProducto.Estado = comboBoxEstado.Text;
                objtEstadoProducto.Fecha = Convert.ToDateTime(DateTime.Now.ToString());

                objtEstadoProducto.Save();
                SesionVenta.CommitChanges();
                MessageBox.Show("Su registro se edito correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpEstadoProducto.Reload();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FnClearDatos();
        }
    }
}
