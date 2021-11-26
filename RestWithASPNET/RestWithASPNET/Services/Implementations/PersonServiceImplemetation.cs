using RestWithASPNET.Model;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplemetation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long Id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        public Person FindById(long Id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
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


        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Namae" + i,
                LastName = "Person lstName" + i,
                Address = "Some Adress" + 1,
                Gender = "Maale"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
