using PostureRepo.Repository_and_BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo.Services
{
    class WorkoutService
    {
        IExerciseRepository _exerciseRepo;
        IExerciseTemplateRepository _exerciseTemplateRepo;

        public WorkoutService(IExerciseRepository exerciseRepo, IExerciseTemplateRepository exerciseTemplateRepo)
        {
            _exerciseRepo = exerciseRepo;
            _exerciseTemplateRepo = exerciseTemplateRepo;
        }
    }
}
