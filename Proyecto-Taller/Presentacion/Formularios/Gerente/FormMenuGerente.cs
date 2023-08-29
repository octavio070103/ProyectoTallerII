using Proyecto_Taller.Presentacion.Formularios.Gerente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller.Presentacion.Formularios.Vendedor
{
    public partial class FormMenuGerente : Form
    {
        private bool isMaximized = false; // Variable para realizar seguimiento del estado de maximización
        private int contractedWidth = 50; // Ancho contraído del menú
        private int expandedWidth = 200; // Ancho expandido del menú
        public FormMenuGerente()
        {
            InitializeComponent();
        }
       
        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal; // Cambiar a tamaño normal
                isMaximized = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized; // Cambiar a maximizado
                isMaximized = true;
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
      

       
            if (panel1.Width == contractedWidth)
            {
                panel1.Width = expandedWidth; // Desplegar el menú
            }
            else
            {
                panel1.Width = contractedWidth; // Contraer el menú
            }
        
         }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MenuPadre form2 = new MenuPadre();
            form2.Show();
        }
    }

}
