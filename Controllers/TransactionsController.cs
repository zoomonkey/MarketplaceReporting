using Microsoft.AspNetCore.Mvc;
using MarketplaceReporting.Models;
using MarketplaceReporting.Services;

namespace MarketplaceReporting.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransactionsController : ControllerBase
{
    private readonly ITransactionService _service;

    public TransactionsController(ITransactionService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Transaction>> Get()
    {
        return Ok(_service.GetTransactions());
    }
}
