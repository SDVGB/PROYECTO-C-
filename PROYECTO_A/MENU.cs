using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_A
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }
        //BIENVENIDA
        private void MENU_Load(object sender, EventArgs e)
        {
            Usuario.Text = "Bienvenido " + this.Tag;
        }
        //BOTON DE INGRESO
        private void INGRESO_Click_1(object sender, EventArgs e)
        {
            Form frmIngreso = new INGRESAR();
            frmIngreso.Tag = this.Tag;
            frmIngreso.ShowDialog();
        }
        //BOTON DE CONSULTAR
        private void CONSULTAR_Click(object sender, EventArgs e)
        {
            Form frmConsulta = new CONSULTA();
            frmConsulta.Tag = this.Tag;
            frmConsulta.ShowDialog();
        }
    }
}
