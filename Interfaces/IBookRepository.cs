﻿using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IBookRepository: IDisposable
    {
        IEnumerable<Book> GetBookList();
        Book GetBook(int id);
        void Create(Book item);
        void Update(Book item);
        void Delete(int id);
        void Save();
    }
}
