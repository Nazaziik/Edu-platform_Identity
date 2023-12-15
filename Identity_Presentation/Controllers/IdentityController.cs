﻿using Identity_Application.Commands.Identities;
using Identity_Application.Models.BaseEntitiesModels;
using Identity_Application.Queries.Identities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Identity_Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IdentityController : Controller
{
    private readonly IMediator _mediator;

    public IdentityController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetIdentityById(int id)
    {
        var result = await _mediator
            .Send(new GetIdentityByIdQuery(id));

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllIdentities()
    {
        var result = await _mediator
            .Send(new GetAllIdentitiesQuery());

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateIdentity([FromBody] IdentityVM identityVM)
    {
        var result = await _mediator
            .Send(new CreateIdentityCommand(identityVM));

        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateIdentity(int id, [FromBody] IdentityVM identityVM)
    {
        await _mediator
            .Send(new UpdateIdentityCommand(id, identityVM));

        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteIdentity(int id)
    {
        await _mediator
            .Send(new DeleteIdentityCommand(id));

        return Ok();
    }
}