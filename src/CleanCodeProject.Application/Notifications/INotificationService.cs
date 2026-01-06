namespace CleanCodeProject.Application.Notifications;

public interface INotificationService
{
    ApiResponse<bool> SendNotification();
}