using AutoMapper;
using GoTrouvailleFirst.DL.Model;
using GoTrouvailleFirst.Shared.DTO;

namespace GoTrouvailleFirst.BL
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
