using Microsoft.EntityFrameworkCore;

namespace ExercisesRESTAPI.Model
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 
        }
        public DbSet<Exercise>? ExerciseList { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Exercise>().HasData(
                new Exercise
                {
                    Id = 1,
                    Title = "Kätekõverdused jala tõstetega",
                    Description = "Tavalise kätekõverdused korda mööda jalga tõstes",
                    Intentsity = Exercise.ExerciseIntentsity.Normal,
                    RecommendedDuratinoInSeconds = 40,
                    RecommendedTimeInSecondsBeforeExercise = 10,
                    RecommendedTimeInSecondsAfterExercise = 10
                },
                new Exercise
                {
                    Id = 2,
                    Title = "Slaalomhüpped",
                    Description = "Kükist hüpped küljelt küljele",
                    Intentsity = Exercise.ExerciseIntentsity.High,
                    RecommendedDuratinoInSeconds = 40,
                    RecommendedTimeInSecondsBeforeExercise = 10,
                    RecommendedTimeInSecondsAfterExercise = 10,
                    RestTimeInstructions = "Venita reie esikülge"
                },
                new Exercise
                {
                    Id = 3,
                    Title = "Alt läbi jooks",
                    Description = "Toenglamangus jooksmine",
                    Intentsity = Exercise.ExerciseIntentsity.Normal,
                    RecommendedDuratinoInSeconds = 40,
                    RecommendedTimeInSecondsBeforeExercise = 10,
                    RecommendedTimeInSecondsAfterExercise = 10
                });
        }
    }
}
