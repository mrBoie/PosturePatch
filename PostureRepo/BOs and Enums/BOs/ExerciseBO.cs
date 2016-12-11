﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo
{
    public class ExerciseBO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<object> Pictures { get; set; }
        public int DefaultSets { get; set; }
        public int DefaultReps { get; set; }
    }
}
