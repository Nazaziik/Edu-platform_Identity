﻿using Identity_Application.Interfaces.Repository;
using Identity_Domain.Entities.Base;
using MediatR;

namespace Identity_Application.Queries;

public record GetAllIdentitiesQuery : IRequest<List<Identity>>;

public class GetAllIdentitiesHandler : IRequestHandler<GetAllIdentitiesQuery, List<Identity>>
{
    private readonly IGenericRepository<Identity> _identityRepository;

    public GetAllIdentitiesHandler(IGenericRepository<Identity> identityRepository)
    {
        _identityRepository = identityRepository;
    }

    public async Task<List<Identity>> Handle(GetAllIdentitiesQuery request, CancellationToken cancellationToken)
    {
        var result = await _identityRepository.GetAsync(/*includeProperties: "Role"*/);
        return result.ToList();
    }
}