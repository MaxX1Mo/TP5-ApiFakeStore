using TP5_ApiFakeStore.ViewsModels;
using TP5_ApiFakeStore.Service;

namespace TP5_ApiFakeStore.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
        InitializeComponent();
        BindingContext = new LoginViewModel(DependencyService.Get<IUsuarioService>());
    }
}