
using TP5_ApiFakeStore.Service;
using TP5_ApiFakeStore.ViewsModels;

namespace TP5_ApiFakeStore.Views;

public partial class ProductoListaPage : ContentPage
{
    public ProductoListaPage()
    {
        ProductoService service = new ProductoService();
        ProductoListaViewModel vm = new ProductoListaViewModel(service);
        InitializeComponent();
        this.BindingContext = vm;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        var vm = BindingContext as ProductoListaViewModel;

        if (vm != null)
        {
            await vm.GetProductosCommand.ExecuteAsync(null);
        }
    }
}