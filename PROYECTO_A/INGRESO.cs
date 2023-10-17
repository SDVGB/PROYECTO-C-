using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROYECTO_A
{
    public partial class INGRESO : Form
    {
        public INGRESO()
        {
            InitializeComponent();
        }
        //BOTON DE INGRESO 
        private void INGRESAR_Click(object sender, EventArgs e)
        {
            //CONEXION A LA BASE DE DATOS 
            string cadenaConexion = "Server = DESKTOP-QM2FR5L ; Database = APLICACION; User Id = sa; Password = sa;";
            SqlConnection sqlCon = new SqlConnection(cadenaConexion);
            sqlCon.Open();

            SqlCommand sqlCmd;

            // PROCEDIMIENTO ALMACENADO 
            sqlCmd = new SqlCommand("ValidarUsuario", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@NICK", USUARIO.Text);
            sqlCmd.Parameters.AddWithValue("@CLAVE ", CLAVE.Text);
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            DataTable dtData = new DataTable();
            sqlSda.Fill(dtData);

            // VALIDACION DE USUARIO
            if (dtData.Rows.Count > 0)
            {
                if (Convert.ToInt32(dtData.Rows[0]["CodigoRet"]) == 0)
                {  
                    //MessageBox.Show( Convert.ToString(dtData.Rows[0]["MensajeRet"]));
                    // Mostrar la pantalla con las opciones de menu
                    this.Hide();
                    Form frmMenu = new MENU();
                    frmMenu.Tag = USUARIO.Text;
                    frmMenu.ShowDialog();
                }
                else
                {
                    MessageBox.Show(Convert.ToString(dtData.Rows[0]["MensajeRet"]));
                }
            }
            else
                MessageBox.Show("No fue posible validar al usuario, se niega el acceso");

            //CERRAR CONEXION DE LA BASE DE DATOS 
            sqlCon.Close();
        }
        //BOTON DE PARA VER LA CLAVE
        private void VER_Click(object sender, EventArgs e)
        {
      
            CLAVE.UseSystemPasswordChar = !CLAVE.UseSystemPasswordChar;
            if (CLAVE.UseSystemPasswordChar == true)
                VER.Text = "Ver";
            else
                VER.Text = "Ocultar";
        }
    }
}
