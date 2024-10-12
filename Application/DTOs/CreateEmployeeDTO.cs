using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CreateEmployeeDTO
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int PositionId { get; set; }
    }
}
