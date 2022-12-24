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
    public object Create()
    {
        return new { Message = "HelloWorld" };
    }

    [HttpPost("Auth")]
    public object Auth()
    {
        return new { Message = "HelloWorld" };
    }

    [HttpPost("AddInvoice")]
    public object AddInvoice()
    {
        return new { Message = "HelloWorld" };
    }

    [HttpPost("PayInvoice")]
    public object PayInvoice()
    {
        return new { Message = "HelloWorld" };
    }

    [HttpGet("GetBTC")]
    public object GetBTC()
    {
        return new { Message = "HelloWorld" };
    }

    [HttpGet("CheckPayment/{payment_hash}")]
    public object CheckPayment(string payment_hash)
    {
        return new { Message = payment_hash };
    }

    [HttpGet("Balance")]
    public object Balance()
    {
        return new { Message = "HelloWorld" };
    }

    [HttpGet("GetInfo")]
    public object GetInfo()
    {
        return new { Message = "HelloWorld" };
    }

    [HttpGet("GetTxs")]
    public object GetTxs()
    {
        return new { Message = "HelloWorld" };
    }

    [HttpGet("GetUserInvoices")]
    public object GetUserInvoices()
    {
        return new { Message = "HelloWorld" };
    }

    [HttpGet("GetPending")]
    public object GetPending()
    {
        return new { Message = "HelloWorld" };
    }

    [HttpGet("DecodeInvoice")]
    public object DecodeInvoice()
    {
        return new { Message = "HelloWorld" };
    }

    [HttpGet("CheckRouteInvoice")]
    public object CheckRouteInvoice()
    {
        return new { Message = "HelloWorld" };
    }

    [HttpGet("QueryRoutes/{source}/{dest}/{amt}")]
    public object QueryRoutes(string source, string dest, string amt)
    {
        return new { source = source, dest = dest, amt = amt };
    }

    [HttpGet("GetChanInfo/{chanid}")]
    public object GetChanInfo(string chanid)
    {
        return new { Message = "HelloWorld" };
    }
}
