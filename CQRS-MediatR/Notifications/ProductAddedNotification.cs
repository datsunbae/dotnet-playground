using MediatR;

namespace CQRS_MediatR.Notifications
{
    public record ProductAddedNotification(Product Product) : INotification;
}
