﻿using MediatR;
using ValidUsers.API.Repository.Core.DTO;

namespace ValidUsers.API.Repository.Core.CQRS;

/// <summary>
/// The create user command.
/// </summary>

public class CreateEntityCommand<TEntity> : IRequest<TEntity> where TEntity : class, IEntity
{
    public TEntity Entity { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateEntityCommand{TEntity}"/> class.
    /// </summary>
    /// <param name="entity">The entity.</param>
    public CreateEntityCommand(TEntity entity)
    {
        Entity = entity;
    }
}
