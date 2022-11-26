using FinalProject.Core.Data;
using FinalProject.Core.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;
        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet("GetAllUsers")]

        [HttpGet("GetAllUsers")] 
        public List<User> GetAllUsers()
        {
            return userService.GetAllUsers();
        }
        [HttpPost]
        [Route("CreateUser")]
        public void CreateUser(User user)
        {
            userService.CreateUser(user);
        }
        [HttpPut("UpdateUser")]
        public void UpdateUser(User user)
        {
            userService.UpdateUser(user);
        }
        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public void DeleteUser(int id)
        {
            userService.DeleteUser(id);
        }
        [HttpGet]
        [Route("GetUserById/{id}")]
        public User UserGetUserById(int id)
        {
            return userService.UserGetUserById(id);
        }



    }
}
