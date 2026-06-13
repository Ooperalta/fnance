using Fnance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fnance.Domain.Repositories
{
    public interface ITransactionRepository
    {
        Task AddAsync(Transaction transaction);

        Task<IEnumerable<Transaction>> GetAllByUserIdAsync(Guid userId);
    }
}
