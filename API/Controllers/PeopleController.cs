using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class PeopleController : BaseApiController
    {
        private readonly DataContext _context;

        public PeopleController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetPeople()
        {
            return await _context.People.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPerson(Guid id)
        {
            return await _context.People.FindAsync(id);
        }
    }
}