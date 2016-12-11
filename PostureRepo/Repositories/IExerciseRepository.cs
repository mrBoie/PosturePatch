using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo.Repositories
{
    interface IExerciseRepository
    {
        IEnumerable<ExerciseBO> getAllExercises();
        IEnumerable<ExerciseBO> getAllExercisesOnWorkout(WorkoutBO workout);
        bool CreateExercise(ExerciseBO exercise);
        bool UpdateExercise(int id, ExerciseBO exercise);
        ExerciseBO getExercise(int id);
        bool DeleteExerciseByID(int id);
        bool DeleteExercise(ExerciseBO exercise);
    }
}
