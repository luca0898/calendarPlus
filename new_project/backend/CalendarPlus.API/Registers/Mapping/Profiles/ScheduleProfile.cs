using AutoMapper;
using CalendarPlus.Product.Entities;
using CalendarPlus.Product.ViewModel;

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
