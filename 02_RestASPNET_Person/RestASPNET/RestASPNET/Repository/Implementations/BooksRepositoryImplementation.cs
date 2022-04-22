﻿using RestASPNET.Model;
using RestASPNET.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestASPNET.Repository.Implementations
{
    public class BooksRepositoryImplementation : IBooksRepository
    {
        private MySQLContext _context;
        public BooksRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }

        public List<Books> FindAll()
        {
            return _context.Books.ToList();
        }

        public Books FindByID(long id)
        {
            return _context.Books.SingleOrDefault(p => p.Id.Equals(id));
        }
        public Books Create(Books books)
        {
            try
            {
                _context.Add(books);
                _context.SaveChanges();
            }
            catch (Exception )
            {
                throw;
            }
            return books;
        }

        public Books Update(Books books)
        {
            if (!Exists(books.Id)) 
                return new Books();

            var result = _context.Books.SingleOrDefault(p => p.Id.Equals(books.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(books);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return books;
        }

        public void Delete(long id)
        {
            var result = _context.Books.SingleOrDefault(p => p.Id.Equals(id));

            if (result != null)
            {
                try
                {
                    _context.Books.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return _context.Books.Any(p => p.Id.Equals(id));
        }
    }
}
