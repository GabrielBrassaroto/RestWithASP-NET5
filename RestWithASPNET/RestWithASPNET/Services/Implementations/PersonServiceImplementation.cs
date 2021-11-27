using RestWithASPNET.Model;
using RestWithASPNET.Model.Context;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private MySqlContext _context;

        public PersonServiceImplementation(MySqlContext context)
        {
         _context = context;
        }

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long Id)
        {
            
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(long Id)
        {
            return new Person
            {
                Id = 1,
                FirstName ="Gabriel",
                LastName = "brassaroto",
                Address = "Ibipora",
                Gender =  "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
