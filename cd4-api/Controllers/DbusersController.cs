using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cd4_api.Models;
using Microsoft.AspNetCore.Authorization;
using cd4_api.ViewModels.Client.User;
using cd4_api.Services.Client.Users;

namespace cd4_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbusersController : ControllerBase
    {
        private readonly IUserService _context;

        public DbusersController(IUserService context)
        {
            _context = context;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginViewModel user)
        {
            var us = await _context.Login(user);
            return Ok(us);
        }

        // POST api/<UsersController>
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterViewModel user)
        {
            var res = await _context.Register(user);
            if (res == 0)
                return BadRequest();
            return Ok(res);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        //// GET: api/Dbusers
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Dbuser>>> GetDbuser()
        //{
        //    return await _context.Dbuser.ToListAsync();
        //}

        //// GET: api/Dbusers/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Dbuser>> GetDbuser(string id)
        //{
        //    var dbuser = await _context.Dbuser.FindAsync(id);

        //    if (dbuser == null)
        //    {
        //        return NotFound();
        //    }

        //    return dbuser;
        //}

        //// PUT: api/Dbusers/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutDbuser(string id, Dbuser dbuser)
        //{
        //    if (id != dbuser.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(dbuser).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!DbuserExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Dbusers
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<Dbuser>> PostDbuser(Dbuser dbuser)
        //{
        //    _context.Dbuser.Add(dbuser);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (DbuserExists(dbuser.Id))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetDbuser", new { id = dbuser.Id }, dbuser);
        //}

        //// DELETE: api/Dbusers/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Dbuser>> DeleteDbuser(string id)
        //{
        //    var dbuser = await _context.Dbuser.FindAsync(id);
        //    if (dbuser == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Dbuser.Remove(dbuser);
        //    await _context.SaveChangesAsync();

        //    return dbuser;
        //}
        //// GET: api/NewsTypes/Search
        //[HttpGet("{search}/{name?}")]
        //public async Task<IEnumerable<NewsType>> Search(string name, string news)
        //{
        //    IQueryable<NewsType> query = _context.NewsType;
        //    if (!string.IsNullOrEmpty(name))
        //    {
        //        query = query.Where(e => e.NewstypeName.Contains(name));

        //    }
        //    return await query.ToListAsync();
        //}

        ////[HttpPost("authenticate")]
        ////public IActionResult Authenticate(Dbuser model)
        ////{
        ////    var response = _context.Authenticate(model);

        ////    if (response == null)
        ////        return BadRequest(new { message = "Username or password is incorrect" });

        ////    return Ok(response);
        ////}

        //[Authorize]
        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    var users = _context.GetAll();
        //    return Ok(users);
        //}

        //[HttpPost("login")]
        //public async Task<IActionResult> Login([FromForm] UserLoginViewModel user)
        //{
        //    //var response = _context.Login(model);

        //    //if (response == null)
        //    //    return BadRequest(new { message = "Username or password is incorrect" });

        //    //return Ok(response);
        //    var us = await _context.Login(user);
        //    return Ok(us);
        //}

        //// POST api/<UsersController>
        //[HttpPost("register")]
        //[AllowAnonymous]
        //public async Task<IActionResult> Register([FromForm] UserRegisterViewModel user)
        //{
        //    var res = await _context.Regi(user);
        //    if (res == 0)
        //        return BadRequest();
        //    return Ok(res);
        //}
        //private bool DbuserExists(string id)
        //{
        //    return _context.Dbuser.Any(e => e.Id == id);
        //}
    }
}
