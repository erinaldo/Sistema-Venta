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

namespace Sistemaventa.Forms
{
    public partial class FormRol : Form
    {
        bool IsEditar = false;

        Rol objtRol;
        CodeRepeatClass repeatClass = new CodeRepeatClass();
        private static FormRol ChilInstance = null;
        public static FormRol Instance()
        {
            if (ChilInstance == null || ChilInstance.IsDisposed == true)
            {
                ChilInstance = new FormRol();
            }
            ChilInstance.BringToFront();
            return ChilInstance;
        }
        public FormRol()
        {
            InitializeComponent();
        }
        private void FnClearDatos()
        {
            txtNombre.Clear();
            FnCheckedFalse(false);
        }
        private void FnCheckedFalse( bool v)
        {
            checkBoxMenuRol.Checked = v;
            checkBoxMenuEmpleado.Checked = v;
            checkBoxMenuMantenimiento.Checked = v;
            checkBoxMenuAlmacen.Checked = v;
            checkBoxMenuCompra.Checked = v;
            checkBoxMenuVenta.Checked = v;
            checkBoxMenuEstado.Checked = v;
            checkBoxMenuReporte.Checked = v;
        }

        private void FnEnableButton(bool v)
        {
            btnNuevo.Enabled = v;
            btnGuardar.Enabled = !v;
            btnModificar.Enabled = v;
        }

        private void FnActivarButtonCancelar(bool v)
        {
            btnCancelar.Enabled = !v;
        }

        private void FnEnabledatos(bool v)
        {
            txtNombre.Enabled = v;
            checkBoxMenuRol.Enabled = v;
            checkBoxMenuEmpleado.Enabled = v;
            checkBoxMenuMantenimiento.Enabled = v;
            checkBoxMenuAlmacen.Enabled = v;
            checkBoxMenuCompra.Enabled = v;
            checkBoxMenuVenta.Enabled = v;
            checkBoxMenuEstado.Enabled = v;
            checkBoxMenuReporte.Enabled = v;
            checkBoxMarcarTodo.Enabled = v;
        }
        private bool FnValidarCamposVacios()
        {
            return (txtNombre.Text.Trim().Length == 0);
        }
        private void checkBoxMarcarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxMarcarTodo.Checked)
            {
                FnCheckedFalse(true);
            }
            else
            {
                FnCheckedFalse(false);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if(IsEditar == true)
            {
                FnClearDatos();
                IsEditar = false;
            }
            FnEnableButton(false);
            FnEnabledatos(true);
            FnActivarButtonCancelar(false);
            txtNombre.Focus();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IsEditar = false;
            FnEnableButton(true);
            FnEnabledatos(false);
            FnClearDatos();
        }

