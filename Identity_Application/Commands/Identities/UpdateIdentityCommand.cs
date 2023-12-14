﻿using Identity_Application.Interfaces.Repository;
using Identity_Domain.Entities.Base;
using MediatR;

namespace Identity_Application.Commands.Identities;

public record UpdateIdentityCommand(Identity Identity) : IRequest;

public class EditIdentityHandler : IRequestHandler<UpdateIdentityCommand>
{
    private readonly IGenericRepository<Identity> _identityRepository;

    public EditIdentityHandler(IGenericRepository<Identity> identityRepository)
    {
        _identityRepository = identityRepository;
    }

    public async Task Handle(UpdateIdentityCommand request, CancellationToken cancellationToken)
    {
        await _identityRepository.UpdateAsync(request.Identity);
    }
}