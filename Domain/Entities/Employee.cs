using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee
    {
        public required int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public List<Specialisation>? Specialisations { get; set; }
        public List<ToDoTask>? ToDoTasks { get; set; }
        public int PosiotionId { get; set; }
        public Posiotion? Position { get; set; }
    }
}
