using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Date.Converter.Contract;
using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Data.Converter.Implementations
{
    public class BooksConverter : IParser<BooksVO, Books>, IParser<Books, BooksVO>
    {
        public Books Parse(BooksVO origin)
        {
            if (origin == null) return null; // se origin for null retorna null
            return new Books //cria um person passando os valor que vieram no origin
            {
                Author = origin.Author,
                Launch_date = origin.Launch_date,
                Price = origin.Price,
                Title = origin.Title

            };
        }

        public BooksVO Parse(Books origin)
        {
            if (origin == null) return null; // se origin for null retorna null
            return new BooksVO //cria um person passando os valor que vieram no origin
            {
                Author = origin.Author,
                Launch_date = origin.Launch_date,
                Price = origin.Price,
                Title = origin.Title

            };
        }

        public IList<Books> Parse(IList<BooksVO> origin)
        {

            if (origin == null) return null; // se origin for null retorna null
            return origin.Select(item => Parse(item)).ToList();
        }


        public IList<BooksVO> Parse(IList<Books> origin)
        {
            if (origin == null) return null; // se origin for null retorna null
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
