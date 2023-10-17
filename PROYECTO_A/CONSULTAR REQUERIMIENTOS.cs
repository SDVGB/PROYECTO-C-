using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROYECTO_A
{
    public partial class CONSULTA : Form
    {
        int RowNo;
        public CONSULTA()
        {
            InitializeComponent();
        }
        //BOTON BUSCAR
        private void BUSCAR_Click(object sender, EventArgs e)
        {
            //ESTADO
            string EstadoSeleccionado;
           
            if (pendiente.Checked == true)
                EstadoSeleccionado = "P";
            else 
                EstadoSeleccionado = "R";

            string tipoRequerimiento = R.SelectedValue.ToString();
            string tipoPrioridad = PRIORIDAD.SelectedValue.ToString();


            //CONEXION A LA BASE DE DATOS
            string cadenaConexion = "Server = DESKTOP-QM2FR5L ; Database = APLICACION; User Id = sa; Password = sa;";
            SqlConnection sqlCon = new SqlConnection(cadenaConexion);
            sqlCon.Open();

     
            SqlCommand sqlCmd;

            //PROCESO ALMACENADO 
            sqlCmd = new SqlCommand("ConsultarRequerimientos", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@NickUsuario", USUARIO.Text);
            sqlCmd.Parameters.AddWithValue("@estado", EstadoSeleccionado);
            sqlCmd.Parameters.AddWithValue("@tipoReq", tipoRequerimiento);
            sqlCmd.Parameters.AddWithValue("@tipoPrioridad", tipoPrioridad);

            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            DataTable dtData = new DataTable();
            sqlSda.Fill(dtData);

            // GRILLA
            CONSULTAR_R.DataSource = dtData;

            //CERRAR CONEXION CON LA BASE DE DATOS
            sqlCon.Close();

        }
        //ASIGNACION DE OPCIONES
        private void CONSULTA_Load(object sender, EventArgs e)
        {
            //USUARIO QUE INGRESO
            USUARIO.Text = this.Tag.ToString();

            //REQUERIMIENTOS
            R.DisplayMember = "Text";
            R.ValueMember = "Value";
            var itemsReq = new[] {
            new { Text = "Instalar Software", Value = "1" },
            new { Text = "Formatear computador", Value = "2" },
            new { Text = "Desbloquear usuario ", Value = "3" },
            };
            R.DataSource = itemsReq;

            //PRIORIDAD
            PRIORIDAD.DisplayMember = "Text";
            PRIORIDAD.ValueMember = "Value";
            var items = new[] {
            new { Text = "Alta", Value = "1" },
            new { Text = "Media", Value = "2" },
            new { Text = "Baja", Value = "3" }
            };
            PRIORIDAD.DataSource = items;

        }

        //SELECCIONAR FILA
        private void CONSULTAR_R_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RowNo = e.RowIndex;
        }
        //BOTON ELIMINAR
        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (CONSULTAR_R.SelectedRows.Count > 0)
            {
                string IdRequerimiento = CONSULTAR_R.SelectedRows[0].Cells[0].Value.ToString();


                // CONEXION A LA BASE DE DATOS
                string cadenaConexion = "Server = DESKTOP-QM2FR5L ; Database = APLICACION; User Id = sa; Password = sa;";
                SqlConnection sqlCon = new SqlConnection(cadenaConexion);
                sqlCon.Open();

             
                SqlCommand sqlCmd;

                //PROCESO ALMACENADO
                sqlCmd = new SqlCommand("EliminarRequerimiento", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id", IdRequerimiento);

                SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
                DataTable dtData = new DataTable();
                sqlSda.Fill(dtData);

                if (dtData.Rows.Count > 0)
                {
                    MessageBox.Show(Convert.ToString(dtData.Rows[0]["MensajeRet"]));
                    BUSCAR.PerformClick();
                }

                //CERRAR CONEXION A LA BASE DE DATOS 
                sqlCon.Close();

            }
        }
        //BOTON MODIFICAR
        private void Modificar_Click(object sender, EventArgs e)
        {
            if (CONSULTAR_R.SelectedRows.Count > 0)
            {
                string IdRequerimiento = CONSULTAR_R.SelectedRows[0].Cells[0].Value.ToString();


                // CONEXION A LA BASE DE DATOS 
                string cadenaConexion = "Server = DESKTOP-QM2FR5L ; Database = APLICACION; User Id = sa; Password = sa;";
                SqlConnection sqlCon = new SqlConnection(cadenaConexion);
                sqlCon.Open();

              
                SqlCommand sqlCmd;
                //PROCEDIMIENTO ALMACENADO
                sqlCmd = new SqlCommand("ModificarRequerimiento", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id", IdRequerimiento);

                SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
                DataTable dtData = new DataTable();
                sqlSda.Fill(dtData);

                if (dtData.Rows.Count > 0)
                {
                    MessageBox.Show(Convert.ToString(dtData.Rows[0]["MensajeRet"]));
                    BUSCAR.PerformClick();
                }

                //CERRAR LA CONEXION CON LA BASE DE DATOS
                sqlCon.Close();
            }
        }
    }
}

