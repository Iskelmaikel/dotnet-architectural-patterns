using cqrs.api.DAL;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace cqrs.api.Resources.Queries.Product
{
    /// <summary>
    /// The QueryHandler is responsible for returning objects which are defined by the class that implements the query pattern
    /// </summary>
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Models.Product>
    {
        // Reference to the consumed context. This can be a generic context as well as a smaller specific context
        private readonly CqrsContext _context;

        // Pass a dbContext through DI
        public GetProductByIdQueryHandler(CqrsContext context)
        {
            _context = context;
        }

        public async Task<Models.Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        }
    }
}
