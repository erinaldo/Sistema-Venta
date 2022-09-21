using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistemaventa.AnimationsForm;
using DevExpress.Xpo.DB;
using Sistemaventa.Sistema_Venta;
using Sistemaventa.Class;
using Sistemaventa.NewUser;
using Sistemaventa.Forms;
using System.Data.SqlClient;
using MailKit.Net.Smtp;
using MimeKit;

namespace Sistemaventa
{
    public partial class FormLogin : Form
    {
        int Intentos = 0, Timeleft = 0;

        Tema objtTema;
        Rol objRol;
        CodeRepeatClass repeatClass = new CodeRepeatClass();
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FnClearTextBox()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtCorreo.Clear();
            comboBoxEmpleado.SelectedIndex = -1;
        }
        private void FnLabelMensajeVisible(bool v)
        {
            lblMensaje.Visible = v;
        }
        private void FnPanelVisible(bool v)
        {
            panelRestaurarContraseña.Visible = v;
        }
        private void FnEnableButton(bool v)
        {
            btnAcceder.Enabled = v;
        }
        private void FnLlenarComboxEmpleado()
        {
            if(xpEmpleado.Count != 0)
            {
                comboBoxEmpleado.DisplayMember = "Nombre";
                comboBoxEmpleado.ValueMember = "Nombre";
                comboBoxEmpleado.DataSource = xpEmpleado;
            }
        }
        private void FnAgregarRol()
        {
            string NombreRol = "Administración";
            bool Menu1 = true, Menu2 = true, Menu3 = true, Menu4 = true, Menu5 = true,
                Menu6 = true, Menu7 = true, Menu8 = true;

            objRol = new Rol(SesionVenta);
            objRol.NombreRol = NombreRol;

            objRol.MenuRol = Menu1;
            objRol.MenuEmpleado = Menu2;
            objRol.MenuMantenimiento = Menu3;
            objRol.MenuAlmacen = Menu4;
            objRol.MenuCompra = Menu5;
            objRol.MenuVenta = Menu6;
            objRol.MenuEstado = Menu7;
            objRol.MenuReporte = Menu8;

            objRol.FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString());

