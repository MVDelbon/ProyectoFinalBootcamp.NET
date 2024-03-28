using AutoMapper;
using ProyectoFinal.Application.Models.Registro;
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
    public class RegistroServices : IRegistroServices
    {
        private readonly IRegistroRepository _registroRepository;
        private readonly IMapper _mapper;

        public RegistroServices(IRegistroRepository registroRepository, IMapper mapper)
        {
            _registroRepository = registroRepository;
            _mapper = mapper;
        }

        //Add
        public async Task Add(RegistroRequestModel entity)
        {
            var registroEntity = _mapper.Map<RegistroEntity>(entity);
            registroEntity.CreatedBy = 1;
            registroEntity.UpdatedBy = 1;
            await _registroRepository.AddAsync(registroEntity);
            await _registroRepository.SaveChanges();
        }

        //Update 
        public async Task Update(RegistroRequestModel entity, int id)
        {
            RegistroEntity registroEntityFound = await _registroRepository.GetByIdAsync(id) ?? throw new Exception("El id ingresado no existe");
            var registroEntity = _mapper.Map(entity, registroEntityFound);
            await _registroRepository.UpdateAsync(registroEntity);
            await _registroRepository.SaveChanges();
        }

        //GetAll
        public async Task<IEnumerable<RegistroResponseModel>> GetAll()
        {
            var registroEntity = await _registroRepository.GetAllAsync();
            var registroResponseModel = _mapper.Map<IEnumerable<RegistroResponseModel>>(registroEntity);
            return registroResponseModel;
        }

        //GetById
        public async Task<RegistroResponseModel> GetById(int id)
        {
            var registroEntity = await _registroRepository.GetByIdAsync(id);
            var registroResponseModel = _mapper.Map<RegistroResponseModel>(registroEntity);
            return registroResponseModel;
        }

        //Delete
        public async Task Delete(int id)
        {
            await _registroRepository.DeleteAsync(id);
            await _registroRepository.SaveChanges();
        }
    }
}
