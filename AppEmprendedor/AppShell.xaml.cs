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
            Routing.RegisterRoute(nameof(Paginas.Home), typeof(Paginas.Home));
            Routing.RegisterRoute(nameof(Paginas.Menu), typeof(Paginas.Menu));
            Routing.RegisterRoute(nameof(ModuloTareas.NewPage1), typeof(ModuloTareas.NewPage1));

//            Routing.RegisterRoute("home", typeof(Paginas.Home));
        }
    }
}