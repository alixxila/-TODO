using ApplicationWebAPI.Models;
using ApplicationWebAPI.Services;
using ApplicationWebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationWebAPI.Controllers
{
    public class UserController : Controller
    {

        //private UserService _userService = new UserService();

        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetUserById/{id}")]
        public User GetUserById(int id)
        {
           return _userService.GetUserById(id);
        }

        [HttpGet("GetAllUser")]
        public List<User> GetAllUser()
        {
            return _userService.GetAllUsers();
        }


        //Creation de l'utilisateur
        [HttpPost("CreateUser")]
        public User CreateUser(User user)
        {
            return _userService.CreateUser(user);
        }

        //Edit de l'utilisateur
        [HttpPut("EditUser")]
        public User EditUser(int id, User user)
        {
            throw new NotImplementedException();    
        }

        //Supression de l'utilisateur
        [HttpDelete("DeleteUser")]
        public User DeleteUser(User user)
        {
            return _userService.DeleteUser(user);
        }

        /*
        [HttpPut("UpdateUser")]
        public User UpdateUser(int userId, User user)
        {
         
        }

        */

    }
}
