namespace BibliotecaApp
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Año { get; set; }

        public Libro(int id, string titulo, string autor, int año)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Año = año;
        }

        public override string ToString()
        {
            return $"{Titulo} - {Autor} ({Año})";
        }
    }
}
