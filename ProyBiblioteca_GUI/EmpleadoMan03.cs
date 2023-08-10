using ProyBiblioteca_BE;
using ProyBiblioteca_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyBiblioteca_GUI
{
    public partial class EmpleadoMan03 : Form
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();
        UbigeoBL objUbigeoBL = new UbigeoBL();

        Boolean blnCambio;
        Byte[] FotoOriginal;

        public EmpleadoMan03()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void EmpleadoMan03_Load(object sender, EventArgs e)
        {
            
            try
            {
                objEmpleadoBE = objEmpleadoBL.ConsultarEmpleado(this.Codigo);

                lblCodigo.Text = objEmpleadoBE.idEmpleado;
                txtNombre.Text = objEmpleadoBE.nomEmpleado;
                txtApellido.Text = objEmpleadoBE.apeEmpleado;
                dtFechIngreso.Value = objEmpleadoBE.fechIngreso;
                txtSalario.Text = objEmpleadoBE.Salario.ToString();
                dtFechNacimiento.Value = objEmpleadoBE.fechNacimiento;
                txtCorreo.Text = objEmpleadoBE.correo;
                txtCelular.Text = objEmpleadoBE.numCelular;


                if (objEmpleadoBE.fotoEmpleado.Length == 0)
                {
                    pbFoto.Image = null;

                }
                else
                {
                    MemoryStream fotoStream = new MemoryStream(objEmpleadoBE.fotoEmpleado);
                    pbFoto.Image = Image.FromStream(fotoStream);
                    FotoOriginal = objEmpleadoBE.fotoEmpleado;
                }

                String idUbigeo = objEmpleadoBE.idUbigeo;

                CargarUbigeo(idUbigeo.Substring(0, 2), idUbigeo.Substring(2, 2), idUbigeo.Substring(4, 2));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            UbigeoBL objUbigeoBL = new UbigeoBL();
            cboDepartamento.DataSource = objUbigeoBL.ListarDepartamento();
            cboDepartamento.DisplayMember = "Despartamento";
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objUbigeoBL.ListarProvincia(IdDepa);
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeoBL.ListarDistritos(IdDepa, IdProv);
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.SelectedValue = IdDist;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombre.Text.Trim() == "")
                {
                    throw new Exception("El titulo es obligatorio.");
                }

                if (pbFoto.Image == null)
                {
                    throw new Exception("Debe registrar la foto.");
                }

                if (cboDepartamento.SelectedIndex == 0 || cboDistrito.SelectedIndex == 0 || cboProvincia.SelectedIndex == 0)
                {
                    throw new Exception("Seleccione departamento, distrito y provincia");
                }

                objEmpleadoBE.nomEmpleado = txtNombre.Text.Trim();
                objEmpleadoBE.apeEmpleado = txtApellido.Text.Trim();
                objEmpleadoBE.fechIngreso = Convert.ToDateTime(dtFechIngreso.Text.ToString());
                objEmpleadoBE.fechNacimiento = Convert.ToDateTime(dtFechNacimiento.Text.ToString());
                objEmpleadoBE.numCelular = txtCelular.Text.Trim();
                objEmpleadoBE.Salario = Convert.ToSingle(txtSalario.Text.Trim());
                objEmpleadoBE.correo = txtCorreo.Text.Trim();
                objEmpleadoBE.idUbigeo = cboDepartamento.SelectedValue.ToString() +
                                         cboProvincia.SelectedValue.ToString() +
                                         cboDistrito.SelectedValue.ToString();
                objEmpleadoBE.emplUltMod = clsCredenciales.usuario;
                objEmpleadoBE.fotoEmpleado = getFoto();


                if (objEmpleadoBL.ActualizarEmpleado(objEmpleadoBE) == true)
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

        private byte[] getFoto()
        {
            MemoryStream stream = new MemoryStream();
            pbFoto.Image.Save(stream, pbFoto.Image.RawFormat);

            return stream.GetBuffer();
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(),
                                cboProvincia.SelectedValue.ToString(), "01");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back
                    || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
