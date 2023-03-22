using User_UAuthentication.Models;

namespace User_UAuthentication.DataAccess
{
    public interface IUser
    {
        List<User> GetAllUsers();

        User GetUserById(int id);
    }
}
