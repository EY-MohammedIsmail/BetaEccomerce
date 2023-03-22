using MediatR;
using Product_PCategory.Models;

namespace Product_PCategory.Commands.ProductCommands
{
    public record AddProductCommand(Product newProduct):IRequest<string>
    {
    }
}
