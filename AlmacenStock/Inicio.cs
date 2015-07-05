using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AlmacenStock;
using System.Data;
using System.Data.SqlClient;




namespace AlmacenStock
{
    public partial class Inicio : Form
    {
       
        public Inicio()
        {
            InitializeComponent();
            
        }
        Operaciones bd = new Operaciones();
          FormMenuPrincipal menu = new FormMenuPrincipal();
          Conexion cnn = new Conexion();


        private void btnIngresar_Click(object sender, EventArgs e)
        {                      
            if (txtContra.Text == "" || txtUsuario.Text == "")
            {
                MessageBox.Show("Ingresar Contraseña o Ingresar Usuario");
            }
            else{
            string usuario =txtUsuario.Text;
            string contrasena = txtContra.Text;
            int result = 0;
            string sql  = "SELECT * FROM Usuario WHERE (username='" + usuario + "' AND contrasena='" + contrasena + "')";
            SqlCommand cmd = new SqlCommand(sql, cnn.getConection_DonHugo()); // la instruccion sql + la conexion
            cmd.Parameters.AddWithValue("@username",txtUsuario.Text);
            cmd.Parameters.AddWithValue("@contrasena",txtContra.Text);
           
            try
            {
                result = (int)cmd.ExecuteScalar();
                if(result > 0){
                    
                    menu.inicio_bien = -1;
                    this.Hide();
                    menu.WindowState = FormWindowState.Maximized;
                    menu.Show(); 
                    
                //menu.Hide();
                //menu.habilitar();
                //menu.Show();             
                
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Usuario Incorrecto");
            }
                  
            }
              
        }
    }
}
