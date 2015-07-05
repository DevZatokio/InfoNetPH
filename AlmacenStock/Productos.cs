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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            cargaGridView();
                      
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Agregar_Producto agregarProducto = new Agregar_Producto();
            this.Hide();
            agregarProducto.Show();
            
        }
        
        public void cargaGridView()
        {
            Operaciones lista = new Operaciones();
            dgvProducto.DataSource  = lista.lista_Producto();
            dgvProducto.Columns["Id_producto"].HeaderText = "Codigo Producto";
            dgvProducto.Columns["Nombre_producto"].HeaderText = "Nombre";
            dgvProducto.Columns["Descripcion_producto"].HeaderText = "Descripción";
            dgvProducto.Columns["Cantidad_producto"].HeaderText = "Cantidad";
            dgvProducto.Columns["Id_tipo"].HeaderText = "Tipo Cantidad";
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            if (dgvProducto.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvProducto.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvProducto.Rows[selectedrowindex];

                int a = Convert.ToInt32(selectedRow.Cells["Id_producto"].Value);
                Operaciones ope = new Operaciones();
                ope.Delete_producto(a);
                MessageBox.Show("Fue Eliminado Correstamente");
                cargaGridView();
               // MessageBox.Show(a);
            }
           
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            cargaGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvProducto.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvProducto.Rows[selectedrowindex];

                int id_producto = Convert.ToInt32(selectedRow.Cells["Id_producto"].Value);
                string nombre_producto = Convert.ToString(selectedRow.Cells["Nombre_producto"].Value);
                string descripcion_producto = Convert.ToString(selectedRow.Cells["Descripcion_producto"].Value);
                int cantidad_producto = Convert.ToInt32(selectedRow.Cells["Cantidad_producto"].Value);
                int comboboxTipo = Convert.ToInt32(selectedRow.Cells["Id_tipo"].Value);
                Operaciones ope = new Operaciones();
                ope.Update_producto(id_producto,nombre_producto,descripcion_producto,cantidad_producto,comboboxTipo);
                MessageBox.Show("Fue Modificado Correstamente");
                cargaGridView();
                // MessageBox.Show(a);
            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string numero = ((DataTable)dgvProducto.DataSource).DefaultView.RowFilter = "Nombre_producto like'" + txtBuscarProducto.Text.Trim().Replace("'", "''") + "%'";

            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              string numero =  ((DataTable)dgvProducto.DataSource).DefaultView.RowFilter = "Nombre_producto like'" + txtBuscarProducto.Text.Trim().Replace("'", "''") + "%'";
                     
            }
            catch (Exception)
            {


            }
        }

        private void Productos_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
       
    }
}
