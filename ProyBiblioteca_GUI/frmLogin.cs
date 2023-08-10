using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ProyBiblioteca_BL;
using ProyBiblioteca_BE;

namespace ProyBiblioteca_GUI
{
    public partial class frmLogin : Form
    {
        int intentos = 0;
        int tiempo = 40;

        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() != "" & txtPassword.Text.Trim() != "")
            {
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtLogin.Text);

                if (objUsuarioBE.Login_Usuario == null)
                {
                    MessageBox.Show("Usuario no existe",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                }
                else if (txtLogin.Text == objUsuarioBE.Login_Usuario & txtPassword.Text == objUsuarioBE.Pass_Usuario)
                {
                    this.Hide();
                    timer1.Enabled = false;
                    clsCredenciales.usuario = objUsuarioBE.Login_Usuario;
                    clsCredenciales.password = objUsuarioBE.Pass_Usuario;
                    clsCredenciales.Nivel = objUsuarioBE.Niv_Usuario;
                    MDIPrincipal mdi = new MDIPrincipal();
                    mdi.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o Password incorrectos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                }
            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
            }

            if (intentos == 4)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
