using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using ProyBiblioteca_BE;
using ProyBiblioteca_BL;

namespace ProyBiblioteca_GUI
{
    public partial class ClienteMan03 : Form
    {

        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();

        Boolean blnCambio;
        Byte[] FotoOriginal;

        public ClienteMan03()
        {
            InitializeComponent();
        }
        
        
        public String Codigo {get; set;}
        
         private void ClienteMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objClienteBE = objClienteBL.ConsultarCliente(this.Codigo);

                lblCodigo.Text = objClienteBE.idCliente;
                txtNombre.Text = objClienteBE.nomCliente;
                txtApellido.Text = objClienteBE.apeCliente;
                txtDNI.Text = objClienteBE.dni;
                txtDireccion.Text = objClienteBE.direccion;
                txtCorreo.Text = objClienteBE.correo;
                txtCelular.Text = objClienteBE.celular;
                txtOcupacion.Text = objClienteBE.ocupacion;
                chkActivo.Checked = Convert.ToBoolean(objClienteBE.estCliente);

                if (objClienteBE.fotoCliente.Length == 0)
                {
                    pbFoto.Image = null;

                }
                else
                {
                    MemoryStream fotoStream = new MemoryStream(objClienteBE.fotoCliente);
                    pbFoto.Image = Image.FromStream(fotoStream);
                    FotoOriginal = objClienteBE.fotoCliente;
                }

                String idUbigeo = objClienteBE.idUbigeo;

                CargarUbigeo(idUbigeo.Substring(0, 2), idUbigeo.Substring(2, 2), idUbigeo.Substring(4, 2));


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
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

                objClienteBE.nomCliente = txtNombre.Text.ToString().Trim();
                objClienteBE.apeCliente = txtApellido.Text.ToString().Trim();
                objClienteBE.dni = txtDNI.Text.ToString().Trim();
                objClienteBE.idUbigeo = cboDepartamento.SelectedValue.ToString() +
                                            cboProvincia.SelectedValue.ToString() +
                                            cboDistrito.SelectedValue.ToString();
                objClienteBE.direccion = txtDireccion.Text.ToString().Trim();
                objClienteBE.correo = txtCorreo.Text.ToString().Trim();
                objClienteBE.fotoCliente = getFoto();
                objClienteBE.celular = txtCelular.Text.ToString().Trim();
                objClienteBE.ocupacion = txtOcupacion.Text.ToString().Trim();
                objClienteBE.emplUltMod = clsCredenciales.usuario;

                if (chkActivo.Checked)
                {
                    objClienteBE.estCliente = 1;

                }
                else
                {
                    objClienteBE.estCliente = 0;
                }

                if (objClienteBL.ActualizarCliente(objClienteBE) == true)
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
                MessageBox.Show("Se ha producido el error: " + ex.Message);
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

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)){
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
