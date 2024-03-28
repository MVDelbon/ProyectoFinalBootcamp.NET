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
    public class RegistroRepository : GenericRepository<RegistroEntity>, IRegistroRepository
    {
        public RegistroRepository(DataContext context) : base(context)
        {

        }
    }
}
