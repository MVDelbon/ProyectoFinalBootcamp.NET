using ProyectoFinal.Application.Models.FichaCliente;
using ProyectoFinal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace ProyectoFinal.Application.Profiles
{
    public class FichaClienteProfile : Profile
    {
        public FichaClienteProfile()
        {
            CreateMap<FichaClienteEntity, FichaClienteResponseModel>().ReverseMap();
            CreateMap<FichaClienteRequestModel, FichaClienteEntity>().ReverseMap();

        }
    }
}
