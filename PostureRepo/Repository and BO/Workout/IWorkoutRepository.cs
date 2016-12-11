using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo.Repository.Interfaces
{
    interface IWorkoutRepository
    {
        IEnumerable<WorkoutBO> GetAllWorkouts();
        IEnumerable<WorkoutBO> GetAllWorkoutsByClient(ClientBO client);
        WorkoutBO GetWorkoutByID(int id);
        bool CreateWorkout(WorkoutBO workout);
        bool DeleteWorkout(WorkoutBO workout);
        bool UpdateWorkout(WorkoutBO workout);
    }
}
