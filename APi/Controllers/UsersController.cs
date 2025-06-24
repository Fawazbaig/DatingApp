using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APi.Data;
using APi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UsersController(DataContext context) : ControllerBase
    {
        private readonly DataContext _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUSer>>> GetUsers()
        {
            var users =await  context.Users.ToListAsync();
            return users;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<AppUSer>> GetUser(int id)
        {
            var user =await context.Users.FindAsync(id);
            
            if (user == null) return NotFound();
            
            return user;
        }
    }
}