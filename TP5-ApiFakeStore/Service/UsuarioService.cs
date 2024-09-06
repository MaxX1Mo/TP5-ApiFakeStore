﻿using TP5_ApiFakeStore.Models;
using System.Net.Http.Headers;
using System.Text.Json;
using TP5_ApiFakeStore.Utils;
using System.Net.Http.Json;
using System.Text;

namespace TP5_ApiFakeStore.Service
{
    public class UsuarioService : IUsuarioService
    {
        HttpClient client;

        private static JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public UsuarioService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(Constants.ApiDataServer);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IEnumerable<Usuario>> GetUsersAsync()
        {
            var response = await client.GetAsync(Constants.UsersEndpoint); 

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<IEnumerable<Usuario>>(options);

            return default;
        }

        //El endpoint de Login recibe un cuerpo con las credenciales de usuario(nombre de usuario y contraseña) en una petición POST, y devuelve un token de autenticación si las credenciales son correctas
        public async Task<string> AuthenticateUserAsync(string username, string password)
        {
            var loginData = new
            {
                username = username,
                password = password
            };

            var content = new StringContent(JsonSerializer.Serialize(loginData), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(Constants.LoginEndpoint, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<Login>();
                return result?.Token;
            }

            return null;
        }
    }
}
