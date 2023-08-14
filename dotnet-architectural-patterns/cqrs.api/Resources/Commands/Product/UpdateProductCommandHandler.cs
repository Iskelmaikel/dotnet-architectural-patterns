using cqrs.api.DAL;
using MediatR;

namespace cqrs.api.Resources.Commands.Product
{
    /// <summary>
    /// The CommandHandler is responsible for executing the methods defined by the Command classes
    /// </summary>
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Models.Product>
    {
        private readonly CqrsContext _dbContext;

        public UpdateProductCommandHandler(CqrsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Models.Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.Id == request.Id);

            if (product is null)
                return default;

            product.Name = request.Name;
            product.Description = request.Description;
            product.Category = request.Category;
            product.Price = request.Price;

            await _dbContext.SaveChangesAsync(cancellationToken);
            return product;
        }
    }
}
