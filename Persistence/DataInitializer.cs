using WebApplication_Mvc_1.Models;

namespace WebApplication_Mvc_1.Persistence;

public class DataInitializer
{
    private readonly DataContext _context;

    public DataInitializer(DataContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
    
    public async Task Init()
    {
        if (!_context.Books.Any() && !_context.Scores.Any())
        {
            List<Book> books = new()
            {
                new() { Id = 1, Name = "Преступление и наказание", Author = "Ф. М. Достоквский" },
                new() { Id = 2, Name = "Мастер и Маргарита", Author = "М. Ф. Булгаков" },
                new() { Id = 3, Name = "Над пропасью во ржи", Author = "Дж. Селленджер" },
                new() { Id = 4, Name = "Отцы и дети", Author = "И. С. Тургенев" }
            };

            List<Score> scores = new()
            {
                new() { BookId = 1, Point = 3 },
                new() { BookId = 1, Point = 5 },
                new() { BookId = 1, Point = 5 },
                new() { BookId = 1, Point = 5 },

                new() { BookId = 2, Point = 3 },
                new() { BookId = 2, Point = 5 },
                new() { BookId = 2, Point = 5 },
                new() { BookId = 2, Point = 5 },
                new() { BookId = 2, Point = 3 },
                new() { BookId = 2, Point = 5 },
                new() { BookId = 2, Point = 5 },
                new() { BookId = 2, Point = 5 },

                new() { BookId = 3, Point = 5 },
                new() { BookId = 3, Point = 2 },
                new() { BookId = 3, Point = 1 },
                new() { BookId = 3, Point = 3 },
                new() { BookId = 3, Point = 5 },
                new() { BookId = 3, Point = 4 },
                new() { BookId = 3, Point = 4 },
                new() { BookId = 3, Point = 5 },
                new() { BookId = 3, Point = 3 },
                new() { BookId = 3, Point = 2 },

                new() { BookId = 4, Point = 2 },
                new() { BookId = 4, Point = 3 },
                new() { BookId = 4, Point = 5 },
                new() { BookId = 4, Point = 3 },
                new() { BookId = 4, Point = 2 },
                new() { BookId = 4, Point = 1 },
                new() { BookId = 4, Point = 2 },
                new() { BookId = 4, Point = 4 },
            };

            await _context.Books.AddRangeAsync(books);
            await _context.Scores.AddRangeAsync(scores);
            await _context.SaveChangesAsync();
        }
    }   
}   