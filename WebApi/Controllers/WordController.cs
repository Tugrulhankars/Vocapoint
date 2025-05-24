using Application.Features.Word.Commands.Create;
using Application.Features.Word.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WordController : ControllerBase
{
    private readonly IMediator _mediator;

    public WordController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromForm] CreateWordCommand createWordCommand)
    {
        CreateWordResponse response=await _mediator.Send(createWordCommand);
        return Ok(response);
    }

    [HttpGet("getAll")]
    public async Task<IActionResult> GetAll(GetAllWordQuery getAllWordQuery)
    {
        List<GetAllWordResponse> response=await _mediator.Send(getAllWordQuery);
        return Ok(response);
    }
}
