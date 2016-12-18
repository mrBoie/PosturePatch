using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo.Repository_and_BO
{
    public class WorkoutBO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public int ClientID { get; set; }
        public List<ClientBO> Clients { get; set; }
        public List<ExerciseBO> Excercises{ get; set; }
    }
}
