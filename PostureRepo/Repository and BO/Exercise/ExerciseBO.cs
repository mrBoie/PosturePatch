using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo.Repository_and_BO
{
    public class ExerciseBO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short Sets { get; set; }
        public short Reps { get; set; }
        public int TemplateID { get; set; }
        public int WorkoutID { get; set; }
        public short SortOrder { get; set; }
    }
}
