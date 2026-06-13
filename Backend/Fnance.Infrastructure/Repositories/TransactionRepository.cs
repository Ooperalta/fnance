using Fnance.Domain.Entities;
using Fnance.Domain.Repositories;
using Fnance.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace Fnance.Infrastructure.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly AppDbContext _dbContext;

        public TransactionRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Transaction transaction)
        {
            _dbContext.Transactions.Add(transaction);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Transaction>> GetAllByUserIdAsync(Guid userId)
        {
            return await _dbContext.Transactions.Where(t => t.UserId == userId).ToListAsync();
        }
    }
}
