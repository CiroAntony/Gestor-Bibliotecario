using ProyVentas_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyBiblioteca_GUI
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibroMan01 liv01 = new LibroMan01();
            liv01.MdiParent = this;
            liv01.Show(); ;
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteMan01 client01 = new ClienteMan01();
            client01.MdiParent = this;
            client01.Show();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text  = clsCredenciales.usuario;
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de salir del aplicativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadoMan01 Emp01 = new EmpleadoMan01();
            Emp01.MdiParent = this;
            Emp01.Show();
        }
    }
}
