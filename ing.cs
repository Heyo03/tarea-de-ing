namespace BibliotecaApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.btnPrestarLibro = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(20, 20);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.PlaceholderText = "Nombre usuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(200, 23);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(20, 50);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.PlaceholderText = "Matrícula";
            this.txtMatricula.Size = new System.Drawing.Size(200, 23);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(20, 80);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(200, 23);
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.Location = new System.Drawing.Point(20, 110);
            this.lstUsuarios.Size = new System.Drawing.Size(200, 150);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(250, 20);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PlaceholderText = "Título";
            this.txtTitulo.Size = new System.Drawing.Size(200, 23);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(250, 50);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.PlaceholderText = "Autor";
            this.txtAutor.Size = new System.Drawing.Size(200, 23);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(250, 80);
            this.txtAño.Name = "txtAño";
            this.txtAño.PlaceholderText = "Año";
            this.txtAño.Size = new System.Drawing.Size(200, 23);
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.Location = new System.Drawing.Point(250, 110);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(200, 23);
            this.btnAgregarLibro.Text = "Agregar Libro";
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // lstLibros
            // 
            this.lstLibros.Location = new System.Drawing.Point(250, 140);
            this.lstLibros.Size = new System.Drawing.Size(200, 120);
            // 
            // btnPrestarLibro
            // 
            this.btnPrestarLibro.Location = new System.Drawing.Point(480, 20);
            this.btnPrestarLibro.Name = "btnPrestarLibro";
            this.btnPrestarLibro.Size = new System.Drawing.Size(200, 23);
            this.btnPrestarLibro.Text = "Prestar Libro";
            this.btnPrestarLibro.Click += new System.EventHandler(this.btnPrestarLibro_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(480, 50);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(200, 23);
            this.btnDevolver.Text = "Devolver Libro";
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.Location = new System.Drawing.Point(480, 80);
            this.lstPrestamos.Size = new System.Drawing.Size(300, 180);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.lstUsuarios);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.btnAgregarLibro);
            this.Controls.Add(this.lstLibros);
            this.Controls.Add(this.btnPrestarLibro);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.lstPrestamos);
            this.Text = "Sistema de Gestión de Biblioteca";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.ListBox lstUsuarios;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.ListBox lstLibros;
        private System.Windows.Forms.Button btnPrestarLibro;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.ListBox lstPrestamos;
    }
}
