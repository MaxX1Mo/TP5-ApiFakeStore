using TP5_ApiFakeStore.Models;

namespace TP5_ApiFakeStore.Service
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetUsersAsync();
        
        Task<string> AuthenticateUserAsync(string username, string password);

    }
}
