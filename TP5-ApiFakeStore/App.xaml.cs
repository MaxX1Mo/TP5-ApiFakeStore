using TP5_ApiFakeStore.Views;
namespace TP5_ApiFakeStore
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
