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
using Sistemaventa.Sistema_Venta;
using DevExpress.UserSkins;
using DevExpress.Xpo.DB;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using Sistemaventa.ViewList;
using Sistemaventa.EstadoSistema;

namespace Sistemaventa.Forms
{
    public partial class FormPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static Empleado objtEmpleado;
        public static Tema objtTema;
        public static CambioDolar objtDolar;
        Producto objtProducto;

        CodeRepeatClass repeatClass = new CodeRepeatClass();

        string ValorDolar = "", NombreTema = "";
        double ResultadoVentaDolar;
        public FormPrincipal(Empleado empleado = null, Tema tema = null, CambioDolar dolar = null)
        {
            objtEmpleado = empleado;
            objtTema = tema;
            objtDolar = dolar;
            InitializeComponent();
        }
        private void FnEnableButton(bool v)
        {
            btnRol.Enabled = v;
            btnEmpleado.Enabled = v;
            btnTienda.Enabled = v;
            btnCopia.Enabled = v;
            btnRestauracion.Enabled = v;
            btnCategoria.Enabled = v;
            btnMarca.Enabled = v;
            btnProducto.Enabled = v;
            btnProveedor.Enabled = v;
            btnListaCompra.Enabled = v;
            btnDetallesCompra.Enabled = v;
            btnCompra.Enabled = v;
            btnListaVenta.Enabled = v;
            btnDetallesVenta.Enabled = v;
            btnVenta.Enabled = v;
            btnEstadoProducto.Enabled = v;
            btnEstadoVenta.Enabled = v;
            btnReporteCompra.Enabled = v;
            btnReporteVenta.Enabled = v;
            btnAcercade.Enabled = v;
            btnGuardarTema.Enabled = v;
            btnEditarDatos.Enabled = v;
            btnCambioDolar.Enabled = v;
        }
        private void FnpanelCambioDolarVisible(bool v)
        {
            panelCambioDolar.Visible = v;
        }
        private void FnClearResultadoDolar()
        {
            ResultadoVentaDolar = 0;
        }
        private void FnCalcularVentaDolar()
        {
            ResultadoVentaDolar = Convert.ToInt32(txtDolar.Text) * Convert.ToDouble(txtCambio.Text);

            txtCordoba.Text = ResultadoVentaDolar.ToString();
        }
        private void FnModificarCambioDolar()
        {
            txtCambio.Text = txtCambio.Text.Replace('.', ',');

            objtDolar.ValorDolar = Convert.ToDecimal(txtCambio.Text);
            objtDolar.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

            objtDolar.Save();
            objtDolar = SesionVenta.GetObjectByKey<CambioDolar>(objtDolar.Id);
            SesionVenta.CommitChanges();
            xpCambioDolar.Reload();
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea salir?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnCambioDolar_Click(object sender, EventArgs e)
        {
            FnpanelCambioDolarVisible(true);
            txtCambio.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea cancelar la actualización del dolar?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FnpanelCambioDolarVisible(false);
            }
        }
        FormEditarEmpleado formeditarUsuario;
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (FormEditarEmpleado.IsEditarActivo == true)
            {
                formeditarUsuario.Close();
            }

            if (MessageBox.Show("¿Seguro desea cerrar sesión?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormLogin formularioLogin = new FormLogin();
                this.Hide();
                formularioLogin.Show();
            }
        }

        private void btnRol_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormRol formularioHijo = FormRol.Instance();
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void btnEmpleado_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormEmpleado formularioHijo = FormEmpleado.Instance();
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void btnEditarDatos_Click(object sender, EventArgs e)
        {
            formeditarUsuario = FormEditarEmpleado.Instance();
            formeditarUsuario.MdiParent = this;
            formeditarUsuario.WindowState = FormWindowState.Maximized;
            formeditarUsuario.Show();
        }

