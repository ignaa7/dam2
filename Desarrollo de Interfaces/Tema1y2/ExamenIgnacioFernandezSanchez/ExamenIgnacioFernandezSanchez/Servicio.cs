using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Servicio
    {
        public Queue<Tarea> Tareas { get; set; }
        public Stack<Tarea> TareasCompletadas { get; set; }

        public Servicio()
        {
            Tareas = new Queue<Tarea>();
            TareasCompletadas = new Stack<Tarea>();
        }

        public void AgregarTarea(string nombre, DateTime fecha)
        {
            Tareas.Enqueue(new Tarea(nombre, fecha));
        }

        public void EliminarTarea()
        {
            Tarea tarea = Tareas.Dequeue();
            TareasCompletadas.Push(tarea);
        }

        public Dictionary<string, Tarea[]> MostrarTareas()
        {
            Dictionary<string, Tarea[]> tareas = new Dictionary<string, Tarea[]>();
            tareas.Add("cola", Tareas.ToArray());
            tareas.Add("pila", TareasCompletadas.ToArray());

            return tareas;
        }
    }
}
