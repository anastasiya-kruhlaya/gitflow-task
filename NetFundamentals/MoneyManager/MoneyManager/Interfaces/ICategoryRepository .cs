using MoneyManager.Entities;

namespace MoneyManager.Interfaces;

public interface ICategoryRepository : IRepository<Category>
{
    Task<Category?> GetCategoryWithHierarchyAsync(Guid id);
}
