
using TP5_ApiFakeStore.Models;
using TP5_ApiFakeStore.Utils;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TP5_ApiFakeStore.ViewsModels
{
    public partial class UsuarioDetalleViewModel : BaseViewModel
    {
        [ObservableProperty]
        Usuario usuario;

        public UsuarioDetalleViewModel()
        {
            Title = "Detalle de Usuarios";
        }

        [RelayCommand]
        private async Task GoBack()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
