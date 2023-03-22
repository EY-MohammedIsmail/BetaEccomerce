using MediatR;
using Product_PCategory.Models;

namespace Product_PCategory.Commands.ProductCommands
{
    public record UpdateProductCommand(Product updateProduct):IRequest<string>
    {
    }
}
