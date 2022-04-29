using ApplicationWebAPI.Data;
using ApplicationWebAPI.Models;
using ApplicationWebAPI.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationWebAPI.Services
{
    public class UserService : IUserService
    {
        private CurrentContext _currentContext;

        public UserService(CurrentContext currentContext)
        {
            _currentContext = currentContext;
        }

        //Création de l'utilisateur dans la BDD 
        public User CreateUser(User user)
        {
            _currentContext.Users.Add(user);
            _currentContext.SaveChanges();
            return user;
        }

        //Liste les utilisateurs
        public List<User> GetAllUsers()
        {
            return _currentContext.Users.ToList();
                        
        }

        //Supprime un utilisateur
        /*
        public User DeleteUser(User user)
        {
            _currentContext.Remove(user);
            _currentContext.SaveChanges();
            return user;
        }
        */

        public bool DeleteUser(int id)
        {
            User user = _currentContext.Users.FirstOrDefault(user => user.Id == id);
            _currentContext.Users.Remove(user);
            _currentContext.SaveChanges();
            return true;
        }
        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(User user)
        {
            throw new NotImplementedException();
        }

        /*
        //Chercher un utilisateur avec son ID
        public User GetUserById(int id)
        {
            return _currentContext.Users.FirstOrDefault(user => user.Id == id);
        }
        */
        
        //Mettre a jour un utilisateur
        public User UpdateUser(int userId, User user)
        {
            _currentContext.Update(userId, user);
            return user;
        }
    }
}
