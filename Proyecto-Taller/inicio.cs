﻿//using Proyecto_Taller.Presentacion.Formularios.Admin;
using Proyecto_Taller.Presentacion.Formularios.Admin;
using Proyecto_Taller.Presentacion.Formularios.Login;
using Proyecto_Taller.Presentacion.Formularios.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // formLogin form2 = new formLogin();
          //  form2.Show();
            MenuAdmin form2 = new MenuAdmin();
             form2.Show();
        }
    }
}
