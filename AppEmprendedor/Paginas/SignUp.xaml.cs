namespace AppEmprendedor.Paginas;

public partial class SignUp : ContentPage
{
	public SignUp()
	{
		InitializeComponent();
	}

    private void BtnCrearCuenta_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}