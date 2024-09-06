
using CommunityToolkit.Mvvm.ComponentModel;

namespace TP5_ApiFakeStore.ViewsModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool isBusy;

        [ObservableProperty]
        private string title;
    }
}
