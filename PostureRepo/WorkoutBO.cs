using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo
{
    class WorkoutBO
    {
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public List<ExerciseBO> Excercises{ get; set; }
    }
}
