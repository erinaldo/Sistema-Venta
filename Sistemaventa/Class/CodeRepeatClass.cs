using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemaventa.Class
{
    public class CodeRepeatClass
    {
        public string Mensaje = "Sistema Venta";
        public byte[] ConverTextbox(TextBox textBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            return memoryStream.GetBuffer();
        }
        public byte[] ConvertImag(PictureBox pictureBoxFoto)
        {
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            pictureBoxFoto.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            return memoryStream.GetBuffer();
        }
        public Image ByteToImage(byte[] igamebytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(igamebytes, 0, igamebytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }
        public void FnAbrirImangen(PictureBox pictureBoxFoto)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Sistema de Venta";
            dialog.InitialDirectory = "";
            dialog.Filter = "JPG,JPEG(*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png";
            #region Acceso de todos los archivos
            //Todos los archivos(*.*) | *.* 
            #endregion
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(dialog.FileName);
                string Texto = dialog.FileName;
            }
        }
        public void FnDragDropPictureBox(object sender, DragEventArgs e, PictureBox pictureBoxImagen)
        {
            var Data = e.Data.GetData(DataFormats.FileDrop);
            if (Data != null)
            {
                var Filenames = Data as string[];
                if (Filenames.Length > 0)
                    pictureBoxImagen.Image = Image.FromFile(Filenames[0]);
            }
        }
        public void FnCopyPictureBox(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
