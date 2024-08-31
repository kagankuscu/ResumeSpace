namespace ResumeSpace.EmailService.Concrete;

public interface IEmailSender
{
    Task SendEmailAsync(Message message);
}
