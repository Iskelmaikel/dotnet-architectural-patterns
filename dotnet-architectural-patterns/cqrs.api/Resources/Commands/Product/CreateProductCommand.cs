﻿using MediatR;

namespace cqrs.api.Resources.Commands.Product
{
    /// <summary>
    /// A Command defines which (CRUD) methods should be executed
    /// </summary>
    public class CreateProductCommand : IRequest<Models.Product>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public bool Active { get; set; } = true;
        public decimal Price { get; set; }
    }
}
