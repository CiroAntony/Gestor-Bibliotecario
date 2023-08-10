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
    public partial class ClienteMan02 : Form
    {
        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();
        UbigeoBL objUbigeoBL = new UbigeoBL();

        public ClienteMan02()
        {
            InitializeComponent();
        }

        private void ClienteMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("14", "01", "01");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            cboDepartamento.DataSource = objUbigeoBL.ListarDepartamento();
            cboDepartamento.DisplayMember = "Departamento";
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

                objClienteBE.nomCliente = txtNombre.Text.ToString().Trim();
                objClienteBE.apeCliente = txtApellido.Text.ToString().Trim();
                objClienteBE.dni = txtDNI.Text.ToString().Trim();

                objClienteBE.idUbigeo = cboDepartamento.SelectedValue.ToString() +
                    cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();

                objClienteBE.correo = txtCorreo.Text.ToString().Trim();
                objClienteBE.direccion = txtDireccion.Text.ToString().Trim();
                objClienteBE.fotoCliente = File.ReadAllBytes(openFileDialog1.FileName);
                objClienteBE.celular = txtCelular.Text.ToString().Trim();
                objClienteBE.ocupacion = txtOcupacion.Text.ToString().Trim();
                objClienteBE.estCliente = Convert.ToInt16(chkActivo.Checked);
                objClienteBE.empRegistro = clsCredenciales.usuario;


                if (objClienteBL.InsertarCliente(objClienteBE) == true)
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

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");

        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");


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

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
