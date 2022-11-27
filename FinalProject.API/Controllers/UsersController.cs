using FinalProject.Core.Data;
using FinalProject.Core.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;
        public UsersController(IUserService userService)////////
        {
            this.userService = userService;
        }
        [HttpGet("GetAllUsers")]

        public List<User> GetAllUsers()
        {
            return userService.GetAllUsers();
        }
        [HttpPost]
        [Route("CreateUser")] ///////aaa
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

        [Route("UploadImages")]
        [HttpPost]
        public User UploadImage()
        {
            var file = Request.Form.Files[0];
            var filename = Guid.NewGuid().ToString() + "_"+file.FileName;
            var fullpath = Path.Combine("Images", filename);
            using(var stream =new FileStream(fullpath , FileMode.Create))
            {
                file.CopyTo(stream);
            }
            User item = new User();
            item.Imagepath= filename;
            return item;
        }

    }
}
