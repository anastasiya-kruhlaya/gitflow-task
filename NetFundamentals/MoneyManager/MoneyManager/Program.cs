using Microsoft.EntityFrameworkCore;
using MoneyManager;
using MoneyManager.Repositories;

await using var context = new MoneyManagerContext();

await context.Database.MigrateAsync();

var seeder = new DatabaseSeeder(context);
await seeder.SeedAsync();


var userRepository = new UserRepository(context);
var assetRepository = new AssetRepository(context);
var transactionRepository = new TransactionRepository(context);

var users = await userRepository.GetUsersSortedByNameAsync();
Console.WriteLine("Users");
foreach (var u in users)
    Console.WriteLine($"{u.Name}, {u.Email}");

Console.WriteLine("\nBalances");
foreach (var u in users)
{
    var balance = await userRepository.GetUserBalanceAsync(u.Id);
    Console.WriteLine($"  {balance?.Name}: {balance?.Balance:F2}");
}

var firstUserId = users[0].Id;
var assets = await assetRepository.GetAssetsByUserAsync(firstUserId);
Console.WriteLine($"\nfor {users[0].Name}");
foreach (var a in assets)
    Console.WriteLine($"  {a.Name}: {a.Balance:F2}");

var txList = await transactionRepository.GetTransactionsByUserAsync(firstUserId);
Console.WriteLine($"\nTransactions for {users[0].Name} (first 5)");
foreach (var t in txList.Take(5))
    Console.WriteLine($"  [{t.Date:yyyy-MM-dd}] {t.AssetName}, {t.CategoryParentName} ({t.CategoryName}): {t.Amount:F2}");

var monthly = await transactionRepository.GetMonthlyTotalsAsync(
    firstUserId,
    DateTime.UtcNow.AddMonths(-6),
    DateTime.UtcNow);
Console.WriteLine($"\nMonthly Totals for {users[0].Name}");
foreach (var m in monthly)
    Console.WriteLine($"  {m.Year}-{m.Month:D2}: Income={m.Income:F2}, Expenses={m.Expenses:F2}");

var catTotals = await transactionRepository.GetCategoryTotalsAsync(firstUserId, operationType: 1);
Console.WriteLine($"\nCategory Expenses this month for {users[0].Name}");
foreach (var c in catTotals)
    Console.WriteLine($"  {c.CategoryName}: {c.Amount:F2}");
