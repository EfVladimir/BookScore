using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication_Mvc_1.Interfaces;
using WebApplication_Mvc_1.Models;
using WebApplication_Mvc_1.Persistence;

namespace WebApplication_Mvc_1.Services
{
    public class BookService : IBookService
    {
        private readonly DataContext _context;
        public BookService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetBooks()
        {
            var books = await _context.Books.ToListAsync();
            return books;
        }
    }
}