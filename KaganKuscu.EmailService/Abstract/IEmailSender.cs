namespace KaganKuscu.EmailService.Concrete;

public interface IEmailSender
{
    Task SendEmailAsync(Message message);
}
