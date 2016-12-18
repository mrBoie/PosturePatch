using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo.Repository_and_BO
{
    public class ExerciseTemplateBO
    {
       public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<object> Pictures { get; set; }
        public short DefaultSets { get; set; }
        public short DefaultReps { get; set; }
    }
}
