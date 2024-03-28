using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalBlazor2.Data.Dtos;
using ProyectoFinalBlazor2.Data.Dtos.Cliente;
using ProyectoFinalBlazor2.Pages;
using ProyectoFinalBlazor2.Pages.Clientes;
using static System.Net.WebRequestMethods;

namespace ProyectoFinalBlazor2.Data.Services
{
    public class ClienteService : IClienteService
    {
        private readonly HttpClient _client;

        public ClienteService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<ClienteResponseModel>> GetClientes()
        {
            var result = await _client.GetFromJsonAsync<List<ClienteResponseModel>>(requestUri: "api/FichaCliente");
            return result;
        }

        public async Task<ClienteDto> GetClienteById(int Id)
        {
            var cliente = await _client.GetFromJsonAsync<ClienteDto>($"api/FichaCliente/{Id}");
            return cliente;
        }


        public async Task PostCliente(ClienteDto cliente)
        {
           await _client.PostAsJsonAsync(requestUri: "api/FichaCliente", cliente);
           if(cliente.Status == true)
            {
                await GetClientes();
            }
            else
            {
                throw new Exception("No se ha podido crear");
            }
  
        }

        public async Task PutCliente(ClienteDto cliente, int Id)
        {
           await _client.PutAsJsonAsync(requestUri: $"api/FichaCliente/{cliente.fichaClienteEntityId}", cliente);
        }

        public async Task Delete(int Id)
        {
            await _client.DeleteAsync(requestUri: $"api/FichaCliente/{Id}");
        }


      
    }
}
