using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalendarPlus.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        public IActionResult Get()
        {
            return Ok("working");
        }
    }
}