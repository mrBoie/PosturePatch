using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostureRepo.Repository_and_BO.dbContext;
using PostureRepo.Repository_and_BO.Exercise;

namespace PostureRepo
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
    }
}
