using GoTrouvailleFirst.DL.Model;
using GoTrouvailleFirst.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTrouvailleFirst.BL.InterfaceBL
{
    public interface IBLUserService
    {
        string DeleteUser(Guid id);
        string AddUser(UserDto userDto);
        string UpdateUser(UserDto userDto);
        UserDto? UserGetById(Guid id);
        List<UserDto>? GetUsers();
        List<CountryDto>? GetCountries();
        List<StateDto>? GetStates();
    }
}
