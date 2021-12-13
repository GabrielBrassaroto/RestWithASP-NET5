using RestWithASPNETUdemy.Data.Converter.Implementations;
using RestWithASPNETUdemy.Data.VO;
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
        private readonly BooksConverter _converter;


        public BooksServiceImplementation(IRepository<Books> repository)
        {
            _repository = repository;
            _converter = new BooksConverter();
        }
        
        // Method responsible for returning all people,
        public List<BooksVO> FindAll()
        {
            return (List<BooksVO>)_converter.Parse(_repository.FindAll());
        }

        // Method responsible for returning one person by ID
        public BooksVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        // Method responsible to crete one new person
        public BooksVO Create(BooksVO books)
        {
            var bookEntity = _converter.Parse(books);
            bookEntity = _repository.Create(bookEntity);
            return _converter.Parse(bookEntity);
        }

        // Method responsible for updating one person
        public BooksVO Update(BooksVO books)
        {
            var bookEntity = _converter.Parse(books);
            bookEntity = _repository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }

        // Method responsible for deleting a person from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }

    }
}
