using CQRS_MediatR.DataStore;
using CQRS_MediatR.Notifications;
using MediatR;

namespace CQRS_MediatR.Handlers
{
    public class SendMailToCrushHandler : INotificationHandler<ProductAddedNotification>
    {
        private readonly FakeDataStore _fakeDataStore;
        public SendMailToCrushHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            await _fakeDataStore.EventOccured(notification.Product, "I love you! <3");
            await Task.CompletedTask;
        }
    }
}
