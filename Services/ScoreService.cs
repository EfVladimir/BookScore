using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Mvc_1.Interfaces;
using WebApplication_Mvc_1.Persistence;
using Microsoft.EntityFrameworkCore;
using WebApplication_Mvc_1.Models;

namespace WebApplication_Mvc_1.Services
{
    public class ScoreService : IScoringService
    {
        private readonly DataContext _context;
        public ScoreService(DataContext context)
        {
            _context = context;
        }

        public async Task<double> GetRating(int bookId)
        {
            double rating = await _context.Scores.Where(w=>w.BookId == bookId).AverageAsync(a=>a.Point);
            return rating;
        }

        public async Task SetRating(int bookId, int point)
        {
            Score scorenew = new(){
                Id = Guid.NewGuid(),
                BookId = bookId,
                Point = point
            };
            var score = await _context.Scores.AddAsync(scorenew);
            _context.SaveChanges();
        }
    }
}