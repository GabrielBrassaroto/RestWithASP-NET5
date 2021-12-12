using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class BooksServiceImplementation : IBooksBusiness
    {
        private readonly IRepository<Books> _repository;

        public BooksServiceImplementation(IRepository<Books> repository)
        {
            _repository = repository;
        }
        
        // Method responsible for returning all people,
        public List<Books> FindAll()
        {
            return _repository.FindAll();
        }

        // Method responsible for returning one person by ID
        public Books FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        // Method responsible to crete one new person
        public Books Create(Books books)
        {
            return _repository.Create(books);
        }

        // Method responsible for updating one person
        public Books Update(Books books)
        {
            return _repository.Update(books);
        }

        // Method responsible for deleting a person from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }

    }
}
