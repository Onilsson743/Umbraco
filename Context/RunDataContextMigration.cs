using Microsoft.EntityFrameworkCore;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Notifications;


namespace CritoProject.Context;

public class RunDataContextMigration : INotificationAsyncHandler<UmbracoApplicationStartedNotification>
{
    private readonly DataContext _dataContext;

    public RunDataContextMigration(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task HandleAsync(UmbracoApplicationStartedNotification notification, CancellationToken cancellationToken)
    {
        IEnumerable<string> pendingMigrations = await _dataContext.Database.GetPendingMigrationsAsync();

        if (pendingMigrations.Any())
        {
            await _dataContext.Database.MigrateAsync();
        }
    }
}
