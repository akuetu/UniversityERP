using Enrollment.Infrastructure.Data.Interfaces;
using Enrollment.Services.CustomException;
using Enrollment.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Enrollment.Services
{

    public class CrudService<T>: ICrudService<T> where T: class
    {
        private readonly ICrudRepository<T> _crudRepository;
        public CrudService(ICrudRepository<T> crudRepository)
        {
            _crudRepository = crudRepository;
        }

        public async Task<int> DeleteEntity(T entity)
        {
            return await _crudRepository.DeleteEntity(entity);
        }


        public async Task<IReadOnlyList<T>> GetByIdAsync(T entity)
        {
            return await _crudRepository.GetByIdAsync(entity);
        }
        public async Task<IReadOnlyList<T>> GetEntityList()
        {
            return await _crudRepository.GetEntityList();
        }

        public async Task<T> SaveEntity(T entity)
        {
            try
            {
                await _crudRepository.SaveEntity(entity);
            }
            catch(DbUpdateException ex) when (ex.InnerException.Message.Contains("duplicate"))
            {               
                throw new DuplicateNameException("Error: Duplicate entity name.");
            }
            catch (Exception ex)
            {
               
                throw new Exception(ex.Message);
            }
            return entity;
        }

        public async Task<int> UpdateEntity(T entity)
        {
            return await _crudRepository.UpdateEntity(entity);
        }
    }
}
