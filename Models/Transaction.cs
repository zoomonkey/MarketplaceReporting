namespace MarketplaceReporting.Models;

public class Transaction
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Product { get; set; } = string.Empty;
    public decimal Amount { get; set; }
}