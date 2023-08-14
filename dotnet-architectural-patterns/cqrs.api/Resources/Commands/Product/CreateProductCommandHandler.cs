using cqrs.api.DAL;
using MediatR;

namespace cqrs.api.Resources.Commands.Product
{
    /// <summary>
    /// The CommandHandler is responsible for executing the methods defined by the Command classes
    /// </summary>
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Models.Product>
    {
        private readonly CqrsContext _dbContext;

        public CreateProductCommandHandler(CqrsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Models.Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Models.Product
            {
                Name = request.Name,
                Description = request.Description,
                Category = request.Category,
                Price = request.Price,
            };

            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return product;
        }
    }
}
