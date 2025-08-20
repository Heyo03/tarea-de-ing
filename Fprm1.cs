using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibliotecaApp
{
    public partial class Form1 : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Libro> libros = new List<Libro>();
        private List<Prestamo> prestamos = new List<Prestamo>();
        private int usuarioId = 1;
        private int libroId = 1;
        private int prestamoId = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) || string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Por favor ingresa nombre y matrícula.");
                return;
            }

            var usuario = new Usuario(usuarioId++, txtNombreUsuario.Text, txtMatricula.Text);
            usuarios.Add(usuario);
            lstUsuarios.Items.Add(usuario);
            txtNombreUsuario.Clear();
            txtMatricula.Clear();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtAutor.Text) || string.IsNullOrWhiteSpace(txtAño.Text))
            {
                MessageBox.Show("Por favor ingresa todos los datos del libro.");
                return;
            }

            if (!int.TryParse(txtAño.Text, out int año))
            {
                MessageBox.Show("El año debe ser un número.");
                return;
            }

            var libro = new Libro(libroId++, txtTitulo.Text, txtAutor.Text, año);
            libros.Add(libro);
            lstLibros.Items.Add(libro);
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAño.Clear();
        }

        private void btnPrestarLibro_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItem is Usuario usuario && lstLibros.SelectedItem is Libro libro)
            {
                var prestamo = new Prestamo(prestamoId++, usuario, libro, DateTime.Now);
                prestamos.Add(prestamo);
                lstPrestamos.Items.Add(prestamo);
            }
            else
            {
                MessageBox.Show("Selecciona un usuario y un libro.");
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (lstPrestamos.SelectedItem is Prestamo prestamo)
            {
                prestamo.Devolver();
                int index = lstPrestamos.SelectedIndex;
                lstPrestamos.Items[index] = prestamo;
            }
            else
            {
                MessageBox.Show("Selecciona un préstamo para devolver.");
            }
        }
    }
}
