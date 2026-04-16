using MoneyManager.Entities;

namespace MoneyManager.Interfaces;

public interface ITransactionRepository : IRepository<Transaction>
{
    Task<Transaction?> GetTransactionWithDetailsAsync(Guid id);
    Task DeleteUserTransactionsCurrentMonthAsync(Guid userId);
    Task<List<TransactionListItem>> GetTransactionsByUserAsync(Guid userId);
    Task<List<MonthlyTotalsItem>> GetMonthlyTotalsAsync(Guid userId, DateTime startDate, DateTime endDate);
    Task<List<CategoryTotalsItem>> GetCategoryTotalsAsync(Guid userId, int operationType);
}
