using Amazon.Application.Contracts;
using Amazon.Context;
using Amazon.Domain;
using Amazon.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Infrastrucure
{
    public class RatingRepository : Reposatory<Rating, int>, IRatingRepository
    {
        private  ApplicationContext _context;
        private  DbSet<Rating> _dbset;
        public RatingRepository(ApplicationContext context) : base(context)
        {
            _context = context;
            _dbset = _context.Set<Rating>();

        }

        public async Task<List<Rating>> GetAllByProductIdAsync(int productId)
        {
            return await _dbset.Where(R => R.productId == productId).ToListAsync();
        }
    }
}
