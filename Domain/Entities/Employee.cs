using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        //Many to many relationship
        public List<Specialisation>? Specialisations { get; set; }
        //Many to many relationship
        public List<ToDoTask>? ToDoTasks { get; set; }
        //One to many relationship
        public int PositionId { get; set; }
        public Position? Position { get; set; }
    }
}
