﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class AssignTaskDTO
    {
        public int Id { get; set; }
        public List<int>? ToDoTasks { get; set; }
    }
}
