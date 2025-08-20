using System;

namespace BibliotecaApp
{
    public class Prestamo
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Libro Libro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }

        public Prestamo(int id, Usuario usuario, Libro libro, DateTime fechaPrestamo)
        {
            Id = id;
            Usuario = usuario;
            Libro = libro;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = null;
        }

        public void Devolver()
        {
            FechaDevolucion = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Libro.Titulo} prestado a {Usuario.Nombre} el {FechaPrestamo.ToShortDateString()}" +
                   (FechaDevolucion.HasValue ? $", devuelto el {FechaDevolucion.Value.ToShortDateString()}" : "");
        }
    }
}