            objRol.Save();
            SesionVenta.CommitChanges();
            xpRol.Reload();
        }
        private void FnAgregarTodosTema()
        {
            SelectedData spStoredProc = SesionVenta.ExecuteSproc("spEjecutarAgregar", "spAgregarTema");
        }
        private void FnAgregarCambioDolar()
        {
            SelectedData spStoredProc = SesionVenta.ExecuteSproc("spExecInsertarCambioDoalr", "spInsertarCambioDolar");
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (xpRol.Count == 0)
            {
                FnAgregarRol();
            }

            if (xpTema.Count == 0)
            {
                FnAgregarTodosTema();
                FnAgregarCambioDolar();
            }
            var MensajeAyuda = new ToolTip();
            MensajeAyuda.SetToolTip(txtUsuario, "Escribe tu acceso");
            MensajeAyuda.SetToolTip(txtContraseña, "Escribe tu contraseña");
            MensajeAyuda.SetToolTip(btnAcceder, "Accede al menú principal");
            MensajeAyuda.SetToolTip(checkBoxMostrar, "Muestra su contraseña");

            FnLlenarComboxEmpleado();
            FnLabelMensajeVisible(false);
            FnPanelVisible(false);

            if (xpEmpleado.Count == 0)
            {
                FnLabelMensajeVisible(true);
                btnAgregarUsuario.Enabled = true;
            }
            else
            {
                FnLabelMensajeVisible(false);
                btnAgregarUsuario.Enabled = false;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.SelectAll();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Application.ExitThread();
        }

        private void checkBoxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            string Contraseña = txtContraseña.Text;
            if (checkBoxMostrar.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
                txtContraseña.Text = Contraseña;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
                txtContraseña.Text = Contraseña;
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Hide();
            FormNuevoUsuario formulario = new FormNuevoUsuario();
            formulario.Show();
        }

        private void timerIntentos_Tick(object sender, EventArgs e)
        {
            if (Timeleft > 0)
            {
                Timeleft = Timeleft - 1;
                lblMensaje.Text = "Debe esperar: " + Timeleft + " Segundos";
            }
            else
            {
                timerIntentos.Stop();
                MessageBox.Show("Ya puede intentar acceder", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                this.ControlBox = true;
                FnEnableButton(true);
                FnLabelMensajeVisible(false);
                FnClearTextBox();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FnPanelVisible(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea cancelar la solicitud de envio de correo?", repeatClass.Mensaje,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FnPanelVisible(false);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            foreach (Empleado item in xpEmpleado)
            {
                if (txtCorreo.Text != "")
                {
                    if (txtCorreo.Text == item.Correo && comboBoxEmpleado.Text == item.Nombre)
                    {
                        lblContraseña.Text = item.Contrasena;
                        lblLogin.Text = item.NombreAcceso;

                        var message = new MimeMessage();
                        message.From.Add(new MailboxAddress("ARC Venta", "ventasistemaventacesar@gmail.com"));
                        message.To.Add(new MailboxAddress(item.IdRol.NombreRol, item.Correo));
                        message.Subject = "ACR Venta: Recuperación de contraseña ";

                        message.Body = new TextPart("html")
                        {
                            Text = richTextBox1.Text.Replace("@Pass", lblContraseña.Text).Replace("@NombreAcceso", lblLogin.Text)
                        };

                        using (var client = new SmtpClient())
                        {
                            client.Connect("smtp.gmail.com", 587, false);
                            client.Authenticate("ventasistemaventacesar@gmail.com", "jhdmrxtmrxrecnoi");
                            client.Send(message);
                            client.Disconnect(true);

                            MessageBox.Show("Se ha enviado la contraseña y su acceso del login a su correo", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FnClearTextBox();
                            FnPanelVisible(false);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debes de agregar el correo", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCorreo.Focus();
                    return;
                }
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.SelectAll();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            FnLabelMensajeVisible(false);
            Intentos += 1;
            if (Intentos > 5)
            {
                FnEnableButton(true);
                lblMensaje.Text = "No tiene Acceso...";
                MessageBox.Show("Llego al limite de intentos para acceder, intentelo más tarde..." + "\r\n" +
                   "Debe de esperar 30 segundos para volver acceder" + "\r\n" +
                  "No tiene Acceso...", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                FnLabelMensajeVisible(true);
                Timeleft = 30;
                lblMensaje.Text = "Debe esperar: 30 segundos";
                timerIntentos.Start();
                this.ControlBox = false;
                FnEnableButton(false);
                Intentos = 0;
            }

            foreach (Tema item in xpTema)
            {
                foreach (Empleado empleado in xpEmpleado)
                {
                    foreach (CambioDolar cambioDolar in xpCambioDolar)
                    {
                        if (xpEmpleado != null)
                        {
                            if (empleado.NombreAcceso == txtUsuario.Text && empleado.Contrasena == txtContraseña.Text)
                            {
                                if (item.IdTema == empleado.IdTema.IdTema)
                                {
                                    item.ToString();
                                }
                                Hide();
                                FormAnimation formAnimacion = new FormAnimation(empleado);
                                formAnimacion.ShowDialog();
                                FormPrincipal formPrincipal = new FormPrincipal(empleado, item, cambioDolar);
                                lblMensaje.Visible = false;
                                formPrincipal.Show();

                                if (checkBoxMostrar.Checked)
                                {
                                    checkBoxMostrar.Checked = false;
                                }
                                FnClearTextBox();
                            }
                            else
                            {
                                FnLabelMensajeVisible(true);
                                lblMensaje.Text = "El Empleado no existe";
                            }
                        }
                    }
                }
            }
        }
    }
}
