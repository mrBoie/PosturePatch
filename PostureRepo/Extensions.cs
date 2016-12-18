using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostureRepo.Repository_and_BO.dbContext;

namespace PostureRepo.Repository_and_BO
{
    public static class Extensions
    {
        public static ExerciseTemplateBO toBO(this ExerciseTemplate entity)
        {
            return new ExerciseTemplateBO()
            {
                ID = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                DefaultReps = entity.DefaultReps,
                DefaultSets = entity.DefaultSets
            };
        }

        public static ExerciseBO toBO(this Exercise entity)
        {
            return new ExerciseBO
            {
                ID = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Reps = entity.Reps,
                Sets = entity.Sets,
                TemplateID = entity.ExerciseTemplateId,
                WorkoutID = entity.WorkoutId
            };
        }

        public static WorkoutBO toBO(this Workout entity)
        {
            return new WorkoutBO
            {
                ID = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                DateCreated = entity.DateCreated
            };
        }
    }
}
