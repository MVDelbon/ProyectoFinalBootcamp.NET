using ProyectoFinalBlazor2.Data.Dtos.Cliente;
using ProyectoFinalBlazor2.Data.Dtos.Usuario;

namespace ProyectoFinalBlazor2.Data.Services
{
    public interface IUsuarioSalonService
    {
        Task <string>Login(UsuarioSalonRequestModel usuarioSalonRequestModel);
        Task PostUsuarioSalon(UsuarioSalonRequestModel usuarioSalonRequestModel);
    }
}
