using ProyectoFinal.Application.Models.FichaCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Application.Services.Interfaces
{
    public interface IFichaServices
    {
        Task Add(FichaClienteRequestModel entity);
        Task Update(FichaClienteRequestModel entity, int id);
        Task<IEnumerable<FichaClienteResponseModel>> GetAll();
        Task<FichaClienteResponseModel> GetById(int id);
        Task Delete(int id);

    }
}
