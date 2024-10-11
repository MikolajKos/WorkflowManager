using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface IEmployeeSpecialisation
    {
        Task<ServiceResponse> AddAsync(Employee employee);
        Task<ServiceResponse> DeleteAsync(int id);
    }
}
