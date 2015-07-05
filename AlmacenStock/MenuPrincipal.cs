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
        public int inicio_bien =0;
        public FormMenuPrincipal()
        {
            InitializeComponent();        
                    
            
        }

        public void habilitar() {
            productosToolStripMenuItem.Enabled = true;
            inicioUsuarioToolStripMenuItem.Enabled = false;
            crearListaToolStripMenuItem.Enabled = true;
            reportesToolStripMenuItem.Enabled = true;
        }

        private void inicioUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();           
            ini.MdiParent= this;
            ini.WindowState = FormWindowState.Maximized;
            ini.Show();

        }

        private void ingresarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Productos ini = new Productos();
             
            ini.MdiParent = this;
            ini.WindowState = FormWindowState.Maximized;
            ini.Show();
        }

        private void crearListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadodeProductos ini = new ListadodeProductos();

            ini.MdiParent = this;
            ini.WindowState = FormWindowState.Maximized;
            ini.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes ini = new Reportes();

            ini.MdiParent = this;
            ini.WindowState = FormWindowState.Maximized;
            ini.Show();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (inicio_bien == 0)
            {
                productosToolStripMenuItem.Enabled = false;
                inicioUsuarioToolStripMenuItem.Enabled = true;
                crearListaToolStripMenuItem.Enabled = false;
                reportesToolStripMenuItem.Enabled = false;
            }
            else {
                productosToolStripMenuItem.Enabled = true;
                inicioUsuarioToolStripMenuItem.Enabled = false;
                crearListaToolStripMenuItem.Enabled = true;
                reportesToolStripMenuItem.Enabled = true;
            }
        }

        private void FormMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }
    }
}
