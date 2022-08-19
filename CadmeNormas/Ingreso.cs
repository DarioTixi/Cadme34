using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CadmeNormas
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Usuario_Enter(object sender, EventArgs e)
        {
            errorusuariocontrasenia.Text = "";
            if (Usuario.Text =="Usuario") {
                Usuario.Text = "";
                Usuario.ForeColor = Color.White;
            }
        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
           
            if (Usuario.Text== "") {
                Usuario.Text = "Usuario";
                Usuario.ForeColor = Color.DimGray;
            }
        }

        private void Contraseña_Enter(object sender, EventArgs e)
        {
            errorusuariocontrasenia.Text = "";
            if (Contraseña.Text =="Contraseña")
            {
                Contraseña.Text = "";
                Contraseña.ForeColor = Color.White;
                Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void Contraseña_Leave(object sender, EventArgs e)
        {
            if (Contraseña.Text == "")
            {
                Contraseña.Text = "Contraseña";
                Contraseña.ForeColor = Color.DimGray;
               
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        string usuario = "cadme";
        string clave = "cadme";
        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (Usuario.Text == usuario && Contraseña.Text == clave)
            {
                this.Hide();
                Form1 menu = new Form1();
                Bienvenida bienvenida = new Bienvenida();
                bienvenida.ShowDialog();
                menu.Show();

                // MessageBox.Show("Mensaje con boton de aceptar", "Ejemplo Mensaje Aceptar");

            }
            else
                errorusuariocontrasenia.ForeColor = Color.Red;
            errorusuariocontrasenia.Text = "Contrasenia o Usuario Incorrectos";
        }

        private void Ingreso_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
