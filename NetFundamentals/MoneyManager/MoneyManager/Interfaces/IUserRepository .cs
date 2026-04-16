using MoneyManager.Entities;

namespace MoneyManager.Interfaces;

public interface IUserRepository : IRepository<User>
{
    Task<User?> GetUserByEmailAsync(string email);
    Task<List<UserListItem>> GetUsersSortedByNameAsync();
    Task<UserListItem?> GetUserByEmailModelAsync(string email);
    Task<UserBalanceItem?> GetUserBalanceAsync(Guid userId);
}
