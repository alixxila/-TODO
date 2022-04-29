using ApplicationWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationWebAPI.Services.Interfaces
{
    public interface IUserService
    {
        public User CreateUser(User user);

        public User DeleteUser(User user);
        
        /*
        public bool DeleteUser(int id);
        */

        public List<User> GetAllUsers();

        public User GetUserById(int id);    

        public User GetUser(User user);

        /*
        public User UpdateUser(int userId, User user);
        */
    }
}
