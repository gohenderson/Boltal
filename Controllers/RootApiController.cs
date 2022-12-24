using Microsoft.AspNetCore.Mvc;

namespace Boltal.Controllers;

[ApiController]
[Route("")]
public class RootApiController : ControllerBase
{
    private readonly ILogger<RootApiController> _logger;

    public RootApiController(ILogger<RootApiController> logger)
    {
        _logger = logger;
    }

    [HttpPost("Create")]
    public async Task<object> CreateAsync()
    {
        return await Task.FromResult(new { Message = "HelloWorld" });
    }

    [HttpPost("Auth")]
    public async Task<object> AuthAsync()
    {
        return await Task.FromResult(new { Message = "HelloWorld" });
    }

    [HttpPost("AddInvoice")]
    public async Task<object> AddInvoiceAsync()
    {
        return await Task.FromResult(new { Message = "HelloWorld" });
    }

    [HttpPost("PayInvoice")]
    public async Task<object> PayInvoiceAsync()
    {
        return await Task.FromResult(new { Message = "HelloWorld" });
    }

    [HttpGet("GetBTC")]
    public async Task<object> GetBTCAsync()
    {
        return await Task.FromResult(new { Message = "HelloWorld" });
    }

    [HttpGet("CheckPayment/{payment_hash}")]
    public async Task<object> CheckPaymentAsync(string payment_hash)
    {
        return await Task.FromResult(new { Message = payment_hash });
    }

    [HttpGet("Balance")]
    public async Task<object> BalanceAsync()
    {
        return await Task.FromResult(new { Message = "HelloWorld" });
    }

    [HttpGet("GetInfo")]
    public async Task<object> GetInfoAsync()
    {
        return await Task.FromResult(new { Message = "HelloWorld" });
    }

    [HttpGet("GetTxs")]
    public async Task<object> GetTxsAsync()
    {
        return await Task.FromResult(new { Message = "HelloWorld" });
    }

    [HttpGet("GetUserInvoices")]
    public async Task<object> GetUserInvoicesAsync()
    {
        return await Task.FromResult(new { Message = "HelloWorld" });
    }

    [HttpGet("GetPending")]
    public async Task<object> GetPendingAsync()
    {
        return await Task.FromResult(new { Message = "HelloWorld" });
    }

    [HttpGet("DecodeInvoice")]
    public async Task<object> DecodeInvoiceAsync()
    {
        return await Task.FromResult(new { Message = "HelloWorld" });
    }

    [HttpGet("CheckRouteInvoice")]
    public async Task<object> CheckRouteInvoiceAsync()
    {
        return await Task.FromResult(new { Message = "HelloWorld" });
    }

    [HttpGet("QueryRoutes/{source}/{dest}/{amt}")]
    public async Task<object> QueryRoutesAsync(string source, string dest, string amt)
    {
        return await Task.FromResult(new { source = source, dest = dest, amt = amt });
    }

    [HttpGet("GetChanInfo/{chanid}")]
    public async Task<object> GetChanInfoAsync(string chanid)
    {
        return await Task.FromResult(await Task.FromResult(new { Message = "HelloWorld" }));
    }
}
