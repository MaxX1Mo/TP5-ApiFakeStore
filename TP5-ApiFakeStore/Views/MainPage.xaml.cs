
using TP5_ApiFakeStore.ViewsModels;

namespace TP5_ApiFakeStore
    
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            MainViewModel viewModel = new MainViewModel();
            this.BindingContext = viewModel;
        }
    }

}
