namespace ProyBiblioteca_GUI
{
    partial class EmpleadoMan02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.dtFechIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtFechNacimiento = new System.Windows.Forms.DateTimePicker();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(224, 582);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(103, 34);
            this.btnGrabar.TabIndex = 21;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(333, 582);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 34);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(192, 301);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(391, 25);
            this.txtCorreo.TabIndex = 13;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(53, 304);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(52, 17);
            this.label53.TabIndex = 12;
            this.label53.Text = "Correo:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(194, 256);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(391, 25);
            this.txtSalario.TabIndex = 11;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(53, 429);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(53, 17);
            this.label47.TabIndex = 18;
            this.label47.Text = "Distrito:";
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Items.AddRange(new object[] {
            "LIMA"});
            this.cboDistrito.Location = new System.Drawing.Point(194, 429);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(256, 25);
            this.cboDistrito.TabIndex = 19;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(194, 215);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(391, 25);
            this.txtCelular.TabIndex = 9;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(52, 219);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(51, 17);
            this.label49.TabIndex = 8;
            this.label49.Text = "Celular:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(52, 261);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(51, 17);
            this.label50.TabIndex = 10;
            this.label50.Text = "Salario:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(52, 177);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(130, 17);
            this.label51.TabIndex = 6;
            this.label51.Text = "Fecha de Nacimiento";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(52, 135);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(108, 17);
            this.label52.TabIndex = 4;
            this.label52.Text = "Fecha de Ingreso";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(194, 92);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(391, 25);
            this.txtApellido.TabIndex = 3;
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Items.AddRange(new object[] {
            "lima"});
            this.cboProvincia.Location = new System.Drawing.Point(194, 381);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(256, 25);
            this.cboProvincia.TabIndex = 17;
            this.cboProvincia.SelectionChangeCommitted += new System.EventHandler(this.cboProvincia_SelectionChangeCommitted);
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Items.AddRange(new object[] {
            "LIMA"});
            this.cboDepartamento.Location = new System.Drawing.Point(194, 341);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(256, 25);
            this.cboDepartamento.TabIndex = 15;
            this.cboDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cboDepartamento_SelectionChangeCommitted);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(49, 381);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(63, 17);
            this.label54.TabIndex = 16;
            this.label54.Text = "Provincia:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(194, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(389, 25);
            this.txtNombre.TabIndex = 1;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(52, 349);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(95, 17);
            this.label55.TabIndex = 14;
            this.label55.Text = "Departamento:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(52, 93);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(59, 17);
            this.label56.TabIndex = 2;
            this.label56.Text = "Apellido:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(52, 51);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(60, 17);
            this.label57.TabIndex = 0;
            this.label57.Text = "Nombre:";
            // 
            // dtFechIngreso
            // 
            this.dtFechIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechIngreso.Location = new System.Drawing.Point(194, 135);
            this.dtFechIngreso.Name = "dtFechIngreso";
            this.dtFechIngreso.Size = new System.Drawing.Size(221, 25);
            this.dtFechIngreso.TabIndex = 5;
            // 
            // dtFechNacimiento
            // 
            this.dtFechNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechNacimiento.Location = new System.Drawing.Point(194, 171);
            this.dtFechNacimiento.Name = "dtFechNacimiento";
            this.dtFechNacimiento.Size = new System.Drawing.Size(221, 25);
            this.dtFechNacimiento.TabIndex = 7;
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(550, 381);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(118, 114);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 73;
            this.pbFoto.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(568, 501);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 25);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EmpleadoMan02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 641);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.dtFechNacimiento);
            this.Controls.Add(this.dtFechIngreso);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.cboDistrito);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.cboProvincia);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmpleadoMan02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo empleado";
            this.Load += new System.EventHandler(this.ProductoMan02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnGrabar;
        private Button btnCancelar;
        private TextBox txtCorreo;
        private Label label53;
        private TextBox txtSalario;
        private Label label47;
        private ComboBox cboDistrito;
        private TextBox txtCelular;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label52;
        private TextBox txtApellido;
        private ComboBox cboProvincia;
        private ComboBox cboDepartamento;
        private Label label54;
        private TextBox txtNombre;
        private Label label55;
        private Label label56;
        private Label label57;
        private DateTimePicker dtFechIngreso;
        private DateTimePicker dtFechNacimiento;
        private PictureBox pbFoto;
        private Button btnGuardar;
        private OpenFileDialog openFileDialog1;
    }
}