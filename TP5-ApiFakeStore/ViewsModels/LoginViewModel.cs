
using TP5_ApiFakeStore.Service;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TP5_ApiFakeStore.Views;

namespace TP5_ApiFakeStore.ViewsModels
{

    public partial class LoginViewModel : BaseViewModel
    {
        private readonly IUsuarioService _usuarioService;

        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private string errorMessage;

        [ObservableProperty]
        private bool isErrorVisible;

        public LoginViewModel(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [RelayCommand]
        private async Task LoginAsync()
        {
            IsErrorVisible = false;
            ErrorMessage = string.Empty;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                ErrorMessage = "Por favor, introduzca el nombre de usuario y la contraseña.";
                IsErrorVisible = true;
                return;
            }

            try
            {
                var token = await _usuarioService.AuthenticateUserAsync(Username, Password);

                if (!string.IsNullOrEmpty(token))
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
                }
                else
                {
                    ErrorMessage = "contraseña o nombre de usuario incorrecto.";
                    IsErrorVisible = true;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Login failed: {ex.Message}";
                IsErrorVisible = true;
            }
        }
    }

   
}
