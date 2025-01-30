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
    }
}
