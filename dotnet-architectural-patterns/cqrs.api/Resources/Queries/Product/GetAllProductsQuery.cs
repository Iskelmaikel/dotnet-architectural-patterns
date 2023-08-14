using MediatR;

namespace cqrs.api.Resources.Queries.Product
{
    /// <summary>
    /// The query defines the object(s) to return
    /// </summary>
    public class GetAllProductsQuery : IRequest<IEnumerable<Models.Product>>
    {
        public int Id { get; set; }
    }
}
