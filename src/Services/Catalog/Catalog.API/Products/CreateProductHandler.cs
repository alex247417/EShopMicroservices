using BuildingBlocks.CQRS;
using Catalog.API.Models;


namespace Catalog.API.Products
{

    public record CreateProductCommad(string Name, List<string> Category, string Descripition, string ImageFile, decimal Price)
        :ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommad, CreateProductResult>
    {

        public async Task<CreateProductResult> Handle(CreateProductCommad command, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Descripition,
                ImageFile = command.ImageFile,
                Price = command.Price
            };

            return new CreateProductResult(Guid.NewGuid());
        }
    }
}

