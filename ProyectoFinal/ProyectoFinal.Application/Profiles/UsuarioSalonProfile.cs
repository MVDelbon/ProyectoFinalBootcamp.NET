using AutoMapper;
using ProyectoFinal.Application.Models.UsuarioSalon;
using ProyectoFinal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Application.Profiles
{
    public class UsuarioSalonProfile : Profile
    {
        public UsuarioSalonProfile()
        {
            CreateMap<UsuarioSalonEntity, UsuarioSalonResponseModel>().ReverseMap();
            CreateMap<UsuarioSalonRequestModel, UsuarioSalonEntity>().ReverseMap();

        }
    }
}
