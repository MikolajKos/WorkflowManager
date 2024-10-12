using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<CreateEmployeeDTO, Employee>();
        }
    }
}
