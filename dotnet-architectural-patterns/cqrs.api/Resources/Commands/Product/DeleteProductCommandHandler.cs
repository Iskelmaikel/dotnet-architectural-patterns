using cqrs.api.DAL;
using MediatR;

namespace cqrs.api.Resources.Commands.Product
{
    /// <summary>
    /// The CommandHandler is responsible for executing the methods defined by the Command classes
    /// </summary>
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Models.Product>
    {
        private readonly CqrsContext _dbContext;

        public DeleteProductCommandHandler(CqrsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Models.Product> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.Id == request.Id);

            if (product is null)
                return default;

            _dbContext.Remove(product);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return product;
        }
    }
}
