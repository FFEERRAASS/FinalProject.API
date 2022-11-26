using FinalProject.Core.Data;
using FinalProject.Core.Service;
using Microsoft.AspNetCore.Http;
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
        [HttpGet("GetAllUsers")] //fuck feras nn
        public List<User> GetAllUsers()
        {
            return userService.GetAllUsers();
        }
        [HttpPost]
        [Route("Create")] // i love feras
        public void CreateUser(User user)
        {
            userService.CreateUser(user);
        }


    }
}
