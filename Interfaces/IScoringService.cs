using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Mvc_1.Interfaces
{
    public interface IScoringService
    {
        Task<double> GetRating(int bookId);
        Task SetRating(int bookId, int point);
    }
}