using System.Text.Json.Serialization;

namespace ExercisesRESTAPI.Model
{
    public class Exercise
    {
        public int Id { get; init; }
        public string? Title { get; init; }
        public string? Description { get; init; }
        public ExerciseIntentsity Intentsity { get; init;}
        public int RecommendedDurationInSeconds { get; init;}
        public int RecommendedTimeInSecondsBeforeExercise { get; init;}
        public int RecommendedTimeInSecondsAfterExercise { get; init;}
        public string? RestTimeInstructions { get; init;}
        public int RecommendedDuratinoInSeconds { get; internal set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum ExerciseIntentsity
        {
            Low = 1, Normal = 2, High =3 
        }
    }
}
