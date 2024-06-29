using AuthenticationService.DAL;
using AutoMapper;

namespace AuthenticationService.PLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>()
                .ConstructUsing(v => new UserViewModel(v));
        }
    }
}
