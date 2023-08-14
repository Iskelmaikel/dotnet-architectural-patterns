using cqrs.api.DAL;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace cqrs.api.Resources.Queries.Product
{
    /// <summary>
    /// The QueryHandler is responsible for returning objects which are defined by the class that implements the query pattern
    /// </summary>
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Models.Product>>
    {
        private readonly CqrsContext _context;

        public GetAllProductsQueryHandler(CqrsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Models.Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.ToListAsync(cancellationToken);
        }
    }
}
