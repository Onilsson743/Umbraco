using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.Notifications;

namespace CritoProject.Context;

public class DataContextComposer : IComposer
{
    
    public void Compose(IUmbracoBuilder builder)
    {
       builder.AddNotificationAsyncHandler<UmbracoApplicationStartedNotification, RunDataContextMigration>();
    }
}
