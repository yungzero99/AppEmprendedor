using Microsoft.Maui.Controls;

namespace AppEmprendedor
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void BtnLogear_Clicked(object sender, EventArgs e)
        {
            //make this button go to Login page
            Shell.Current.GoToAsync("login");
           // Shell.Current.GoToAsync("signup");
            return;
        }

        private void BtnCrearCuenta_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Inicio de sesion", "Hola", "OK");
            Shell.Current.GoToAsync("signup");
            return;
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            DisplayAlert("Inicio de sesion", "Hola", "OK");
            return;
        }

        private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
        {
            DisplayAlert("Registrarse", "Hola", "OK");
            return;
        }

        private void TapGestureRecognizer_Tapped_2(object sender, TappedEventArgs e)
        {
            DisplayAlert("Alerta", "Hola", "OK");
            return;
        }


    }
}