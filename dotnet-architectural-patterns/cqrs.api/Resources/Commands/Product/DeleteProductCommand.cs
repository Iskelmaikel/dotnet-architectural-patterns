using MediatR;

namespace cqrs.api.Resources.Commands.Product
{
    /// <summary>
    /// A Command defines which (CRUD) methods should be executed
    /// </summary>
    public class DeleteProductCommand : IRequest<Models.Product>
    {
        public int Id { get; set; }
    }
}
