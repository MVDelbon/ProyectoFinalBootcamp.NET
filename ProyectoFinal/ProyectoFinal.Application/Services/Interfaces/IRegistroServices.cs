using ProyectoFinal.Application.Models.Registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Application.Services.Interfaces
{
    public interface IRegistroServices
    {
        Task Add(RegistroRequestModel entity);
        Task Update(RegistroRequestModel entity, int id);
        Task<IEnumerable<RegistroResponseModel>> GetAll();
        Task<RegistroResponseModel> GetById(int id);
        Task Delete(int id);
    }
}
