﻿using RestASPNET.Model;
using System.Collections.Generic;

namespace RestASPNET.Repository
{
    public interface IBooksRepository
    {
        Books Create(Books books);

        Books FindByID(long id);

        List<Books> FindAll();

        Books Update(Books books);

        void Delete(long id);

        bool Exists(long id);


    }
}
