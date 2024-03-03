using Himsug_Final4.Shared;
using Himsug_Final4.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Himsug_Final4.Server.Services
{
    public class PersonManager : IPerson
    {

        readonly PersonDBContext _personDB = new();

        public PersonManager(PersonDBContext personDB) 
        {
            _personDB = personDB;
        }
        //AddPerson
        public void AddPerson(Person ppl)
        {
            try
            {
                _personDB.Person.Add(ppl);
                _personDB.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //DeletePerson
        public void DeletePerson(int personID)
        {
            try
            {
                Person? person = _personDB.Person.Find(personID);
                if (person != null)
                {
                    _personDB.Person.Remove(person);
                    _personDB.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        //List Persons
        public List<Person> GetPeopleDetails()
        {
            try
            {
                return _personDB.Person.ToList();
            }
            catch
            {
                throw;
            }
        }
        //GetPersonID
        public Person GetPerson(int personID)
        {
            try
            {
                Person? person = _personDB.Person.Find(personID);
                if (person != null)
                {
                    return person;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        //UpdatePerson
        public void UpdatePerson(Person ppl)
        {
            try
            {
                _personDB.Entry(ppl).State = EntityState.Modified;
                _personDB.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
