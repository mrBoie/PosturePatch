using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostureRepo.Repository_and_BO.Exercise;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IExerciseTemplateRepository ex = new ExerciseTemplateRepository();
            var exercise = new ExerciseTemplateBO
            {
                Name = "Biceps Curls",
                Description = "Abba",
                DefaultReps = 2,
                DefaultSets = 3
            };
            var exOUT = ex.CreateExerciseTemplate(exercise);

            ex.DeleteExerciseTemplate(exOUT);

            var a = ex.getAllExercisesTemplates();

            var b = ex.getExerciseTemplateByID(2);
            b.Description = "Bytt e Bytt";

            ex.UpdateExerciseTemplate(2, b);
        }
    }
}
