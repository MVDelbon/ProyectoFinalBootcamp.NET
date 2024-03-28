using Microsoft.AspNetCore.Mvc;
using ProyectoFinalBlazor2.Data.Dtos.Cliente;
using ProyectoFinalBlazor2.Data.Dtos.Usuario;
using ProyectoFinalBlazor2.Shared;


namespace ProyectoFinalBlazor2.Data.Services
{
    public class UsuarioSalonService : IUsuarioSalonService
    {
        private readonly HttpClient _client;

        public UsuarioSalonService(HttpClient client) 
        {
            _client = client;
        }

        public async Task PostUsuarioSalon(UsuarioSalonRequestModel usuarioSalonRequestModel)
        {
            await _client.PostAsJsonAsync(requestUri: "api/UsuarioSalon", usuarioSalonRequestModel);
        }

        public async Task<string> Login(UsuarioSalonRequestModel usuarioSalonRequestModel)
        {
            await _client.PostAsJsonAsync(requestUri: "api/Login", usuarioSalonRequestModel);
            return "Su usuario se ha creado con extio.";
        }


    }
}
