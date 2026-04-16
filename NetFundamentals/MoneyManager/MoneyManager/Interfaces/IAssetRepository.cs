using MoneyManager.Entities;

namespace MoneyManager.Interfaces;

public interface IAssetRepository : IRepository<Asset>
{
    Task<List<AssetBalanceItem>> GetAssetsByUserAsync(Guid userId);
}
