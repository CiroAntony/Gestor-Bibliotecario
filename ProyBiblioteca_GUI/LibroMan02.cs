using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using ProyBiblioteca_BE;
using ProyBiblioteca_BL;

namespace ProyBiblioteca_GUI
{
    public partial class LibroMan02 : Form
    {
        LibroBL objLibroBL = new LibroBL();
        LibroBE objLibroBE = new LibroBE();
        TemaBL objTemaBL = new TemaBL();
        EditorialBL objEditorialBL = new EditorialBL();

        public LibroMan02()
        {
            InitializeComponent();
        }

        private void BibliotecaMan02_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objTemaBL.ListarTema();
                DataRow dr;
                dr = dt.NewRow();
                dr["idTema"] = 0;
                dr["nomTema"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboTema.DataSource = dt;
                cboTema.DisplayMember = "nomTema";
                cboTema.ValueMember = "idTema";

                dt = objEditorialBL.ListarEditorial();
                dr = dt.NewRow();
                dr["idEditorial"] = 0;
                dr["nomEditorial"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboEditorial.DataSource = dt;
                cboEditorial.DisplayMember = "nomEditorial";
                cboEditorial.ValueMember = "idEditorial";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtTitulo.Text.Trim() == "")
                {
                    throw new Exception("El titulo es obligatorio.");
                }

                if (pbFoto.Image == null)
                {
                    throw new Exception("Debe registrar la foto.");
                }

                if (cboTema.SelectedIndex == 0 || cboEditorial.SelectedIndex == 0)
                {
                    throw new Exception("Seleccione Tema y Editorial");
                }

                objLibroBE.tituloLibro = txtTitulo.Text.Trim();
                objLibroBE.fotoLibro = File.ReadAllBytes(openFileDialog1.FileName);
                objLibroBE.canPaginas = Convert.ToInt16(txtCantPaginas.Text.Trim());
                objLibroBE.idTema = cboTema.SelectedValue.ToString();
                objLibroBE.idEditorial = cboEditorial.SelectedValue.ToString();
                objLibroBE.empRegistro = clsCredenciales.usuario;
                objLibroBE.fechLanzamiento = Convert.ToDateTime(dtFechLanzamiento.Text.ToString());

                if (objLibroBL.InsertarLibro(objLibroBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el registro, contacte con IT");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();

                if (openFileDialog1.FileName != String.Empty)
                {
                    pbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtCantPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
