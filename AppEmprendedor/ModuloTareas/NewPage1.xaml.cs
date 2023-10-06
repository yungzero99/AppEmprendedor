using AppEmprendedor.Modelos;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AppEmprendedor.ModuloTareas;


public partial class NewPage1 : ContentPage
{
    public ICommand NavigateToHomeCommand { get; }
    private List<Tarea> Tareas = new List<Tarea>();


    public NewPage1()
    {
        InitializeComponent();
        NavigateToHomeCommand = new   Command( async() =>  await Shell.Current.GoToAsync(nameof(MainPage)));

    }

    protected override void OnAppearing()
    {

        base.OnAppearing();

        var tareas = new ObservableCollection<Modelos.Tarea>(TareaRepositorio.GetTareas());
        TareasListView.ItemsSource = tareas;
    }

    private void TareasListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (TareasListView.SelectedItem != null)
        {
        }
    }

    private void TareasListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        TareasListView.SelectedItem = null;
        
    }

    private void BtnAddTarea_Clicked(object sender, EventArgs e)
    {
        //make this button to add tasks

    new Tarea { Titulo = "Tarea 1", FechaLimite = DateTime.Today, Estado = "jjj" };

       // Tareas.Add(Tarea);
    }

    private void BtnEditTarea_Clicked(object sender, EventArgs e)
    {

    }

    private void BtnDeleteTarea_Clicked(object sender, EventArgs e)
    {

    }

}