using MediatR;

namespace cqrs.api.Resources.Queries.Product
{
    /// <summary>
    /// The query defines the object(s) to return
    /// </summary>
    public class GetProductByIdQuery : IRequest<Models.Product>
    {
        public int Id { get; set; }
    }
}
