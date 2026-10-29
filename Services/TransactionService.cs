using MarketplaceReporting.Models;

namespace MarketplaceReporting.Services;

public class TransactionService : ITransactionService
{
    public Transaction? GetTransactionById(int id)
{
    return GetTransactions()
        .FirstOrDefault(t => t.Id == id);
                                }
    public List<Transaction> GetTransactions()
    {
        return new List<Transaction>
        {
            new()
            {
                Id = 1,
                Date = new DateTime(2026, 9, 1),
                Product = "Acrylic Display",
                Amount = 29.99m
            },
            new()
            {
                Id = 2,
                Date = new DateTime(2026, 9, 2),
                Product = "LED Lamp",
                Amount = 49.99m
            }
        };
    }
}