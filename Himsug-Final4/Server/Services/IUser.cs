using Himsug_Final4.Shared.Models;

namespace Himsug_Final4.Server.Services
{
    public interface IUser
    {
        public List<Accounts> GetUserDetails();
        public void AddUser(Accounts user); 

        public void UpdateUser(Accounts user);

        public void DeleteUser(int id);

        public Accounts GetUserData(int id);
    }
}
