using Himsug_Final4.Shared;
using Himsug_Final4.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Himsug_Final4.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly SQLDBContext _dbcontext;

        public UserController(SQLDBContext context)
        {
            _dbcontext = context;
        }

        [Route("GetUser")]
        [HttpGet]
        public async Task<List<Accounts>> GetUser()
        {
            try
            {
                var _data = await _dbcontext.Accounts.ToListAsync();
                return _data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        [Route("GetUser/{id}")]
        [HttpGet]
        public async Task<Accounts> GetUser(int id)
        {
            try
            {
                var _data = await _dbcontext.Accounts.FindAsync(id);
                return _data;
            }

            catch (Exception)
            {
                throw;
            }
        }
        [Route("SaveUser")]
        [HttpPost]
        public async Task<IActionResult> SaveUser([FromBody]Accounts accounts)
        {
            try
            {
                if (_dbcontext.Accounts == null)
                {
                    return Problem("Entity set 'AppDbContext.User is null'");
                }
                if (accounts != null)
                {
                    _dbcontext.Add(User);
                    await _dbcontext.SaveChangesAsync();

                    return Ok("Saved");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return NoContent();
        }

        [Route("UpdateUser")]
        [HttpPost]
        public async Task<IActionResult> UpdateUser([FromBody]Accounts accounts)
        {
            _dbcontext.Entry(accounts).State = EntityState.Modified;

            try
            {
                _dbcontext.Entry(accounts).State = EntityState.Modified;
                await _dbcontext.SaveChangesAsync();
                return Ok("Update Successful");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(accounts.AccountsID))
                {
                    return NotFound("User Not Found");
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error" + ex.Message);
            }
            return NoContent();
        }

        
        [HttpDelete("DeleteUser/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (_dbcontext.Accounts == null)
            {
                return NotFound();
            }
            var role1 = await _dbcontext.Accounts.FindAsync(id);
            if (role1 == null)
            {
                return NotFound();  
            }
            _dbcontext.Accounts.Remove(role1);
            await _dbcontext.SaveChangesAsync();

            return NoContent();

        }
        public bool UserExists(int id)
        {
            return (_dbcontext.Accounts?.Any(u => u.AccountsID == id)).GetValueOrDefault();
        }

    }
}
