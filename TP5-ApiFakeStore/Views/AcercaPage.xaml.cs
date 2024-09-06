using TP5_ApiFakeStore.ViewsModels;
namespace TP5_ApiFakeStore.Views;

public partial class AcercaPage : ContentPage
{
	public AcercaPage()
	{
		InitializeComponent();
        AcercaViewModel viewModel = new AcercaViewModel();
        this.BindingContext = viewModel;
    }
}