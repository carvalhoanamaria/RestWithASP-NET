using RestASPNET.Model;
using RestASPNET.Model.Context;
using RestASPNET.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestASPNET.Business.Implementations
{
    public class BooksBusinessImplementation : IBooksBusiness
    {
        private readonly IBooksRepository _repository;
        public BooksBusinessImplementation(IBooksRepository repository)
        {
            _repository = repository;
        }

        public List<Books> FindAll()
        {
            return _repository.FindAll();
        }

        public Books FindByID(long id)
        {
            return _repository.FindByID(id);
        }
        public Books Create(Books books)
        {
            return _repository.Create(books);
        }

        public Books Update(Books books)
        {
            return _repository.Update(books);
        }

        public void Delete(long id)
        {
             _repository.Delete(id);
        }

    }
}
