using Microsoft.EntityFrameworkCore;
using WebApplication_Mvc_1.Models;

namespace WebApplication_Mvc_1.Persistence;

/// <summary>
/// this class necessary for using dbcontext
/// </summary>
public class DataContext : DbContext
{
    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="options"></param>
    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    public DbSet<Book> Books { get; set; }
    public DbSet<Score> Scores { get; set; }
}