using RestASPNET.Model;
using System.Collections.Generic;

namespace RestASPNET.Business
{
    public interface IBooksBusiness
    {
        Books Create(Books books);

        Books FindByID(long id);

        List<Books> FindAll();

        Books Update(Books books);

        void Delete(long id);

 
    }
}
