using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Date.Converter.Contract;
using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Data.Converter.Implementations
{
    public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {
        public Person Parse(PersonVO origin)
        {
            if (origin == null) return null; // se origin for null retorna null
            return new Person //cria um person passando os valor que vieram no origin
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Address = origin.Address,
                Gender = origin.Gender

            };
        }

        public PersonVO Parse(Person origin)
        {
            if (origin == null) return null; // se origin for null retorna null
            return new PersonVO //cria um person passando os valor que vieram no origin
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Address = origin.Address,
                Gender = origin.Gender

            };
        }

        public IList<Person> Parse(IList<PersonVO> origin)
        {

            if (origin == null) return null; // se origin for null retorna null
            return origin.Select(item => Parse(item)).ToList();
        }


        public IList<PersonVO> Parse(IList<Person> origin)
        {
            if (origin == null) return null; // se origin for null retorna null
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
