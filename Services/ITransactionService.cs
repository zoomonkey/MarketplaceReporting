using MarketplaceReporting.Models;

namespace MarketplaceReporting.Services;

public interface ITransactionService
{
    List<Transaction> GetTransactions();

     Transaction? GetTransactionById(int id);
}

