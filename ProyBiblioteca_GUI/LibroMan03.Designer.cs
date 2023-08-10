namespace ProyBiblioteca_GUI
{
    partial class LibroMan03
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cboEditorial = new System.Windows.Forms.ComboBox();
            this.cboTema = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCantPaginas = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dtFechLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(369, 347);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 34);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(245, 347);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(103, 34);
            this.btnGrabar.TabIndex = 13;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cboEditorial
            // 
            this.cboEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditorial.FormattingEnabled = true;
            this.cboEditorial.Location = new System.Drawing.Point(131, 179);
            this.cboEditorial.Name = "cboEditorial";
            this.cboEditorial.Size = new System.Drawing.Size(256, 25);
            this.cboEditorial.TabIndex = 9;
            // 
            // cboTema
            // 
            this.cboTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTema.FormattingEnabled = true;
            this.cboTema.Location = new System.Drawing.Point(132, 142);
            this.cboTema.Name = "cboTema";
            this.cboTema.Size = new System.Drawing.Size(256, 25);
            this.cboTema.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Editorial:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(131, 62);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(389, 25);
            this.txtTitulo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Paginas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titulo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "IdLibro:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.Location = new System.Drawing.Point(132, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 26);
            this.lblCodigo.TabIndex = 1;
            // 
            // txtCantPaginas
            // 
            this.txtCantPaginas.Location = new System.Drawing.Point(131, 101);
            this.txtCantPaginas.Name = "txtCantPaginas";
            this.txtCantPaginas.Size = new System.Drawing.Size(93, 25);
            this.txtCantPaginas.TabIndex = 5;
            this.txtCantPaginas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantPaginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantPaginas_KeyPress);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(541, 101);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(131, 124);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 23;
            this.pbFoto.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(566, 230);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(82, 25);
            this.btnFoto.TabIndex = 12;
            this.btnFoto.Text = "Agregar";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dtFechLanzamiento
            // 
            this.dtFechLanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechLanzamiento.Location = new System.Drawing.Point(136, 230);
            this.dtFechLanzamiento.Name = "dtFechLanzamiento";
            this.dtFechLanzamiento.Size = new System.Drawing.Size(221, 25);
            this.dtFechLanzamiento.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lanzamiento:";
            // 
            // LibroMan03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFechLanzamiento);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.txtCantPaginas);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.cboEditorial);
            this.Controls.Add(this.cboTema);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LibroMan03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar libro";
            this.Load += new System.EventHandler(this.LibroMan03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancelar;
        private Button btnGrabar;
        private ComboBox cboEditorial;
        private ComboBox cboTema;
        private Label label6;
        private TextBox txtTitulo;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label lblCodigo;
        private TextBox txtCantPaginas;
        private PictureBox pbFoto;
        private Button btnFoto;
        private OpenFileDialog openFileDialog1;
        private DateTimePicker dtFechLanzamiento;
        private Label label3;
    }
}