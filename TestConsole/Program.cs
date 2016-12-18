using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostureRepo.Repository_and_BO;
using PostureRepo;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IExerciseTemplateRepository ex = new ExerciseTemplateRepository();
            var exerciseTemplate = new ExerciseTemplateBO
            {
                Name = "Biceps Curls",
                Description = "Abba",
                DefaultReps = 2,
                DefaultSets = 3
            };
            var exOUT = ex.CreateExerciseTemplate(exerciseTemplate);

            //ex.DeleteExerciseTemplate(exOUT);

            var a = ex.getAllExercisesTemplates();

            var b = ex.getExerciseTemplateByID(9);
            b.Description = "Bytt e Bytt";

            ex.UpdateExerciseTemplate(9, b);


            IExerciseRepository exRepo = new ExerciseRepository();
            var exercise = new ExerciseBO
            {
                Name = "APA",
                Description = "NASDA",
                Sets = 2,
                Reps = 2,
                TemplateID = exOUT.ID
            };
            exRepo.CreateExercise(exercise);
        }
    }
}
