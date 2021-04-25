using AutoMapper;
using CalendarPlus.Product.Entities;
using CalendarPlus.Product.ViewModel;

namespace CalendarPlus.API.Registers.Mapping.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
        }
    }
}
