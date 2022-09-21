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

namespace Sistemaventa.AnimationsForm
{
    public partial class FormAnimation : Form
    {
        Empleado objtEmpleado;
        public FormAnimation(Empleado empleado = null)
        {
            objtEmpleado = empleado;
            InitializeComponent();
        }

        private void timerInicio_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1) Opacity += 1;
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100)
            {
                timerInicio.Stop();
                timerFinal.Start();
            }
        }

        private void timerFinal_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.1;
            if (Opacity == 0)
            {
                timerFinal.Stop();
                Close();
            }
        }

        private void FormAnimation_Load(object sender, EventArgs e)
        {
            Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timerInicio.Start();

            lblNombre.Text = objtEmpleado.Nombre_Completo;
            lblRol.Text = objtEmpleado.IdRol.NombreRol;

            CodeRepeatClass codeRepeatClass = new CodeRepeatClass();
            pictureBoxFoto.Image = codeRepeatClass.ByteToImage(objtEmpleado.Foto);
        }
    }
}
