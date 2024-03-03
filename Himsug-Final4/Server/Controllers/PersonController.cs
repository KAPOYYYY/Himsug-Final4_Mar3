using Himsug_Final4.Shared;
using Himsug_Final4.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Himsug_Final4.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonDBContext _personDB;
        public PersonController(PersonDBContext personDB)
        {
            _personDB = personDB;
        }

        [Route("GetPerson")]
        [HttpGet]
        public async Task<List<Person>> GetPerson()
        {
            try
            {
                var _data = await _personDB.Person.ToListAsync();
                return _data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        [Route("GetUser/{personID}")]
        [HttpGet]
        public async Task<Person> GetPerson(int personID)
        {
            try
            {
                var _data = await _personDB.Person.FindAsync(personID);
                return _data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        [Route("AddPerson")]
        [HttpPost]
        public async Task<IActionResult> AddPerson([FromBody] Person person)
            {
            try
            {
                if (_personDB == null)
            {
                return Problem("Entity set 'AppdbContext.Person' is null");
            }
                if (person != null)
                {
                    _personDB.Add(person);
                    await _personDB.SaveChangesAsync();

                    return Ok("Saved");
                }

            }
            catch (Exception)
            {
                throw;
            }
            return NoContent();
            }
        [Route("UpdatePerson")]
        [HttpPost]
        public async Task <IActionResult> UpdatePerson([FromBody]Person person)
        {
            _personDB.Entry(person).State = EntityState.Modified;

            try
            {
                _personDB.Entry(person).State = EntityState.Modified;
                await _personDB.SaveChangesAsync();
                return Ok("Successfully Updated");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(person.PersonID))
                {
                    return NotFound("Person Not Found");
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

        public bool PersonExists(int personID)
        {
            return (_personDB.Person?.Any(p => p.PersonID == personID)).GetValueOrDefault();
        }
    } 
}
