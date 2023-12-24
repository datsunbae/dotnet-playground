using MediatR;

namespace CQRS_MediatR.Queries
{
    public record GetProductByIdQuery(int id) : IRequest<Product>;
}
