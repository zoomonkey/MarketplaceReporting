using Microsoft.AspNetCore.Mvc;
using MarketplaceReporting.Models;

namespace MarketplaceReporting.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransactionsController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Transaction>> Get()
    {
        var transactions = new List<Transaction>
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

        return Ok(transactions);
    }
}