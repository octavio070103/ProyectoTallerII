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
    public partial class MenuPadre : Form
    {
  
        private int contractedWidth = 30; // Ancho contraído del menú
        private int expandedWidth = 200; // Ancho expandido del menú

        public MenuPadre()
        {
            InitializeComponent();
            personalizarDiseno();
        }

        private void personalizarDiseno() 
        {
            //**** Este metodo oculta los SUBMENUS del menu lateral al iniciar ***
            //PSubmenu1.Visible = false;
            //*** Hacer para cada submenu - borrar
        }
        /*
        private void ocultarSubmenu()
        {
             Este metodo oculta los SUBMENUS del menu lateral 

            if(PSubmenu1.Visible == true) 
            {
                PSubmenu1.Visible = false;
            }

             Hacer para cada submenu - borrar
        }

        private void mostrarSubmenu(Panel subMenu) 
        {
            //**** Este metodo permite mostrar un ocultar un determinado submenu al tocar un boton ****

            if (subMenu.Visible == false) 
            {
                ocultarSubmenu();       //**** Si el submenu no se ve, oculta los demas submenus
                subMenu.Visible = true; //**** Muestra el submenu indicado

            } else {
                subMenu.Visible = false; //**** Oculta el submenu al tocar el boton
            }
        }
        */




        private void PMenuLat_Paint(object sender, PaintEventArgs e)
        {

        }




        private Form formularioActivo = null;
        private void abrirFormularioHijo( Form formHijo )
        {
            //**** Este metodo abrira el formulario indicado por cada boton ****

            if (formularioActivo == null) // cambiar por !=
            {
                //formularioActivo.Close();
                formularioActivo = formHijo;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                formHijo.Dock = DockStyle.Fill;
                PVentana.Controls.Add( formHijo );
                PVentana.Tag = formHijo;
                //formHijo.BringToFront();
                formHijo.Show();
            }

        }

        private void MenuVendedo_Load(object sender, EventArgs e)
        {

        }

        private void PVentana_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void picRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picRestaurar.Visible = false;
            picMaxPantalla.Visible = true;
        }

        private void picMinPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMaxPantalla_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picMaxPantalla.Visible = false;
            picRestaurar.Visible = true;
        }


        private bool isMenuExpanded = true; // Variable para seguir el estado del menú
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int contractedWidth = 50; // Ancho mínimo cuando el menú está contraído
            int expandedWidth = 200;  // Ancho cuando el menú está expandido

            if (isMenuExpanded)
            {
                // Desactiva las propiedades Dock y Anchor para los paneles
                PLogo.Dock = DockStyle.None;
                PMenuLat.Dock = DockStyle.None;
                PLogo.Anchor = AnchorStyles.Left;
                PMenuLat.Anchor = AnchorStyles.Left;

                // Reduce el ancho de los paneles gradualmente
                while (PLogo.Width > contractedWidth)
                {
                    PLogo.Width -= 10;
                    PMenuLat.Width -= 10;
                    Application.DoEvents();
                }
            }
            else
            {
                // Reactiva las propiedades Dock y Anchor para los paneles
                PLogo.Dock = DockStyle.Left;
                PMenuLat.Dock = DockStyle.Fill;
                PLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
                PMenuLat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;

                // Expande el ancho de los paneles gradualmente
                while (PLogo.Width < expandedWidth)
                {
                    PLogo.Width += 10;
                    PMenuLat.Width += 10;
                    Application.DoEvents();
                }
            }

            isMenuExpanded = !isMenuExpanded; // Cambia el estado del menú


        }
    }

}
