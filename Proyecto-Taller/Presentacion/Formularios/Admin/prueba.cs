using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller.Presentacion.Formularios.Admin
{
    public partial class prueba : Form
    {
        bool sidebarExpand;
        public prueba()
        {
            InitializeComponent();
        }

        private void sidebarTime_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTime.Stop();
                }

            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTime.Stop();
                }
            }
        }

      
      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTime.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sidebarTime.Start();
        }
    }
}
