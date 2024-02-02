﻿using Ejercicio8AdministradorDeTareas.MVVM.Models;
using Ejercicio8AdministradorDeTareas.MVVM.Views;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8AdministradorDeTareas.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class TareasViewModel
    {
        public ObservableCollection<Tarea> Tareas { get; set; } = new ObservableCollection<Tarea>();
        public ObservableCollection<Categoria> Categorias { get; set; } = new ObservableCollection<Categoria>();
        public string Nombre { get; set; }
        public string CategoriaRadioButton { get; set; }
        public Command CambiarPaginaCommand { get; set; }
        public Command AgregarTareaCommand { get; set; }
        public Command AgregarCategoriaCommand { get; set; }

        public TareasViewModel()
        {
            Categorias.Add(new Categoria("Curso .NET MAUI"));
            Categorias.Add(new Categoria("Tutoriales"));
            Categorias.Add(new Categoria("Compras"));

            Tareas.Add(new Tarea("Hacer ejercicio", Categorias[0]));
            Tareas.Add(new Tarea("Hacer ejercicio avanzado", Categorias[0]));
            Tareas.Add(new Tarea("Tutorial JavaScript", Categorias[1]));
            Tareas.Add(new Tarea("Tutorial Java", Categorias[1]));
            Tareas.Add(new Tarea("Huevos", Categorias[2]));
            Tareas.Add(new Tarea("Patatas", Categorias[2]));

            foreach (Categoria categoria in Categorias)
            {
                int tareasTerminadas = 0;
                int tareasNoTerminadas = 0;
                int totalTareas = 0;

                foreach (Tarea tarea in Tareas)
                {
                    if (tarea.Categoria == categoria)
                    {
                        if (tarea.Completada)
                        {
                            tareasTerminadas++;
                        }
                        else
                        {
                            tareasNoTerminadas++;
                        }

                        totalTareas++;
                    }
                }

                categoria.TareasTerminadas = tareasTerminadas;
                categoria.TareasNoTerminadas = tareasNoTerminadas;
            }

            CambiarPaginaCommand = new Command((page) =>
            {
                ((TareasView)page).Navigation.PushAsync(new AgregarTareaView(this));
            });

            AgregarTareaCommand = new Command((page) =>
            {
                Categoria categoriaSeleccionada = Categorias.First(categoria => categoria.IsSelected);
                Tareas.Add(new Tarea(Nombre, categoriaSeleccionada));

                categoriaSeleccionada.TareasNoTerminadas++;
                Nombre = "";

                ((AgregarTareaView)page).Navigation.PopAsync();
            });

            AgregarCategoriaCommand = new Command(() =>
            {
                Categorias.Add(new Categoria(Nombre));
            });
        }
    }
}
