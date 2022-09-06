using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Mvc_1.Models;

public class Score
{
    [Key]
    public Guid Id { get; set; }
    public int Point { get; set; }
    public int BookId { get; set; } 
}