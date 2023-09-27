namespace AppEmprendedor.Paginas;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private void iconmenu_Tapped(object sender, TappedEventArgs e)
    {
		DisplayAlert("Mensaje", "Hola", "Aceptar");
    }


}