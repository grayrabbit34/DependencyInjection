using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DependenciesController : ControllerBase
    {
        private readonly ITeacher _teacher;

        public DependenciesController(ITeacher teacher)
        {
            _teacher = teacher;
        }

        [HttpGet("teacher")]
        public IActionResult GetTeacher()
        {
            var classRoom = new ClassRoom(_teacher);
            return Ok(classRoom.GetTeacherInfo());
        }
    }
}
