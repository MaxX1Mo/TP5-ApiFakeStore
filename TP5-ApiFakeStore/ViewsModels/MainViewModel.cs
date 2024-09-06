using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_ApiFakeStore.Views;


namespace TP5_ApiFakeStore.ViewsModels
{
    public partial class MainViewModel : BaseViewModel
    {
        
        public MainViewModel()
        {
            Title = "TP5 - FakeStoreApi";
        }
        
        [RelayCommand]
        public async Task GoToProductoLista()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ProductoListaPage());
        }

        [RelayCommand]
        public async Task GoToAcerca()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AcercaPage());
        }
        [RelayCommand]
        public async Task GoToUsuarioLista()
        {
           await Application.Current.MainPage.Navigation.PushAsync(new UsuarioListaPage());
        }
        
        [RelayCommand]
        public async Task Exit()
        {
            await Application.Current.MainPage.DisplayAlert("Salir", "¿Desea terminar la sesión y salir?", "Aceptar");
            await Application.Current.MainPage.Navigation.PopAsync();
        }


    }

}
