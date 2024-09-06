
using TP5_ApiFakeStore.Models;
using TP5_ApiFakeStore.ViewsModels;

namespace TP5_ApiFakeStore.Views;
public partial class ProductoDetallePage : ContentPage
{
    public ProductoDetallePage(Producto param)
    {
        InitializeComponent();

        ProductoDetalleViewModel vm = new ProductoDetalleViewModel();
        this.BindingContext = vm;
        vm.Producto = param;
    }
}