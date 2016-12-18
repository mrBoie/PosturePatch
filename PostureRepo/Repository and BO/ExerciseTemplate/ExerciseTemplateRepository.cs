using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostureRepo.Repository_and_BO.dbContext;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;
using PostureRepo;

namespace PostureRepo.Repository_and_BO
{
    public class ExerciseTemplateRepository : IExerciseTemplateRepository
    {
        public ExerciseTemplateBO CreateExerciseTemplate(ExerciseTemplateBO exercise)
        {
            using (var db = new DatabaseContextContainer())
            {
                var exTemplate = new ExerciseTemplate
                {
                    Name = exercise.Name,
                    DefaultSets = exercise.DefaultSets,
                    DefaultReps = exercise.DefaultReps,
                    Description = exercise.Description,
                };
                var returnExerciseEntity = db.ExerciseTemplateSet.Add(exTemplate);
                db.SaveChanges();
                return returnExerciseEntity.toBO();
            }
            
        }

        public bool DeleteExerciseTemplate(ExerciseTemplateBO exercise)
        {
            using (var db = new DatabaseContextContainer())
            {
                var etToRemove = db.ExerciseTemplateSet.FirstOrDefault(et => et.Id == exercise.ID);
                if(etToRemove == null)
                    return false;

                db.ExerciseTemplateSet.Remove(etToRemove);
                db.SaveChanges();
                return true;
            }
        }

        public bool DeleteExerciseTemplateByID(int id)
        {
            using (var db = new DatabaseContextContainer())
            {
                var etToRemove = db.ExerciseTemplateSet.FirstOrDefault(et => et.Id == id);
                if (etToRemove == null)
                    return false;

                db.ExerciseTemplateSet.Remove(etToRemove);
                db.SaveChanges();
                return true;
            }
        }

        public IEnumerable<ExerciseTemplateBO> getAllExercisesTemplates()
        {
            using (var db = new DatabaseContextContainer())
            {
                var ExerciseTemplateBOs = db.ExerciseTemplateSet.ToList().Select(o => o.toBO()).ToList();
                return ExerciseTemplateBOs;
            }
        }

        public ExerciseTemplateBO getExerciseTemplateByID(int id)
        {
            using (var db = new DatabaseContextContainer())
            {
                var exerciseBO = db.ExerciseTemplateSet.FirstOrDefault(o => o.Id == id).toBO();
                return exerciseBO;
            }
        }

        public ExerciseTemplateBO UpdateExerciseTemplate(int id, ExerciseTemplateBO exercise)
        {
            using (var db = new DatabaseContextContainer())
            {
                var ExerciseTemplate = db.ExerciseTemplateSet.FirstOrDefault(o => o.Id == id);
                if (ExerciseTemplate == null)
                    return null;

                if (exercise.Name != null)
                    ExerciseTemplate.Name = exercise.Name;

                if (exercise.Description != null)
                    ExerciseTemplate.Description = exercise.Description;

                if (exercise.DefaultSets != 0)
                    ExerciseTemplate.DefaultSets = exercise.DefaultSets;

                if (exercise.DefaultSets != 0)
                    ExerciseTemplate.DefaultReps = exercise.DefaultReps;

                db.SaveChanges();
                return ExerciseTemplate.toBO();
            }
        }
    }
}
