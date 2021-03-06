﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo.Repository_and_BO
{
    public class ClientBO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Enums.Gender Gender { get; set; }
        public string Description { get; set; }
        public List<WorkoutBO> Workouts { get; set; }
    }
}
