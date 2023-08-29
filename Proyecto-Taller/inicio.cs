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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // formLogin form2 = new formLogin();
          //  form2.Show();
            FormMenuGerente form2 = new FormMenuGerente();
             form2.Show();
        }
    }
}
