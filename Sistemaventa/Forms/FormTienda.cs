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
    public partial class FormTienda : Form
    {
        CodeRepeatClass repeatClass = new CodeRepeatClass();

        Negocio objtTienda;
        private static FormTienda ChilInstance = null;
        public static FormTienda Instance()
        {
            if (ChilInstance == null || ChilInstance.IsDisposed == true)
            {
                ChilInstance = new FormTienda();
            }
            ChilInstance.BringToFront();
            return ChilInstance;
        }
        public FormTienda()
        {
            InitializeComponent();
        }

        private void FnEnableButton(bool v)
        {
            btnGuardar.Enabled = v;
        }
        private bool FnValidarCamposVacios()
        {
            return (txtNombre.Text.Trim().Length == 0 || txtRUC.Text.Trim().Length == 0 ||
                txtDireccion.Text.Trim().Length == 0);
        }
        private void pictureBoxLogotipo_Click(object sender, EventArgs e)
        {
            repeatClass.FnAbrirImangen(pictureBoxLogotipo);
        }

        private void pictureBoxLogotipo_DragDrop(object sender, DragEventArgs e)
        {
            repeatClass.FnDragDropPictureBox(sender, e, pictureBoxLogotipo);
        }

        private void pictureBoxLogotipo_DragEnter(object sender, DragEventArgs e)
        {
            repeatClass.FnCopyPictureBox(sender, e);
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.SelectAll();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

           if(FnValidarCamposVacios())
            {
                MessageBox.Show("Debes de llenar todos los campos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Seguro desea guardar el registro?", repeatClass.Mensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtTienda = new Negocio(SesionVenta);
                objtTienda.Nombre = txtNombre.Text;
                objtTienda.RUC = txtRUC.Text;

                objtTienda.Logo = repeatClass.ConvertImag(pictureBoxLogotipo);

                objtTienda.Save();
                SesionVenta.CommitChanges();
                MessageBox.Show("Su regsitro se guardo correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                xpTienda.Reload();
                FnEnableButton(false);
            }
        }

        private void FormTienda_Load(object sender, EventArgs e)
        {
            var MensajeAyuda = new ToolTip();
            MensajeAyuda.SetToolTip(txtNombre, "Agrega el nombre de la empresa");
            MensajeAyuda.SetToolTip(txtRUC, "Agrega el RUC de la empresa");
            MensajeAyuda.SetToolTip(txtDireccion, "Agrega la dirección o ubicación de la empresa");
            MensajeAyuda.SetToolTip(btnGuardar, "Nos permite guardar los datos de la empresa");
            MensajeAyuda.SetToolTip(btnModificar, "Nos permite editar los datos de la empresa");

            foreach (Negocio item in xpTienda)
            {
                if(xpTienda.Count != 0)
                {
                    txtNombre.Text = item.Nombre;
                    txtRUC.Text = item.RUC;
                    txtDireccion.Text = item.Direccion;

                    pictureBoxLogotipo.Image = repeatClass.ByteToImage(item.Logo);
                }
                txtNombre.Focus();
            }

            if (xpTienda.Count == 0)
            {
                FnEnableButton(true);
            }
            else
            {
                FnEnableButton(false);
            }
        }
        private void FnModificar()
        {
            objtTienda.Nombre = txtNombre.Text;
            objtTienda.RUC = txtRUC.Text;

            objtTienda.Logo = repeatClass.ConvertImag(pictureBoxLogotipo);

            objtTienda.Save();
            objtTienda = SesionVenta.GetObjectByKey<Negocio>(objtTienda.IdNegocio);
            SesionVenta.CommitChanges();
            xpTienda.Reload();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int EditarPress = 1;
            if (FnValidarCamposVacios())
            {
                MessageBox.Show("Debes de llenar todos los campos", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FnModificar();
            if (EditarPress == 1)
            {
                if (MessageBox.Show("¿Seguro desea editar el registro?", repeatClass.Mensaje,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FnModificar();
                    MessageBox.Show("Su regsitro se edito correctamente", repeatClass.Mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassValidations.NumberValidation(e);
        }
    }
}
