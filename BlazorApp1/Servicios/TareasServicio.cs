using BlazorApp1.Models;

namespace BlazorApp1.Servicios
{

    public interface ITareasServicio
    {
        public List<Tarea> Listar();
        public void Agregar(Tarea tarea);
    }


    public class TareasServicio: ITareasServicio
    {

        private List<Tarea> Tareas = new List<Tarea>();

        public TareasServicio()
        {

            Tarea T = new Tarea();

            T.Id = Guid.NewGuid().ToString();
            T.Nombre = "Aprender Blazor";
            T.Completada = false;

            Tareas.Add(T);

            T = new Tarea();

            T.Id = Guid.NewGuid().ToString();
            T.Nombre = "Aprender Bootstrap";
            T.Completada = false;
            Tareas.Add(T);
        }

        public List<Tarea> Listar()
        {
            return Tareas;
        }


        public void Agregar(Tarea tarea)
        {
            tarea.Id = Guid.NewGuid().ToString();
            Tareas.Add(tarea);
        }

    }
}
