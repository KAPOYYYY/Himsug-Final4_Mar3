using Himsug_Final4.Shared;
using Himsug_Final4.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Himsug_Final4.Server.Services
{
    public class UserManager : IUser
    {
        readonly SQLDBContext _dbcontext = new();

        public UserManager(SQLDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        //List users
        public List<Accounts> GetUserDetails()
        {
            try
            {
                return _dbcontext.tbl_Login.ToList();
            }

            catch
            {
                throw;
            }
        }
        //add new user
        public void AddUser(Accounts user)
        {
            try
            {
                _dbcontext.tbl_Login.Add(user);
                _dbcontext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //update user
        public void UpdateUser(Accounts user) 
        {
            try
            {
                _dbcontext.Entry(user).State = EntityState.Modified;
                _dbcontext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //get detailsID
        public Accounts GetUserData(int id)
        {
            try
            {
                Accounts? user = _dbcontext.tbl_Login.Find(id);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        //delete user
        public  void DeleteUser(int id)
        {
            try
            {
                Accounts? user = _dbcontext.tbl_Login.Find(id);
                if (user != null)
                {
                    _dbcontext.tbl_Login.Remove(user);
                    _dbcontext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}














