using User_UAuthentication.DataAccess;
using User_UAuthentication.Models;

namespace User_UAuthentication.Repository
{
    public class UserRepo : IUser
    {
        private readonly UserUAuthContext _context;

        public UserRepo(UserUAuthContext context)
        {
            _context = context;
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }
    }
}
