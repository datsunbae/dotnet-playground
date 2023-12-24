using MediatR;

namespace CQRS_MediatR.Commands
{
    public record AddProductCommand(Product Product) : IRequest<Product>;
}
