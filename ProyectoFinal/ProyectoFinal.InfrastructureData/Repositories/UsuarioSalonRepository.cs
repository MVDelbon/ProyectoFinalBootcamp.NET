using ProyectoFinal.Domain.Entities;
using ProyectoFinal.Domain.Repositories;
using ProyectoFinal.InfrastructureData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.InfrastructureData.Repositories
{
    public class UsuarioSalonRepository : GenericRepository<UsuarioSalonEntity>, IUsuarioSalonRepository
    {
        public UsuarioSalonRepository(DataContext context) : base(context)
        {

        }

        public UsuarioSalonEntity GetByUserName(string username)
        {
            return this._context.UsuariosSalon.FirstOrDefault(x => x.UserName.Equals(username));
        }


        public bool Login(string username, string password)
        {
            UsuarioSalonEntity user = GetByUserName(username) ?? throw new Exception("El usuario no existe");

            if (!user.Password.Equals(password))
            {
                throw new Exception("Contraseña incorrecta");
            }
            return true;
        }
    }
}
