using AutoMapper;
using CalendarPlus.Controllers.Shared;
using CalendarPlus.Product.Contracts.Services;
using CalendarPlus.Product.Entities;
using CalendarPlus.Product.ViewModel;
using CalendarPlus.SystemObjects.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace CalendarPlus.Controllers
{
    [Route("v1/schedule"), BearerAuthorize("Authenticated")]
    public class ScheduleController : BaseController<Schedule, ScheduleViewModel, ScheduleViewModel>
    {
        public ScheduleController(
            IScheduleService scheduleService, 
            IMapper mapper)
            : base(scheduleService, mapper)
        {
        }
    }
}
