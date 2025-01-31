using ExercisesRESTAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace ExercisesRESTAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExercisesController : ControllerBase
    {
        private readonly DataContext _context;
        public ExercisesController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetExercises() 
        {
            return Ok(_context.ExerciseList);
        }
        [HttpGet("{id}")]
        public IActionResult GetDetails(int? id)
        {
            var exercise = _context.ExerciseList?.FirstOrDefault(e => e.Id == id);
            if (exercise == null) 
            {
                return NotFound();
            }
            return Ok(exercise);
        }
        [HttpPost]
        public IActionResult Create([FromBody] Exercise exercise)
        {
            var dbExercise = _context.ExerciseList?.Find(exercise.Id);
            if (dbExercise == null)
            {
                _context.Add(exercise);
                _context.SaveChanges();
                
                return CreatedAtAction(nameof(GetDetails),new { Id = exercise.Id}, exercise);
            }
            else 
            {
                return Conflict();
            }
        }
    }
}
