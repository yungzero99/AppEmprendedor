namespace AppEmprendedor.Paginas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();

	}

    private void BtnLogear_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Registrarse", "Hola", "OK");
        Shell.Current.GoToAsync("home");
        return;
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }

}