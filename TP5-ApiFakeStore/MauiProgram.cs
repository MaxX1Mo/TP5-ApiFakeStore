using TP5_ApiFakeStore.Service;
using TP5_ApiFakeStore.ViewsModels;
using TP5_ApiFakeStore.Views;
using Microsoft.Extensions.Logging;
using TP5_ApiFakeStore;

namespace TP5_ApiFakeStore
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialDesignIcons");
                });

            builder.Services.AddSingleton<IProductoService, ProductoService>();
            builder.Services.AddTransient<ProductoListaViewModel>();
            builder.Services.AddTransient<ProductoListaPage>();
            DependencyService.Register<IUsuarioService, UsuarioService>();


            builder.Services.AddSingleton<IUsuarioService, UsuarioService>();
            builder.Services.AddTransient<UsuarioDetallePage>();
            builder.Services.AddTransient<UsuarioListaPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
