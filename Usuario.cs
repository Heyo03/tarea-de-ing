namespace BibliotecaApp
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }

        public Usuario(int id, string nombre, string matricula)
        {
            Id = id;
            Nombre = nombre;
            Matricula = matricula;
        }

        public override string ToString()
        {
            return $"{Nombre} ({Matricula})";
        }
    }
}
