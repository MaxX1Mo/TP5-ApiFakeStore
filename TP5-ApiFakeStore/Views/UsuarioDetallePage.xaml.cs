using TP5_ApiFakeStore.Models;
using TP5_ApiFakeStore.ViewsModels;

namespace TP5_ApiFakeStore.Views;

public partial class UsuarioDetallePage : ContentPage
{
    public UsuarioDetallePage(Usuario user)
    {
        InitializeComponent();

        UsuarioDetalleViewModel vm = new UsuarioDetalleViewModel();
        this.BindingContext = vm;
        vm.Usuario = user;
    }
}