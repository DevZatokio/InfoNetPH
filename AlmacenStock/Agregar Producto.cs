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
    public partial class Agregar_Producto : Form
    {
        public Agregar_Producto()
        {
            InitializeComponent();
            llenarCombobox();
        }
        Conexion bd = new Conexion();
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Operaciones bd = new Operaciones();
                int selec = (int) cBTipo.SelectedValue;
                
                if (bd.Insert_producto(txtNombreProducto.Text,  Convert.ToInt32(txtCantidadProducto.Text), txtDescripcionProducto.Text, selec))
                {
                    MessageBox.Show("Ingresado Correctamente");
                    Close();
                }
                else
                {
                   MessageBox.Show("Error");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ingrese cantidad valida");
            }
        }

        private void Agregar_Producto_Load(object sender, EventArgs e)
        {

        }
        
        private void cBTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public void llenarCombobox()
        {
            Operaciones lista = new Operaciones();
            cBTipo.DataSource = lista.lista_Tipo();
            cBTipo.ValueMember= "Id_tipo";
            cBTipo.DisplayMember = "Nombre_tipo";
                                
        }


    }
}
