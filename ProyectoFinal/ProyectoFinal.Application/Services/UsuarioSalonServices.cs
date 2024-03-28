using AutoMapper;
using ProyectoFinal.Application.Models.UsuarioSalon;
using ProyectoFinal.Application.Services.Interfaces;
using ProyectoFinal.Domain.Entities;
using ProyectoFinal.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Application.Services
{
    public class UsuarioSalonServices : IUsuarioSalonServices
    {
        private readonly IUsuarioSalonRepository _usuarioSalonRepository;
        private readonly IMapper _mapper;
        private readonly IJWTService _jwtService;

        public UsuarioSalonServices(IUsuarioSalonRepository usuarioSalonRepository, IMapper mapper, IJWTService jwtService)
        {
            _usuarioSalonRepository = usuarioSalonRepository;
            _mapper = mapper;
            _jwtService = jwtService;
        }

        //Add
        public async Task Add(UsuarioSalonRequestModel entity)
        {
            var usuarioSalonEntity = _mapper.Map<UsuarioSalonEntity>(entity);
            usuarioSalonEntity.CreatedBy = 1;
            usuarioSalonEntity.UpdatedBy = 1;
            await _usuarioSalonRepository.AddAsync(usuarioSalonEntity);
            await _usuarioSalonRepository.SaveChanges();
        }

        //Update 
        public async Task Update(UsuarioSalonRequestModel entity, int id)
        {
            UsuarioSalonEntity usuarioSalonEntityFound = await _usuarioSalonRepository.GetByIdAsync(id) ?? throw new Exception("El id ingresado no existe");
            var usuarioSalonEntity = _mapper.Map(entity, usuarioSalonEntityFound);
            await _usuarioSalonRepository.UpdateAsync(usuarioSalonEntity);
            await _usuarioSalonRepository.SaveChanges();
        }

        //GetAll
        public async Task<IEnumerable<UsuarioSalonResponseModel>> GetAll()
        {
            var usuarioSalonEntity = await _usuarioSalonRepository.GetAllAsync();
            var usuarioSalonResponseModel = _mapper.Map<IEnumerable<UsuarioSalonResponseModel>>(usuarioSalonEntity);
            return usuarioSalonResponseModel;
        }

        //GetById
        public async Task<UsuarioSalonResponseModel> GetById(int id)
        {
            var usuarioSalonEntity = await _usuarioSalonRepository.GetByIdAsync(id);
            var usuarioSalonResponseModel = _mapper.Map<UsuarioSalonResponseModel>(usuarioSalonEntity);
            return usuarioSalonResponseModel;
        }

        //Delete
        public async Task Delete(int id)
        {
            await _usuarioSalonRepository.DeleteAsync(id);
            await _usuarioSalonRepository.SaveChanges();
        }

        public async Task<string> Login(LoginRequestModel request)
        {
            var loginSuccess = _usuarioSalonRepository.Login(request.UserName, request.Password);

            if (loginSuccess) { return _jwtService.GenerateToken(request.UserName); }

            return "Ha ocurrido un error al intentar logearse";

        }
    }
}
