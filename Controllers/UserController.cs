using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Identity;
using ReactTrainingArcAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace ReactTrainingArcAPI.Controllers
{
    
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
    public async Task<ActionResult<List<User>>> GetUsers() 
    {
        return Ok(await _context.Users.ToListAsync());
    } 
}

}
