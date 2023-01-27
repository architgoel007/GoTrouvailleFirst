using GoTrouvailleFirst.DL.DTO;
using GoTrouvailleFirst.DL.InterfaceDL;
using GoTrouvailleFirst.DL.Model;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace GoTrouvailleFirst.DL
{
    public class DLUserService : IDLUserService
    {
        private readonly GoTrouvailleContext _context;

        public DLUserService()
        {
            _context = new GoTrouvailleContext();
        }
        public string AddUser(User user)
        {
            user.Id= Guid.NewGuid();
            _context.Users.Add(user);
            _context.SaveChanges();
            return "User Created Successfully!";
        }

        public string DeleteUser(Guid id)
        {
            User? user = _context.Users.Where(u => u.Id == id).FirstOrDefault();
            _context.Users.Remove(user);
            _context.SaveChanges();
            return "User Deleted Successfully!";
        }

        public List<Country> GetCountries()
        {
            return _context.Countries.ToList();
        }

        public List<StateDto> GetStates()
        {
            return _context.States.Include(x=>x.IdNavigation).Select(m=> new StateDto()
            {
                Id= m.Id,
                CountryId= m.CountryId,
                CountryName = m.IdNavigation.CountryName,
                StateName = m.StateName
            }).ToList();
        }

        public List<User>? GetUsers()
        {
            return _context.Users.ToList();
        }

        public string UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return "User Updated Successfully!";
        }

        public User? UserGetById(Guid id)
        {
            return _context.Users.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
