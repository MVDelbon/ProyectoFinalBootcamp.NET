﻿using ProyectoFinal.Domain.Entities;
using ProyectoFinal.Domain.Repositories;
using ProyectoFinal.InfrastructureData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.InfrastructureData.Repositories
{
    public class FichaClienteRepository : GenericRepository<FichaClienteEntity>, IFichaClienteRepository
    {
        public FichaClienteRepository(DataContext context) : base(context)
        {

        }
    }
}
