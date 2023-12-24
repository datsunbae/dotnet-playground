using CQRS_MediatR.DataStore;
using CQRS_MediatR.Notifications;
using MediatR;

namespace CQRS_MediatR.Handlers
{
    public class HeartShotHandler : INotificationHandler<ProductAddedNotification>
    {
        private readonly FakeDataStore _fakeDataStore;
        public HeartShotHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            await _fakeDataStore.EventOccured(notification.Product, "Heart shot DN1806");
            await Task.CompletedTask;
        }
    }
}
