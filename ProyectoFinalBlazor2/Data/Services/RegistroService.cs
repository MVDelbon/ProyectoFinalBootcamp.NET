using ProyectoFinalBlazor2.Data.Dtos.Registro;

namespace ProyectoFinalBlazor2.Data.Services
{
    public class RegistroService
    {
        private readonly HttpClient _client;

        public RegistroService(HttpClient client)
        {
            _client = client;
        }

        //CAMBIAR A GETREGISTROSBYCLIENTEID
        //public async Task<IEnumerable<RegistroResponseModel>> GetRegistroAsync()
        //{
        //    var clientes = await _client.GetFromJsonAsync<ClienteResponseModel[]>(requestUri: "api/FichaCliente");
        //    return clientes;
        //}

        public async Task PostRegistroAsync(RegistroRequestModel registro)
        {
            await _client.PostAsJsonAsync(requestUri: "api/Registro", registro);
        }
    }
}
