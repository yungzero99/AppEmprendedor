namespace AppEmprendedor.Paginas;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void Inicio_Tapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
    private void Tareas_Tapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Mensaje", "Hola", "Aceptar");
    }
    private void Grupos_Tapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Mensaje", "Hola", "Aceptar");
    }
    private void Ideas_Tapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Mensaje", "Hola", "Aceptar");
    }
    private void Web_Tapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Mensaje", "Hola", "Aceptar");
    }

    private void Inventario_Tapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Mensaje", "Hola", "Aceptar");
    }

    private void Finanzas_Tapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Mensaje", "Hola", "Aceptar");
    }

}