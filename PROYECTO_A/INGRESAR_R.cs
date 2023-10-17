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
    public partial class INGRESAR : Form
    {
        public INGRESAR()
        {
            InitializeComponent();
        }
        //ASIGNAR OPCIONES 
        private void Registro_Load(object sender, EventArgs e)
        {
            //REQUERIMIENTO
            REQUERIMIENTOS.DisplayMember = "Text";
            REQUERIMIENTOS.ValueMember = "Value";
            var itemsReq = new[] {
            new { Text = "Instalar Software", Value = "1" },
            new { Text = "Formatear computador", Value = "2" },
            new { Text = "Desbloquear usuario ", Value = "3" },
            };
            REQUERIMIENTOS.DataSource = itemsReq;
            REQUERIMIENTOS.SelectedIndex = -1;

            //USUARIO
            USUARIO.DisplayMember = "Text";
            USUARIO.ValueMember = "Value";
            var itemsU = new[] {
            new { Text = "blisboa", Value = "1" },
            new { Text = "pperez", Value = "2" },
            new { Text = "pedro", Value = "3" }
            };
            USUARIO.DataSource = itemsU;
            USUARIO.SelectedIndex = -1;
            //PRIORIDAD 
            PRIORIDAD.DisplayMember = "Text";
            PRIORIDAD.ValueMember = "Value";
            var itemsP = new[] {
            new { Text = "Alta", Value = "1" },
            new { Text = "Media", Value = "2" },
            new { Text = "Baja", Value = "3" }
            };
            PRIORIDAD.DataSource = itemsP;
            PRIORIDAD.SelectedIndex = -1;

        }
        //BOTON LIMPIAR
        private void L_Click(object sender, EventArgs e)
        {
            REQUERIMIENTOS.SelectedIndex = -1;
            USUARIO.SelectedIndex = -1;
            PRIORIDAD.SelectedIndex = -1;
            DESCRIPCION.Text = "";
        }
        //BOTON IR A LOS REQUERIMIETOS 
        private void I_Click(object sender, EventArgs e)
        {
            Form frmConsulta = new CONSULTA();
            frmConsulta.Tag = this.Tag;
            frmConsulta.ShowDialog();
        }
        //BOTON GUARDAR 
        private void G_Click(object sender, EventArgs e)
        {
            // CONEXION A LA BASE DE DATOS 
            string cadenaConexion = "Server = DESKTOP-QM2FR5L ; Database = APLICACION; User Id = sa; Password = sa;";
            SqlConnection sqlCon = new SqlConnection(cadenaConexion);
            sqlCon.Open();

            
            SqlCommand sqlCmd;

            string tipoReq = REQUERIMIENTOS.SelectedValue.ToString();
            string IdUsuario = USUARIO.SelectedValue.ToString();
            string descripcion = DESCRIPCION.Text;
            string tipoPrio = PRIORIDAD.SelectedValue.ToString();

            // PROCEDIMIENTO ALMACENADO 
            sqlCmd = new SqlCommand("IngresarRequerimiento", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@tipoReq ", tipoReq);
            sqlCmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            sqlCmd.Parameters.AddWithValue("@descripcion", descripcion);
            sqlCmd.Parameters.AddWithValue("@tipoPrioridad", tipoPrio);

            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            DataTable dtData = new DataTable();
            sqlSda.Fill(dtData);

            if (dtData.Rows.Count > 0)
            {
                MessageBox.Show(Convert.ToString(dtData.Rows[0]["MensajeRet"]));
            }
                //CERRAR LA CONEXION DE LA BASE DE DATOS 
                sqlCon.Close();
        }
    }
}
