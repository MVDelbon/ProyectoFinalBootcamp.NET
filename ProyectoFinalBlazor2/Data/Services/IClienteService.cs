using ProyectoFinalBlazor2.Data.Dtos.Cliente;

namespace ProyectoFinalBlazor2.Data.Services
{
    public interface IClienteService
    {
        Task<List<ClienteResponseModel>> GetClientes();
        Task<ClienteDto> GetClienteById(int Id);
        Task PostCliente(ClienteDto cliente);
        Task PutCliente(ClienteDto cliente, int Id);
        Task Delete(int Id);
    }
}



