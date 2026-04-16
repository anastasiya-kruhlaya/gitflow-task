using Microsoft.EntityFrameworkCore;
using MoneyManager.Entities;

namespace MoneyManager;

public class DatabaseSeeder
{
    private readonly MoneyManagerContext _context;

    public DatabaseSeeder(MoneyManagerContext context)
    {
        _context = context;
    }

    public async Task SeedAsync()
    {
        if (await _context.Users.AnyAsync())
            return;

        await using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            var users = SeedUsers();
            await _context.Users.AddRangeAsync(users);
            await _context.SaveChangesAsync();

            var rootCategories = GetRootCategories();
            await _context.Categories.AddRangeAsync(rootCategories);
            await _context.SaveChangesAsync();

            var subCategories = GetSubCategories(rootCategories);
            await _context.Categories.AddRangeAsync(subCategories);
            await _context.SaveChangesAsync();

            var assets = SeedAssets(users);
            await _context.Assets.AddRangeAsync(assets);
            await _context.SaveChangesAsync();

            var allCategories = rootCategories.Concat(subCategories).ToList();
            var transactions = SeedTransactions(assets, allCategories);
            await _context.Transactions.AddRangeAsync(transactions);
            await _context.SaveChangesAsync();

            await transaction.CommitAsync();
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    private List<User> SeedUsers() =>
    [
        new User { Id = Guid.NewGuid(), Name = "Alice",   Email = "alice@mail.com",   Hash = "hash1", Salt = "salt1" },
        new User { Id = Guid.NewGuid(), Name = "Bob",     Email = "bob@mail.com",     Hash = "hash2", Salt = "salt2" },
        new User { Id = Guid.NewGuid(), Name = "Charlie", Email = "charlie@mail.com", Hash = "hash3", Salt = "salt3" },
        new User { Id = Guid.NewGuid(), Name = "Diana",   Email = "diana@mail.com",   Hash = "hash4", Salt = "salt4" },
        new User { Id = Guid.NewGuid(), Name = "Eve",     Email = "eve@mail.com",     Hash = "hash5", Salt = "salt5" },
        new User { Id = Guid.NewGuid(), Name = "Frank",   Email = "frank@mail.com",   Hash = "hash6", Salt = "salt6" },
    ];

    private List<Category> GetRootCategories() =>
    [
        new Category { Id = Guid.NewGuid(), Name = "Salary", Type = 0 },
        new Category { Id = Guid.NewGuid(), Name = "Freelance", Type = 0 },
        new Category { Id = Guid.NewGuid(), Name = "Food", Type = 1 },
        new Category { Id = Guid.NewGuid(), Name = "Transport", Type = 1 },
        new Category { Id = Guid.NewGuid(), Name = "Housing", Type = 1 },
        new Category { Id = Guid.NewGuid(), Name = "Health", Type = 1 },
    ];

    private List<Category> GetSubCategories(List<Category> rootCategories)
    {
        var food = rootCategories.First(c => c.Name == "Food");
        var transport = rootCategories.First(c => c.Name == "Transport");
        var housing = rootCategories.First(c => c.Name == "Housing");
        var health = rootCategories.First(c => c.Name == "Health");

        return
        [
            new Category { Id = Guid.NewGuid(), Name = "Groceries",    Type = 1, ParentId = food.Id },
        new Category { Id = Guid.NewGuid(), Name = "Restaurant",   Type = 1, ParentId = food.Id },
        new Category { Id = Guid.NewGuid(), Name = "Taxi",         Type = 1, ParentId = transport.Id },
        new Category { Id = Guid.NewGuid(), Name = "Public Trans", Type = 1, ParentId = transport.Id },
        new Category { Id = Guid.NewGuid(), Name = "Rent",         Type = 1, ParentId = housing.Id },
        new Category { Id = Guid.NewGuid(), Name = "Pharmacy",     Type = 1, ParentId = health.Id },
    ];
    }

    private List<Asset> SeedAssets(List<User> users)
    {
        var assets = new List<Asset>();
        var names = new[] { "Main Card", "Savings", "Cash", "Credit Card" };

        for (int idx = 0; idx < users.Count; idx++)
        {
            int count = idx % 2 == 0 ? 4 : 3;
            for (int i = 0; i < count; i++)
            {
                assets.Add(new Asset
                {
                    Id = Guid.NewGuid(),
                    Name = names[i],
                    UserId = users[idx].Id
                });
            }
        }
        return assets;
    }

    private List<Transaction> SeedTransactions(List<Asset> assets, List<Category> categories)
    {
        var rnd = new Random(42);
        var transactions = new List<Transaction>();
        var now = DateTime.UtcNow;

        var leafCategories = categories
            .Where(c => c.ParentId != null || c.Type == 0)
            .ToList();

        for (int i = 0; i < 105; i++)
        {
            var asset = assets[rnd.Next(assets.Count)];
            var category = leafCategories[rnd.Next(leafCategories.Count)];
            var daysBack = rnd.Next(0, 180);
            var amount = category.Type == 0
                ? Math.Round((decimal)(rnd.NextDouble() * 3000 + 500), 3)
                : -Math.Round((decimal)(rnd.NextDouble() * 500 + 10), 3);

            transactions.Add(new Transaction
            {
                Id = Guid.NewGuid(),
                AssetId = asset.Id,
                CategoryId = category.Id,
                Amount = amount,
                Date = now.AddDays(-daysBack),
                Comment = rnd.Next(3) == 0 ? $"Comment {i}" : null
            });
        }
        return transactions;
    }
}