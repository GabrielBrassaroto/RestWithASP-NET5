using RestWithASPNET.Model;
using System.Collections.Generic;

namespace RestWithASPNET.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);

        Person FindById(long Id);

        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long Id);

        bool Exists(long id);

    }
}
