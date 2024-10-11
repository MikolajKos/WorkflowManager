using Application.Contracts;
using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementations
{
    public class PositionRepo : IPosition
    {
        public Task<ServiceResponse> AddAsync(Position position)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse> UpdateAsync(Position position)
        {
            throw new NotImplementedException();
        }
    }
}
