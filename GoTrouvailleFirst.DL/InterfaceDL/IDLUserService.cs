using GoTrouvailleFirst.DL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTrouvailleFirst.DL.InterfaceDL
{
    public interface IDLUserService
    {
        string AddUser(User user);
        string UpdateUser(User user);
        User? UserGetById(Guid id);
        List<User>? GetUsers();
        string DeleteUser(Guid id);
        List<Country> GetCountries();
        List<State> GetStates();
    }
}
