using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Identity;

namespace ReactTrainingArcAPI.Controllers
{
    
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<User>>> GetUsers() 
    {
        return new List<User> 
        {
                new User
               {
                   UID=1,
                   Username= "admin",
                   Password = "admin"
                }
        };
    } 
}

}
