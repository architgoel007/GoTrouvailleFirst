using AutoMapper;
using GoTrouvailleFirst.BL.InterfaceBL;
using GoTrouvailleFirst.DL.InterfaceDL;
using GoTrouvailleFirst.DL.Model;
using GoTrouvailleFirst.Shared.DTO;

namespace GoTrouvailleFirst.BL.ServiceBL
{
    public class BLUserService : IBLUserService
    {
        private readonly IDLUserService _dLUserService;
        private readonly IMapper _mapper;

        public BLUserService(IDLUserService dLUserService, IMapper mapper)
        {
            _dLUserService = dLUserService;
            _mapper = mapper;
        }

        public string AddUser(UserDto userDto)
        {
            return _dLUserService.AddUser(_mapper.Map<User>(userDto));
        }

        public string DeleteUser(Guid id)
        {
            return _dLUserService.DeleteUser(id);
        }

        public List<CountryDto>? GetCountries()
        {
            return _dLUserService.GetCountries().Select(obj => _mapper.Map<CountryDto>(obj)).ToList();
        }

        public List<StateDto>? GetStates()
        {
            return _dLUserService.GetStates().Select(obj => _mapper.Map<StateDto>(obj)).ToList();
        }

        public List<UserDto>? GetUsers()
        {
            return _dLUserService.GetUsers()?.Select(obj => _mapper.Map<UserDto>(obj)).ToList();
        }

        public string UpdateUser(UserDto userDto)
        {
            return _dLUserService.UpdateUser(_mapper.Map<User>(userDto));
        }

        public UserDto? UserGetById(Guid id)
        {
            return _mapper.Map<UserDto>(_dLUserService.UserGetById(id));
        }
    }
}
