using PostureRepo.Repository_and_BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo.Services
{
    public interface IWorkoutService
    {
        WorkoutBO createWorkout();
        WorkoutBO addNewExerciseFromTemplateExercise();
        WorkoutBO updateExerciseInWorkout();
        bool deleteWorkout(WorkoutBO workout);
    }
}
