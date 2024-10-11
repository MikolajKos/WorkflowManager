using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface IToDoTask
    {
        Task<ServiceResponse> AddAsync(ToDoTask toDoTask);
        Task<ServiceResponse> UpdateAsync(ToDoTask toDoTask);
        Task<ServiceResponse> DeleteAsync(int id);
        Task<ServiceResponse> GetAsync();
        Task<ServiceResponse?> GetByIdAsync(int id);
    }
}
