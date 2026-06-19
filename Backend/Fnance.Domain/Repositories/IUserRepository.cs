using Fnance.Domain.Entities;


namespace Fnance.Domain.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user);

        Task<User> GetByEmailAsync(string email);

    }
}
