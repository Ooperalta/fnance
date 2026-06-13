using Fnance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fnance.Domain.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user);

        Task<User> GetByEmailAsync(string email);

    }
}
