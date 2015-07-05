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
    public partial class ListadodeProductos : Form
    {
        public ListadodeProductos()
        {
            InitializeComponent();
        }

        private void txtBuscarListados_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string numero = ((DataTable)dgvListadoProductos.DataSource).DefaultView.RowFilter = "Nombre_producto like'" + txtBuscarListados.Text.Trim().Replace("'", "''") + "%'";

            }
            catch (Exception)
            {


            }
        }


        public void cargarListadodeProductos() { 
        
             Operaciones lista = new Operaciones();
            dgvListadoProductos.DataSource  = lista.lista_Producto();
           ///agregar nombres a las tablas
            dgvListadoProductos.Columns["Id_producto"].HeaderText = "Codigo Producto";
            dgvListadoProductos.Columns["Nombre_producto"].HeaderText = "Nombre";
            dgvListadoProductos.Columns["Descripcion_producto"].HeaderText = "Descripción";
            dgvListadoProductos.Columns["Cantidad_producto"].HeaderText = "Cantidad";
            dgvListadoProductos.Columns["Id_tipo"].HeaderText = "Tipo Cantidad";
        }

        private void ListadodeProductos_Load(object sender, EventArgs e)
        {
            cargarListadodeProductos();
        }

        private void btnAgregarLista_Click(object sender, EventArgs e)
        {
            if(txtCantidadListado.Text =="" && txtPrecioListado.Text ==""){
                MessageBox.Show("Primero debe ingresar los datos de Cantidad y Precio para poder agregar el producto en la lista");
            }
            else
            {
                int selectedrowindex = dgvListadoProductos.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvListadoProductos.Rows[selectedrowindex];
                //rescatar las variables que se van a ocupar en la confección del listado del data griw view
                int id_producto = Convert.ToInt32(selectedRow.Cells["Id_producto"].Value);
                string nombre_producto = Convert.ToString(selectedRow.Cells["Nombre_producto"].Value);
                //int cantidad_producto = Convert.ToInt32(selectedRow.Cells["Cantidad_producto"].Value);

                //convertir la cantidad nueva en int
                int nuevaCantidad = Convert.ToInt32(txtCantidadListado.Text);
                // recatar el precio 
                int precio = Convert.ToInt32(txtPrecioListado.Text);
                //fecha de la lista
                //declarar subtotales y total
                int subtotales= nuevaCantidad*precio;               
                int Total = 0;
                
                DataTable dt = new DataTable("listado");
                
                dt.Columns.Add("Nombre",typeof(string));
                dt.Columns.Add("Cantidad", typeof(Int32));
                dt.Columns.Add("Precio", typeof(Int32));
                dt.Columns.Add("SubTotal", typeof(Int32));
                dt.Rows.Add(nombre_producto,nuevaCantidad,precio,subtotales);
                

                DataSet ds = new DataSet("listado");
                ds.Tables.Add(dt);
            }
        }

        private void dgvListadoProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
