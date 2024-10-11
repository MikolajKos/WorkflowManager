using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface ISpecialisations
    {
        Task<ServiceResponse> AddAsync(Specialisation specialisation);
        Task<ServiceResponse> UpdateAsync(Specialisation specialisation);
        Task<ServiceResponse> DeleteAsync(int id);
        Task<ServiceResponse> GetAsync();
        Task<ServiceResponse?> GetByIdAsync(int id);
    }
}
