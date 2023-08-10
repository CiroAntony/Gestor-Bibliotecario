
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyBiblioteca_BL;

namespace ProyBiblioteca_GUI
{
    public partial class LibroMan01 : Form
    {
        LibroBL objLibroBL = new LibroBL();
        DataView dtv;

        public LibroMan01()
        {
            InitializeComponent();
        }

        private void ProductoMan01_Load(object sender, EventArgs e)
        {
         
            CargarDatos("");

        }

        private void CargarDatos(String strFiltro)
        {

            dtv = new DataView(objLibroBL.ListarLibro());
            dtv.RowFilter = "tituloLibro like '%" + strFiltro + "%'";
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
                LibroMan02 objMan02 = new LibroMan02();
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
                LibroMan03 objMan03 = new LibroMan03();
                objMan03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objMan03.ShowDialog();

                CargarDatos(txtFiltro.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    if (objLibroBL.EliminarLibro(dtgDatos.CurrentRow.Cells[0].Value.ToString()) == true)
                    {
                        CargarDatos(txtFiltro.Text);
                    }
                    else
                    {
                        throw new Exception("Libro no se elimino por estar asociado a otra tabla");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
