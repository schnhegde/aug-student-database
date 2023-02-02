using Microsoft.AspNetCore.Mvc;

namespace StudentDatabase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetAllStudents : ControllerBase
    {
        private readonly ILogger<GetAllStudents> _logger;
        private StudentDbContext _dbContext;

        public GetAllStudents(StudentDbContext dbContext, ILogger<GetAllStudents> logger)
        {
            _logger = logger;
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IList<Student> Get()
        {
            return _dbContext.Set<Student>().ToList<Student>();
        }
    }
}