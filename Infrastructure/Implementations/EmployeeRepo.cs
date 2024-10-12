using Application.Contracts;
using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementations
{
    public class EmployeeRepo : IEmployee
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;

        public EmployeeRepo(AppDbContext appDbContext, IMapper mapper)
        {
            this.appDbContext = appDbContext;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse> AddAsync(CreateEmployeeDTO dto)
        {
            var employee = mapper.Map<Employee>(dto); 
            appDbContext.Employees.Add(employee);
            await SaveChangesAsync();
            return new ServiceResponse(true, "Employee added.");
        }

        public async Task<ServiceResponse> DeleteAsync(int id)
        {
            var employee = await appDbContext.Employees.FindAsync(id);
            if (employee == null)
                return new ServiceResponse(false, "Employee not found.");

            appDbContext.Employees.Remove(employee);
            await SaveChangesAsync();
            return new ServiceResponse(true, "Employee deleted");
        }

        public async Task<List<Employee>> GetAsync() => await appDbContext.Employees.AsNoTracking().ToListAsync();

        public async Task<Employee> GetByIdAsync(int id) => await appDbContext.Employees.FindAsync(id);

        public async Task<ServiceResponse> UpdateAsync(Employee employee)
        {
            appDbContext.Employees.Update(employee);
            await SaveChangesAsync();
            return new ServiceResponse(true, "User Updated");
        }

        private async Task SaveChangesAsync() => await appDbContext.SaveChangesAsync();
    }
}
