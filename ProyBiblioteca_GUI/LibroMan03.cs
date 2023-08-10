using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyBiblioteca_BE;
using ProyBiblioteca_BL;
namespace ProyBiblioteca_GUI
{
    public partial class LibroMan03 : Form
    {
        LibroBL objLibroBL = new LibroBL();
        LibroBE objLibroBE = new LibroBE();
        TemaBL objTemaBL = new TemaBL();
        EditorialBL objEditorialBL = new EditorialBL();

        Boolean blnCambio;
        Byte[] FotoOriginal;

        public LibroMan03()
        {
            InitializeComponent();
        }


        public String Codigo { get; set; }
        private void LibroMan03_Load(object sender, EventArgs e)
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
                cboTema.ValueMember = "idTema";
                cboTema.DisplayMember = "nomTema";

                dt = objEditorialBL.ListarEditorial();
                dr = dt.NewRow();
                dr["idEditorial"] = 0;
                dr["nomEditorial"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboEditorial.DataSource = dt;
                cboEditorial.ValueMember = "idEditorial";
                cboEditorial.DisplayMember = "nomEditorial";


                objLibroBE = objLibroBL.ConsultarLibro(this.Codigo);
                lblCodigo.Text = objLibroBE.idLibro;
                txtTitulo.Text = objLibroBE.tituloLibro;
                txtCantPaginas.Text = objLibroBE.canPaginas.ToString();
                cboTema.SelectedValue = objLibroBE.idTema;
                cboEditorial.SelectedValue = objLibroBE.idEditorial;
                dtFechLanzamiento.Value = objLibroBE.fechLanzamiento;


                if (objLibroBE.fotoLibro.Length == 0)
                {
                    pbFoto.Image = null;

                }
                else
                {
                    MemoryStream fotoStream = new MemoryStream(objLibroBE.fotoLibro);
                    pbFoto.Image = Image.FromStream(fotoStream);
                    FotoOriginal = objLibroBE.fotoLibro;
                }

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
                    throw new Exception("La descripcion es obligatoria.");
                }

                if (pbFoto.Image == null)
                {
                    throw new Exception("Debe registrar la foto.");
                }

                if (cboTema.SelectedIndex == 0 || cboEditorial.SelectedIndex == 0)
                {
                    throw new Exception("Seleccione tema y editorial");
                }

                objLibroBE.idLibro = lblCodigo.Text;
                objLibroBE.tituloLibro = txtTitulo.Text.Trim();
                objLibroBE.fotoLibro = getFoto();
                objLibroBE.canPaginas = Convert.ToInt16(txtCantPaginas.Text.Trim());
                objLibroBE.idTema = cboTema.SelectedValue.ToString();
                objLibroBE.idEditorial = cboEditorial.SelectedValue.ToString();
                objLibroBE.emplUltMod = clsCredenciales.usuario;
                objLibroBE.fechLanzamiento = Convert.ToDateTime(dtFechLanzamiento.Text.ToString());

                if (objLibroBL.ActualizarLibro(objLibroBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizo el registro, contacte con IT");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private byte[] getFoto()
        {
            MemoryStream stream = new MemoryStream();
            pbFoto.Image.Save(stream, pbFoto.Image.RawFormat);

            return stream.GetBuffer();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back
                    || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator);
        }

        private void txtStkAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
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
                    blnCambio = true;
                }
                else
                {
                    blnCambio = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
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
