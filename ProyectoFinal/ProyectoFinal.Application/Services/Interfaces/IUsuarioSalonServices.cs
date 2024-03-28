using ProyectoFinal.Application.Models.UsuarioSalon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Application.Services.Interfaces
{
    public interface IUsuarioSalonServices
    {
        Task Add(UsuarioSalonRequestModel entity);
        Task Update(UsuarioSalonRequestModel entity, int id);
        Task<IEnumerable<UsuarioSalonResponseModel>> GetAll();
        Task<UsuarioSalonResponseModel> GetById(int id);
        Task Delete(int id);
        Task<string> Login(LoginRequestModel request);
    }
}
