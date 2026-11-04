namespace MarketplaceReporting.Models;

public class ModelTransaction
{
    public int Id { get; set; }
    public string Marketplace { get; set; } = string.Empty;
    public string OrderId { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime TransactionDate { get; set; }
}