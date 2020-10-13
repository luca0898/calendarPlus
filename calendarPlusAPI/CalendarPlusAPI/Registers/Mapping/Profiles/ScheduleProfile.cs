using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalendarPlus.PRODUCT.Entities;
using CalendarPlus.PRODUCT.ViewModel;

namespace CalendarPlus.Registers.Mapping
{
    public class ScheduleProfile : Profile
    {
        public ScheduleProfile()
        {
            CreateMap<Schedule, ScheduleViewModel>().ReverseMap();
        }
    }
}
