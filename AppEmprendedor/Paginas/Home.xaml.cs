namespace AppEmprendedor.Paginas;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private void Iconmenu_Tapped(object sender, TappedEventArgs e)
    {
		DisplayAlert("Mensaje", "Hola", "Aceptar");
		Shell.Current.GoToAsync(nameof(Paginas.Menu));
    }


}