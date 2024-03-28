using ProyectoFinal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Domain.Repositories
{
    public interface IUsuarioSalonRepository : IGenericRepository<UsuarioSalonEntity>
    {
        UsuarioSalonEntity GetByUserName(string username);
        bool Login(string username, string password);
    }
}
