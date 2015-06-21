using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AlmacenStock;




namespace AlmacenStock
{
    public partial class Inicio : Form
    {
       
        public Inicio()
        {
            InitializeComponent();
           

        }
          Conexion bd = new Conexion();
          FormMenuPrincipal menu = new FormMenuPrincipal();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
             string usuario = bd.selectstring("select username from Usuario where username = '" +txtUsuario.Text + "'");
            string contraseña = bd.selectstring("select contrasena from Usuario where contrasena = '" + txtContra.Text + "'");

            if (usuario == txtUsuario.Text && contraseña == txtContra.Text)
            {
                menu.Hide();
                menu.habilitar();                
                menu.ShowDialog();
                

            }
            else {
                MessageBox.Show("Usuario Incorrecto");
            }
           
               
        }
    }
}
