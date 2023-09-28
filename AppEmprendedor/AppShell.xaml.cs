namespace AppEmprendedor
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //registra las rutas de las paginas login y signUp
            Routing.RegisterRoute("login", typeof(Paginas.Login));
            Routing.RegisterRoute("signup", typeof(Paginas.SignUp));
            Routing.RegisterRoute("home", typeof(Paginas.Home));
            Routing.RegisterRoute(nameof(Paginas.Menu), typeof(Paginas.Menu));

//            Routing.RegisterRoute("home", typeof(Paginas.Home));
        }
    }
}