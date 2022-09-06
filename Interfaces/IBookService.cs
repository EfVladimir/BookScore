using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Mvc_1.Models;

namespace WebApplication_Mvc_1.Interfaces
{
    public interface IBookService
    {
        Task<List<Book>> GetBooks();
    }
}