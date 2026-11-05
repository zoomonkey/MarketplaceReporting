using Microsoft.AspNetCore.Mvc;
using MarketplaceReporting.Services;
using MarketplaceReporting.Models;

namespace MarketplaceReporting.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransactionsController : ControllerBase
{
    private readonly TransactionService _transactionService;

    public TransactionsController(TransactionService transactionService)
    {
        _transactionService = transactionService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ModelTransaction>>> GetAll()
    {
        var transactions = await _transactionService.GetAllAsync();

        return Ok(transactions);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTransactionByIdAsync(int id)
    {
        int rowsAffected = await _transactionService.DeleteTransactionByIdAsync(id);

        if (rowsAffected == 0)
        {
            return NotFound($"Transaction {id} was not found.");
        }

        return NoContent();
    }

}