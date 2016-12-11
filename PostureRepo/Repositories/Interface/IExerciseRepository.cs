using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo.Repository.Interfaces
{
    interface IExerciseRepository
    {
        IEnumerable<ExerciseBO> getAllExercises();
        IEnumerable<ExerciseBO> getAllExercisesOnWorkout(WorkoutBO workout);
        ExerciseBO getExerciseByID(int id);
        bool CreateExercise(ExerciseBO exercise);
        bool UpdateExercise(int id, ExerciseBO exercise);
        bool DeleteExerciseByID(int id);
        bool DeleteExercise(ExerciseBO exercise);
    }
}
