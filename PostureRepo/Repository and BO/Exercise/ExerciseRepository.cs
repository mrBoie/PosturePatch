using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostureRepo.Repository_and_BO.dbContext;

namespace PostureRepo.Repository_and_BO
{
    public class ExerciseRepository : IExerciseRepository
    {
        public ExerciseBO CreateExercise(ExerciseBO exercise)
        {
            var exTempRepo = new ExerciseTemplateRepository();
            using (var db = new DatabaseContextContainer())
            {
                var exerciseEntity = db.ExerciseSet.Add(new dbContext.Exercise()
                {
                    Name = exercise.Name,
                    Description = exercise.Description,
                    Sets = exercise.Sets,
                    Reps = exercise.Reps,
                    ExerciseTemplateId = exercise.TemplateID
                });

                db.SaveChanges();
                if( exerciseEntity == null)
                    return null;

                return exerciseEntity.toBO();
            }
        }

        public bool DeleteExercise(ExerciseBO exercise)
        {
            return DeleteExerciseByID(exercise.ID);
        }

        public bool DeleteExerciseByID(int id)
        {
            using (var db = new DatabaseContextContainer())
            {
                var ExerciseEntity = db.ExerciseSet.FirstOrDefault(o => o.Id == id);
                if (ExerciseEntity == null)
                    return false;

                db.ExerciseSet.Remove(ExerciseEntity);
                db.SaveChanges();
                return true;
            }
        }

        public IEnumerable<ExerciseBO> getAllExercises()
        {
            using (var db = new DatabaseContextContainer())
            {
                return db.ExerciseSet.Where(o => true).Select(o => o.toBO()).ToList();
            }
        }

        public IEnumerable<ExerciseBO> getAllExercisesByWorkout(int id)
        {
            using (var db = new DatabaseContextContainer())
            {
                return db.ExerciseSet.Where(o => o.WorkoutId == id).Select(o => o.toBO()).ToList();
            }
        }

        public ExerciseBO getExerciseByID(int id)
        {
            using (var db = new DatabaseContextContainer())
            {
                return db.ExerciseSet.FirstOrDefault(o => o.Id == id).toBO();
            }
        }

        public IEnumerable<ExerciseBO> getAllExercisesByExerciseTemplateID(int id)
        {
            using (var db = new DatabaseContextContainer())
            {
                return db.ExerciseSet.Where(o => o.ExerciseTemplateId == id).Select(o => o.toBO()).ToList();
            }
        }

        public ExerciseBO UpdateExercise(int id, ExerciseBO exercise)
        {
            using (var db = new DatabaseContextContainer())
            {
                var exerciseEntity = db.ExerciseSet.FirstOrDefault(o => o.Id == id);

                if (exercise.Name != null)
                    exerciseEntity.Name = exercise.Name;
                if (exercise.Description != null)
                    exerciseEntity.Description = exercise.Description;
                if (exercise.Reps != 0)
                    exerciseEntity.Reps = exercise.Reps;
                if (exercise.Sets != 0)
                    exerciseEntity.Sets = exercise.Sets;
                if (exercise.TemplateID != 0)
                    exerciseEntity.ExerciseTemplateId = exercise.TemplateID;
                if (exercise.WorkoutID != 0)
                    exerciseEntity.WorkoutId = exercise.WorkoutID;
                if (exercise.Order != 0)
                    exerciseEntity.Order = exercise.Order;

                db.SaveChanges();

                return exerciseEntity.toBO();
            }
        }
    }
}
