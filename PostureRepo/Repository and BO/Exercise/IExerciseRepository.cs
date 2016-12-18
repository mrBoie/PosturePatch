using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo.Repository_and_BO
{
    public interface IExerciseRepository
    {
        IEnumerable<ExerciseBO> getAllExercises();
        IEnumerable<ExerciseBO> getAllExercisesByWorkout(int id);
        IEnumerable<ExerciseBO> getAllExercisesByExerciseTemplateID(int id);
        ExerciseBO getExerciseByID(int id);
        ExerciseBO CreateExercise(ExerciseBO exercise);
        ExerciseBO UpdateExercise(int id, ExerciseBO exercise);
        bool DeleteExerciseByID(int id);
        bool DeleteExercise(ExerciseBO exercise);
    }
}
