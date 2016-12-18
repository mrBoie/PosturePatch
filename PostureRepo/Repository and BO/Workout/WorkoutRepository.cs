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

        public IEnumerable<WorkoutBO> GetAllWorkoutsByClientID(int clientid)
        {
            using (var db = new DatabaseContextContainer())
            {
                return db.WorkoutSet.Where(o => o.ClientId == clientid).Select(w => w.toBO()).ToList();
            }
        }

        public WorkoutBO GetWorkoutByID(int id)
        {
            using (var db = new DatabaseContextContainer())
            {
                return db.WorkoutSet.FirstOrDefault(o => o.Id == id).toBO();
            }
        }

        public bool UpdateWorkout(int id, WorkoutBO workout)
        {
            using (var db = new DatabaseContextContainer())
            {
                var WorkoutEntity = db.WorkoutSet.FirstOrDefault(o => o.Id == id);
                if (WorkoutEntity == null)
                    return false;

                if (workout.Name != null)
                    WorkoutEntity.Name = workout.Name;
                if (workout.Description != null)
                    WorkoutEntity.Description = workout.Description;
                if (workout.ClientID != 0)
                    WorkoutEntity.ClientId = workout.ClientID;
                if (workout.DateCreated != null)
                    WorkoutEntity.DateCreated = workout.DateCreated;

                db.SaveChanges();
                return true;
            }
        }
    }
}
