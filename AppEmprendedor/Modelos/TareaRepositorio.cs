using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmprendedor.Modelos
{
    internal class TareaRepositorio
    {
        public static List<Tarea> Tareas = new List<Tarea>()
        {
            new Tarea {Titulo = "Tarea 1", FechaLimite = DateTime.Today, Estado = "Hecha"},
            new Tarea {Titulo = "Tarea 2", FechaLimite = DateTime.Now, Estado = "Pendiente"},
            new Tarea {Titulo = "Tarea 3", FechaLimite = DateTime.Now, Estado = "Pendiente"},
            new Tarea{Titulo = "Tarea 4", FechaLimite = DateTime.Now, Estado = "Pendiente"},
        };

        public static List<Tarea> GetTareas() => Tareas;

        public static Tarea GetTareaByTitlte(string TareaTitulo)
        {
            var tarea = Tareas.FirstOrDefault(x => x.Titulo == TareaTitulo);
            if (tarea != null)
            {
                return new Tarea
                {
                    Titulo = tarea.Titulo,
                    FechaLimite = tarea.FechaLimite,
                    Estado = tarea.Estado
                };
            }

            return null;
        }

        public static void UpdateTarea(string TareaTitulo, Tarea tarea)
        {
            if (TareaTitulo != tarea.Titulo) return;

            var TareaUpdate = Tareas.FirstOrDefault(x => x.Titulo == TareaTitulo);
            if (TareaUpdate != null)
            {
                //AutoMapper
                TareaUpdate.Titulo = tarea.Titulo;
                TareaUpdate.FechaLimite = tarea.FechaLimite;
                TareaUpdate.Estado = tarea.Estado;
            }
        }

        public static void AddTareas(Tarea tarea)
        {
            Tareas.Add(tarea);
        }

        public static void DeleteTarea(string TareaTitulo)
        {
            var Tarea = Tareas.FirstOrDefault(x => x.Titulo == TareaTitulo);
            if (Tarea != null)
            {
                Tareas.Remove(Tarea);
            }
        }

    }
}
