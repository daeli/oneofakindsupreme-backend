﻿using MediatR;
using OneOfAKindSupreme.Backend.Core.Interfaces;
using OneOfAKindSupreme.Backend.Core.Entities;

namespace OneOfAKindSupreme.Backend.UseCases.Projects.Commands.Create
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, int>
    {
        IWriteRepository<Project> repository;
        public CreateProjectCommandHandler(IWriteRepository<Project> repository) 
        {
            this.repository = repository;
        }

        public async Task<int> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var addedEntity = await repository.AddAsync(request.Project, cancellationToken);

            return addedEntity.Id;
        }
    }
}
