using Application.Commands.CreateProvider;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProviderController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Fetch(GetProviderCommand command)
    {
        var providerId = await mediator.Send(command);
        return Ok(providerId);
    }

    [HttpPost]
    public async Task<IActionResult> Create(GetProviderCommand command)
    {
        var providerId = await mediator.Send(command);
        return Ok(providerId);
    }
}