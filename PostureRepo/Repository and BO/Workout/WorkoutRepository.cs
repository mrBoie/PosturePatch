using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostureRepo.Repository_and_BO.dbContext;

namespace PostureRepo.Repository_and_BO
{
    public class WorkoutRepository : IWorkoutRepository
    {
        public WorkoutBO CreateWorkout(WorkoutBO workout)
        {
            using (var db = new DatabaseContextContainer())
            {
                var workoutEntity = new Workout()
                {
                    Name = workout.Name,
                    Description = workout.Description,
                    DateCreated = workout.DateCreated,
                };
                workoutEntity = db.WorkoutSet.Add(workoutEntity);

                db.SaveChanges();
                return workoutEntity.toBO();
            }
        }

        public bool DeleteWorkout(WorkoutBO workout)
        {
            using (var db = new DatabaseContextContainer())
            {
                var workoutEntity = db.WorkoutSet.FirstOrDefault(o => o.Id == workout.ID);
                if(workoutEntity == null)               
                    return false;

                db.WorkoutSet.Remove(workoutEntity);
                db.SaveChanges();

                return true;
            }
        }

        public IEnumerable<WorkoutBO> GetAllWorkouts()
        {
            using (var db = new DatabaseContextContainer())
            {
                return db.WorkoutSet.Where(o => true).Select(w => w.toBO()).ToList();
            }
        }

        public IEnumerable<WorkoutBO> GetAllWorkoutsByClient(ClientBO client)
        {
            using (var db = new DatabaseContextContainer())
            {
                return db.WorkoutSet.Where(o => o. == client.ID).Select(w => w.toBO()).ToList();
            }
        }

        public WorkoutBO GetWorkoutByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateWorkout(WorkoutBO workout)
        {
            throw new NotImplementedException();
        }
    }
}
