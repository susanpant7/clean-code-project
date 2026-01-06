using CleanCodeProject.Application;
using CleanCodeProject.Application.Notifications;

namespace CleanCodeProject.Infrastructure.Notifications;

public class IEmailSenderService : INotificationService
{
    public ApiResponse<bool> SendNotification()
    {
        throw new NotImplementedException();
    }
}