        private void FormRol_Load(object sender, EventArgs e)
        {
            var MensajeAyuda = new ToolTip();
            MensajeAyuda.SetToolTip(txtNombre, "Agrega nombre del Rol a guardar");
            MensajeAyuda.SetToolTip(btnNuevo, "Permite agregar nuevo registro");
            MensajeAyuda.SetToolTip(btnGuardar, "Permite guardar un registro");
            MensajeAyuda.SetToolTip(btnModificar, "Permite modificar un registro");
            MensajeAyuda.SetToolTip(btnCancelar, "Cancela cualquier movimiento");
            MensajeAyuda.SetToolTip(checkBoxMenuRol, "Activa o desactiva este Rol");
            MensajeAyuda.SetToolTip(checkBoxMenuEmpleado, "Activa o desactiva este Rol");
            MensajeAyuda.SetToolTip(checkBoxMenuMantenimiento, "Activa o desactiva este Rol");
            MensajeAyuda.SetToolTip(checkBoxMenuAlmacen, "Activa o desactiva este Rol");
            MensajeAyuda.SetToolTip(checkBoxMenuCompra, "Activa o desactiva este Rol");
            MensajeAyuda.SetToolTip(checkBoxMenuVenta, "Activa o desactiva este Rol");
            MensajeAyuda.SetToolTip(checkBoxMenuEstado, "Activa o desactiva este Rol");
            MensajeAyuda.SetToolTip(checkBoxMenuReporte, "Activa o desactiva este Rol");

            FnEnableButton(true);
            FnEnabledatos(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(FnValidarCamposVacios())
            {
                MessageBox.Show("El nombre del rol no debe de estar vacío", repeatClass.Mensaje,MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("¿Seguro desea guardar el registro?",repeatClass.Mensaje,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objtRol = new Rol(SesionVenta);
                    objtRol.NombreRol = txtNombre.Text.Trim();

                    if (checkBoxMenuRol.Checked)
                    {
                        objtRol.MenuRol = true;
                    }
                    else
                    {
                        objtRol.MenuRol = false;
                    }

                    if (checkBoxMenuEmpleado.Checked)
                    {
                        objtRol.MenuEmpleado = true;
                    }
                    else
                    {
                        objtRol.MenuEmpleado = false;
                    }

                    if (checkBoxMenuMantenimiento.Checked)
                    {
                        objtRol.MenuMantenimiento = true;
                    }
                    else
                    {
                        objtRol.MenuMantenimiento = false;
                    }

                    if (checkBoxMenuAlmacen.Checked)
                    {
                        objtRol.MenuAlmacen = true;
                    }
                    else
                    {
                        objtRol.MenuAlmacen = false;
                    }

                    if (checkBoxMenuCompra.Checked)
                    {
                        objtRol.MenuCompra = true;
                    }
                    else
                    {
                        objtRol.MenuCompra = false;
                    }

                    if (checkBoxMenuVenta.Checked)
                    {
                        objtRol.MenuVenta = true;
                    }
                    else
                    {
                        objtRol.MenuVenta = false;
                    }

                    if (checkBoxMenuEstado.Checked)
                    {
                        objtRol.MenuEstado = true;
                    }
                    else
                    {
                        objtRol.MenuEstado = false;
                    }

                    if (checkBoxMenuReporte.Checked)
                    {
                        objtRol.MenuReporte = true;
                    }
                    else
                    {
                        objtRol.MenuReporte = false;
                    }

                    objtRol.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

                    objtRol.Save();
                    SesionVenta.CommitChanges();
                    MessageBox.Show("Su resgistro se guardo correctamente",repeatClass.Mensaje,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    xpRol.Reload();
                    FnEnableButton(true);
                    FnEnabledatos(false);
                    FnClearDatos();
                }
            }
        }

        private void gridViewRol_DoubleClick(object sender, EventArgs e)
        {
            IsEditar = true;
            txtNombre.Focus();

            if(xpRol.Count == 0)
            {
                MessageBox.Show("No existe ningún registro, debes de agregar registros",repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            objtRol = (Rol)gridViewRol.GetFocusedRow();
            txtNombre.Text = objtRol.NombreRol;

            if (objtRol.MenuRol == true)
            {
                checkBoxMenuRol.Checked = true;
            }
            else
            {
                checkBoxMenuRol.Checked = false;
            }

            if (objtRol.MenuEmpleado == true)
            {
                checkBoxMenuEmpleado.Checked = true;
            }
            else
            {
                checkBoxMenuEmpleado.Checked = false;
            }

            if (objtRol.MenuMantenimiento == true)
            {
                checkBoxMenuMantenimiento.Checked = true;
            }
            else
            {
                checkBoxMenuMantenimiento.Checked = false;
            }

            if (objtRol.MenuAlmacen == true)
            {
                checkBoxMenuAlmacen.Checked = true;
            }
            else
            {
                checkBoxMenuAlmacen.Checked = false;
            }

            if (objtRol.MenuCompra == true)
            {
                checkBoxMenuCompra.Checked = true;
            }
            else
            {
                checkBoxMenuCompra.Checked = false;
            }

            if (objtRol.MenuVenta == true)
            {
                checkBoxMenuVenta.Checked = true;
            }
            else
            {
                checkBoxMenuVenta.Checked = false;
            }

            if (objtRol.MenuEstado == true)
            {
                checkBoxMenuEstado.Checked = true;
            }
            else
            {
                checkBoxMenuEstado.Checked = false;
            }

            if (objtRol.MenuReporte == true)
            {
                checkBoxMenuReporte.Checked = true;
            }
            else
            {
                checkBoxMenuReporte.Checked = false;
            }

            if (checkBoxMenuRol.Checked == true & checkBoxMenuEmpleado.Checked == true & checkBoxMenuMantenimiento.Checked == true &
               checkBoxMenuAlmacen.Checked == true & checkBoxMenuCompra.Checked == true &&
               checkBoxMenuEstado.Checked == true & checkBoxMenuVenta.Checked == true & checkBoxMenuReporte.Checked == true)
            {
                checkBoxMarcarTodo.Checked = true;
            }

            FnEnableButton(true);
            FnEnabledatos(true);
            FnActivarButtonCancelar(false);
            txtNombre.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(xpRol.Count == 0)
            {
                MessageBox.Show("Aún no hay registro, debes de agregar uno para editarlo", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsEditar == false)
            {
                MessageBox.Show("Debes de seleccionar un registro de la tabla de registro", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNombre.Text == "")
            {
                MessageBox.Show("El nombre del Rol no debe de estar vacío", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("¿Seguro desea modificar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objtRol = (Rol)gridViewRol.GetFocusedRow();
                    objtRol.NombreRol = txtNombre.Text.Trim();

                    if (checkBoxMenuRol.Checked)
                    {
                        objtRol.MenuRol = true;
                    }
                    else
                    {
                        objtRol.MenuRol = false;
                    }

                    if (checkBoxMenuEmpleado.Checked)
                    {
                        objtRol.MenuEmpleado = true;
                    }
                    else
                    {
                        objtRol.MenuEmpleado = false;
                    }

                    if (checkBoxMenuMantenimiento.Checked)
                    {
                        objtRol.MenuMantenimiento = true;
                    }
                    else
                    {
                        objtRol.MenuMantenimiento = false;
                    }

                    if (checkBoxMenuAlmacen.Checked)
                    {
                        objtRol.MenuAlmacen = true;
                    }
                    else
                    {
                        objtRol.MenuAlmacen = false;
                    }

                    if (checkBoxMenuCompra.Checked)
                    {
                        objtRol.MenuCompra = true;
                    }
                    else
                    {
                        objtRol.MenuCompra = false;
                    }

                    if (checkBoxMenuVenta.Checked)
                    {
                        objtRol.MenuVenta = true;
                    }
                    else
                    {
                        objtRol.MenuVenta = false;
                    }

                    if (checkBoxMenuEstado.Checked)
                    {
                        objtRol.MenuEstado = true;
                    }
                    else
                    {
                        objtRol.MenuEstado = false;
                    }

                    if (checkBoxMenuReporte.Checked)
                    {
                        objtRol.MenuReporte = true;
                    }
                    else
                    {
                        objtRol.MenuReporte = false;
                    }

                    objtRol.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

                    objtRol.Save();
                    SesionVenta.CommitChanges();
                    MessageBox.Show("Su resgistro se modifico correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xpRol.Reload();
                    FnEnableButton(true);
                    FnEnabledatos(false);
                    FnClearDatos();
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassValidations.TextoSigno(e);
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.SelectAll();
        }
    }
}
