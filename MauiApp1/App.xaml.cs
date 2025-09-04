namespace MauiApp1
{
    // Declara a classe App, que herda de Application (classe base do MAUI para todo aplicativo)
    // O "partial" indica que parte dessa classe também está definida em outro arquivo (App.xaml)
    public partial class App : Application
    {
        // Construtor da classe App
        // Esse método é chamado quando o aplicativo inicia
        public App()
        {
            // Carrega os componentes definidos em App.xaml
            // (como estilos, recursos globais e configurações do app)
            InitializeComponent();
        }
        // Esse método cria a janela principal do aplicativo
        // "override" significa que estamos sobrescrevendo o método da classe base (Application)
        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Cria uma nova janela para o app
            // Define o conteúdo inicial da janela como "AppShell",
            // que é responsável por controlar a navegação entre as páginas
            return new Window(new AppShell());
        }
    }
}