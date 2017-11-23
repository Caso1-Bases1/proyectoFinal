using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Bases_de_Datos.view
{
    public partial class IngresoFlujos : Form
    {
        private DBConnection dbConnection = new DBConnection();
        public IngresoFlujos()
        {
            InitializeComponent();
        }

        private void IngresoFlujos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_PRODDataSet2.FLUJO_MASTER' table. You can move, or remove it, as needed.
            this.fLUJO_MASTERTableAdapter.Fill(this.dB_PRODDataSet2.FLUJO_MASTER);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flujoMaster.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void flujoBtn_Click(object sender, EventArgs e)
        {
            int nuevoFlujoMaster = Int32.Parse(nuevoFlujo.Text);
            dbConnection.conectar();
            dbConnection.insertFlujoMaster(nuevoFlujoMaster);
            dbConnection.desconectar();
            this.actualizarGrid();
            nuevoFlujo.Text = "";
        }

        private void actualizarGrid()
        {
            dbConnection.actualizarDataGridView(this.dataGridView1, "Select * From FLUJO_MASTER");
        }

        private void nuevoFlujo_Click(object sender, EventArgs e)
        {
            int nuevoFlujo = Int32.Parse(codigoFlujo.Text);
            int nuevoFlujoMaster = Int32.Parse(codigoFlujoMaster.Text);

            dbConnection.conectar();
            dbConnection.insertFlujo(nuevoFlujo, nuevoFlujoMaster);
            dbConnection.desconectar();
            this.actualizarGrid();
            codigoFlujo.Text = "";
            codigoFlujoMaster.Text = "";
        }
    }
}
