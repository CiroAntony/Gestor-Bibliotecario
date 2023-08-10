
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Para los objetos DataTable, DataRow y DataView
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar...
using ProyBiblioteca_BL;
using ProyBiblioteca_GUI;

namespace ProyVentas_GUI
{
    public partial class EmpleadoMan01 : Form
    {
        
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        DataView dtv;

        public EmpleadoMan01()
        {
            InitializeComponent();
        }

        private void ProductoMan01_Load(object sender, EventArgs e)
        {
         
            CargarDatos("");

        }

        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objEmpleadoBL.ListarEmpleado());
            dtv.RowFilter = "idEmpleado like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoMan02 objMan02 = new EmpleadoMan02();
                objMan02.ShowDialog();

                CargarDatos(txtFiltro.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoMan03 objMan03 = new EmpleadoMan03();
                objMan03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objMan03.ShowDialog();

                CargarDatos(txtFiltro.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult vrpta;
                vrpta = MessageBox.Show("Seguro de eliminar el registro?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vrpta == DialogResult.Yes)
                {
                    if (objEmpleadoBL.EliminarEmpleado(dtgDatos.CurrentRow.Cells[0].Value.ToString()) == true)
                    {
                        CargarDatos(txtFiltro.Text);
                    }
                    else
                    {
                        throw new Exception("EL Empleado no se elimino correctamente");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
