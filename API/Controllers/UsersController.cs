using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // [controller is a placeholder that will be switched with the name of the database users]
    public class UsersController : ControllerBase

    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
            
        }
        
        // api/users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            
            return await _context.Users.ToListAsync();
            
        }

        // api/users/3
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUsers(int id)
        {
            
            return await _context.Users.FindAsync(id);

        }
    }
}