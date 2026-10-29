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

    [HttpGet("paged")]
    public ActionResult<List<Transaction>> GetPaged(
        int page = 1,
        int pageSize = 10)
    {
        if (page < 1 || pageSize < 1)
            return BadRequest("Page and pageSize must be positive.");

        var transactions = _service.GetTransactionsPaged(page, pageSize);

        return Ok(transactions);
    }

}
