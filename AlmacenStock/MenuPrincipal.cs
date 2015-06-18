using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlmacenStock
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void inicioUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();
            
            ini.MdiParent= this;
            ini.Show();
        }

        private void ingresarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Productos ini = new Productos();

            ini.MdiParent = this;
            ini.Show();
        }

        private void crearListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadodeProductos ini = new ListadodeProductos();

            ini.MdiParent = this;
            ini.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes ini = new Reportes();

            ini.MdiParent = this;
            ini.Show();
        }
    }
}
