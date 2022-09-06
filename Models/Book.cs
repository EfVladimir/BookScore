using System.ComponentModel.DataAnnotations;

namespace WebApplication_Mvc_1.Models;

public class Book
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Author { get; set; } = null!;
}