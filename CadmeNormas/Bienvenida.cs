using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadmeNormas
{
    public partial class Bienvenida : Form
    {
        Form1 menu = new Form1();
        public Bienvenida()
        {
            InitializeComponent();
            
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            cargando.Value += 1;
            cargando.Text = cargando.Value.ToString();
            if (cargando.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
                    }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0) {
                timer2.Stop();
                this.Close();
               }
         
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            cargando.Value = 0;
            cargando.Minimum = 0;
            cargando.Maximum = 100;
            timer1.Start();
                              
        }

    }
}
