using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo.Repository_and_BO
{
    public interface IExerciseTemplateRepository
    {
        IEnumerable<ExerciseTemplateBO> getAllExercisesTemplates();
        ExerciseTemplateBO getExerciseTemplateByID(int id);
        ExerciseTemplateBO CreateExerciseTemplate(ExerciseTemplateBO exercise);
        ExerciseTemplateBO UpdateExerciseTemplate(int id, ExerciseTemplateBO exercise);
        bool DeleteExerciseTemplateByID(int id);
        bool DeleteExerciseTemplate(ExerciseTemplateBO exercise);
    }
}
