using Day1_api;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CourseController : ControllerBase
{
    private static List<Course> courses = new List<Course>
    {
        new Course { Id = 1, Name = "Math", Duration = 30, Status = "Active" },
        new Course { Id = 2, Name = "Science", Duration = 45, Status = "Inactive" },
        new Course { Id = 3, Name = "History", Duration = 20, Status = "Active" }
    };

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(courses);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var course = courses.FirstOrDefault(c => c.Id == id);
        if (course == null) return NotFound();
        return Ok(course);
    }
}
