using Dapper;
using Microsoft.Data.SqlClient;
using MarketplaceReporting.Models;

namespace MarketplaceReporting.Services;

public class TransactionService
{
    private readonly string _connectionString;

    public TransactionService(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Database connection string not found.");
    }

    public async Task<IEnumerable<ModelTransaction>> GetAllAsync()
    {
        using var connection = new SqlConnection(_connectionString);

        const string sql = """
            SELECT Id, Marketplace, OrderId, Amount, TransactionDate
            FROM Transactions
            ORDER BY TransactionDate DESC
            """;

        return await connection.QueryAsync<ModelTransaction>(sql);
    }

    public async Task<int> DeleteTransactionByIdAsync(int transactionId)
    {
        using var connection = new SqlConnection(_connectionString);

        const string sql = """
        DELETE FROM Transactions
        WHERE Id = @TransactionId;
        """;

        return await connection.ExecuteAsync(
            sql,
            new { TransactionId = transactionId }
        );
    }

}