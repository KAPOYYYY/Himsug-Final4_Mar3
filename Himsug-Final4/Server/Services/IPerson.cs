using Himsug_Final4.Shared.Models;

namespace Himsug_Final4.Server.Services
{
    public interface IPerson
    {
        public List<Person> GetPeopleDetails();
        public void AddPerson(Person person);

        public void UpdatePerson (Person person);

        public void DeletePerson (int personID);

        public Person GetPerson (int personID);
    }
}