        private void btnTienda_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormTienda formularioHijo = FormTienda.Instance();
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void btnCategoria_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormCategoria formularioHijo = FormCategoria.Instance();
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void btnMarca_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormMarca formularioHijo = FormMarca.Instance();
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void btnProducto_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormProducto formularioHijo = FormProducto.Instance(objtEmpleado);
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void btnProveedor_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormProveedor formularioHijo = FormProveedor.Instance();
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void btnListaCompra_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormListViewCompra formularioHijo = FormListViewCompra.Instance();
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void btnDetallesCompra_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDetallesCompra formularioHijo = FormDetallesCompra.Instance();
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void btnCompra_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormCompra formularioHijo = FormCompra.Instance(objtEmpleado);
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void btnCliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormCliente formularioHijo = FormCliente.Instance();
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void btnListaVenta_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormListViewVenta formularioHijo = FormListViewVenta.Instance();
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void btnDetallesVenta_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDeatellesVenta formularioHijo = FormDeatellesVenta.Instance();
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void btnActualizarCambio_Click(object sender, EventArgs e)
        {
            if (txtCambio.Text == "")
            {
                MessageBox.Show("Debes de agregar el tipo de cambio", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCambio.Focus();
                return;
            }
            else if (ValorDolar == "")
            {
                if (MessageBox.Show("¿Seguro desea guardar el tipo de cambio?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtCambio.Text = txtCambio.Text.Replace('.', ',');

                    objtDolar = new CambioDolar(SesionVenta);
                    objtDolar.ValorDolar = Convert.ToDecimal(txtCambio.Text);
                    objtDolar.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

                    objtDolar.Save();
                    MessageBox.Show("El Cambio del Dolar se guardo correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SesionVenta.CommitChanges();
                    xpCambioDolar.Reload();
                }
            }
            else
            {
                int KeypressModificar = 1;
                FnModificarCambioDolar();
                if(KeypressModificar == 1)
                {
                    if (MessageBox.Show("¿Seguro desea editar el cambio del Dolar?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FnModificarCambioDolar();
                        MessageBox.Show("El cambio del dolar se ha modificado", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDolar.Text = "0";
            txtCordoba.Text = "0";
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCordoba.Text);
        }

        private void btnCalcularMonto_Click(object sender, EventArgs e)
        {
            int ValorDolar;
            if (txtDolar.Text == "")
            {
                MessageBox.Show("El campo dolar no debe de estar vacio", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDolar.Focus();
                return;
            }

            ValorDolar = int.Parse(txtDolar.Text);
            if(ValorDolar <= 0)
            {
                MessageBox.Show("El valor del dolar no debe de ser cero, o menor a cero", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDolar.Focus();
                return;
            }

            FnCalcularVentaDolar();
            FnClearResultadoDolar();
        }

        private void txtCambio_Enter(object sender, EventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.SelectAll();
        }

        private void btnVenta_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormVenta formularioHijo = FormVenta.Instance(objtEmpleado, objtDolar);
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void skinRibbonGalleryBarItem1_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            NombreTema = (string)e.Item.Tag;
        }

        private void btnGuardarTema_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Tema item in xpTema)
            {
                if (item.NombreTema == NombreTema)
                {
                    if (MessageBox.Show("¿Seguro desea cambiar el Tema?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SelectedData spStoredProc = SesionVenta.ExecuteSproc("spModificarTema", objtEmpleado.Id, item.IdTema);
                        MessageBox.Show("Su tema se actualizo", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnEstadoProducto_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormEstadoProducto formularioHijo = FormEstadoProducto.Instance();
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void btnEstadoVenta_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormEstadoVenta formularioHijo = FormEstadoVenta.Instance();
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            FnpanelCambioDolarVisible(false);

            if (xpCambioDolar.Count != 0)
            {
                foreach (CambioDolar item in xpCambioDolar)
                {
                    ValorDolar = item.ValorDolar.ToString();

                    txtCambio.Text = ValorDolar;
                }
            }

            foreach (Producto item in xpProducto)
            {
                string FechaVence = "", InformacionEsatdo = "Vencido";
                FechaVence = DateTime.Now.ToShortDateString();
                if(item.FechaVence == FechaVence)
                {
                    EstadoProducto objtEstadoProducto = new EstadoProducto(SesionVenta);
                    objtEstadoProducto.IdProducto = item;
                    objtEstadoProducto.Estado = InformacionEsatdo;
                    objtEstadoProducto.Fecha = Convert.ToDateTime(DateTime.Now.ToString());

                    objtEstadoProducto.Save();
                    SesionVenta.CommitChanges();
                    xpEstadoProducto.Reload();
                }
            }

            foreach (Empleado item in xpEmpleado)
            {
                lblUsuario.Text = "Usuario: " + objtEmpleado.IdRol.NombreRol;

                BonusSkins.Register();
                SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem1);
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(objtEmpleado.IdTema.NombreTema);

                pictureBoxFoto.Image = repeatClass.ByteToImage(objtEmpleado.Foto);

                if (objtEmpleado.Estado == false)
                {
                    FnEnableButton(false);
                    MessageBox.Show("Esta cuenta esta Inactiva" + "\r\n" + "\r\n" +
                        "Solicita al administrador Activar su cuenta", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(item.IdRol.NombreRol == "Administración")
                {
                    btnEliminarVenta.Enabled = true;
                    btnEliminarCompra.Enabled = true;
                }
                else
                {
                    btnEliminarVenta.Enabled = false;
                    btnEliminarCompra.Enabled = false;
                }


                if (objtEmpleado.IdRol.MenuRol == true)
                {
                    btnRol.Enabled = true;
                }
                else
                {
                    btnRol.Enabled = false;
                }

                if (objtEmpleado.IdRol.MenuEmpleado == true)
                {
                    btnEmpleado.Enabled = true;
                }
                else
                {
                    btnEmpleado.Enabled = false;
                }

                if (objtEmpleado.IdRol.MenuMantenimiento == true)
                {
                    btnTienda.Enabled = true;
                    btnCopia.Enabled = true;
                    btnRestauracion.Enabled = true;
                }
                else
                {
                    btnTienda.Enabled = false;
                    btnCopia.Enabled = false;
                    btnRestauracion.Enabled = false;
                }
                if (objtEmpleado.IdRol.MenuAlmacen == true)
                {
                    btnCategoria.Enabled = true;
                    btnMarca.Enabled = true;
                    btnProducto.Enabled = true;
                }
                else
                {
                    btnCategoria.Enabled = false;
                    btnMarca.Enabled = false;
                    btnProducto.Enabled = false;
                }

                if (objtEmpleado.IdRol.MenuCompra == true)
                {
                    btnProveedor.Enabled = true;
                    btnCompra.Enabled = true;
                    btnListaCompra.Enabled = true;
                    btnDetallesCompra.Enabled = true;
                }
                else
                {
                    btnProveedor.Enabled = false;
                    btnCompra.Enabled = false;
                    btnListaCompra.Enabled = false;
                    btnDetallesCompra.Enabled = false;
                }

                if (objtEmpleado.IdRol.MenuVenta == true)
                {
                    btnCliente.Enabled = true;
                    btnVenta.Enabled = true;
                    btnListaVenta.Enabled = true;
                    btnDetallesVenta.Enabled = true;
                }
                else
                {
                    btnCliente.Enabled = false;
                    btnVenta.Enabled = false;
                    btnListaVenta.Enabled = false;
                    btnDetallesVenta.Enabled = false;
                }

                if (objtEmpleado.IdRol.MenuEstado == true)
                {
                    btnEstadoProducto.Enabled = true;
                    btnEstadoVenta.Enabled = true;
                }
                else
                {
                    btnEstadoProducto.Enabled = false;
                    btnEstadoVenta.Enabled = false;
                }

                if (objtEmpleado.IdRol.MenuReporte == true)
                {
                    btnReporteCompra.Enabled = true;
                    btnReporteVenta.Enabled = true;
                }
                else
                {
                    btnReporteCompra.Enabled = false;
                    btnReporteVenta.Enabled = false;
                }

                var MensajeAyuda = new ToolTip();
                MensajeAyuda.SetToolTip(lblUsuario, objtEmpleado.Nombre_Completo);
                MensajeAyuda.SetToolTip(btnCerrarSesion, "Cerrar sesión e iniciar nuevo usuario");
                MensajeAyuda.SetToolTip(btnEditarDatos, "Permite editar nuestra información");
            }
        }
    }
}
