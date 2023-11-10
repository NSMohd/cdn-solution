using CDNsolutionWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CDNsolutionWebAPI.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
    public class UserController : ControllerBase
    {
        public static List<User> users = new List<User>()
        {
            new User() {UserID = 1, UserName = "Lalisa", Email = "lalisa@gmail.com", Hobby = "badminton", PhoneNumber = "011", Skillsets = "active"},
            new User() {UserID = 2, UserName = "Jennie", Email = "jennie@gmail.com", Hobby = "badminton", PhoneNumber = "012", Skillsets = "active"},
            new User() {UserID = 3,UserName = "Rose", Email = "rose@gmail.com", Hobby = "badminton", PhoneNumber = "013", Skillsets = "active"}
        };

        [HttpGet]
        public List<User> GetUsers()
        {
            return users;
        }

        [HttpPost]
        public void PostUser()
        {
            users.Add(new User() { UserID = 4, UserName = "Jisoo", Email = "jisoo@gmail.com", Hobby = "badminton", PhoneNumber = "014", Skillsets = "active" });
        }

    }
}
