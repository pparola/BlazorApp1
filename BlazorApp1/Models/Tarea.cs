namespace BlazorApp1.Models
{
    public class Tarea
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public bool Completada { get; set; }

        public Tarea()
        {
            Id = string.Empty;
            Nombre = string.Empty;
            Completada = false;
        }
    }
}
