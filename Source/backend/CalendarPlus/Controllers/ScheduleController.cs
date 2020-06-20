using CalendarPlus.PRODUCT.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarPlus.Controllers
{
    [Route("v1/schedule")]
    public class ScheduleController : ControllerBase
    {
        public ScheduleController()
        {

        }

        /// <summary>
        /// Get All Schedules
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("")]
        public IActionResult Get()
        {
            var schedule = new Schedule
            {
                Id = "some_id",
                Deleted = false,

                CreatedAt = DateTimeOffset.Now,
                UpdateAt = DateTimeOffset.Now,
                CreatedBy = "Admin",
                UpdateBy = "Admin",

                StartProcedure = DateTimeOffset.Now,
                EndProcedure = DateTimeOffset.Now,

                Type = PRODUCT.Enums.ProcedureTypes.LYMPHATIC_DRAINAGE
            };

            return Ok(schedule);
        }
    }
}
