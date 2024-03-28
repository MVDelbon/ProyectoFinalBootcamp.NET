using AutoMapper;
using ProyectoFinal.Application.Models.Registro;
using ProyectoFinal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoFinal.Application.Profiles
{
    public class RegistroProfile : Profile
    {
        public RegistroProfile()
        {
            CreateMap<RegistroEntity, RegistroResponseModel>().ReverseMap();
            CreateMap<RegistroRequestModel, RegistroEntity>().ReverseMap();
        }

    }
}
