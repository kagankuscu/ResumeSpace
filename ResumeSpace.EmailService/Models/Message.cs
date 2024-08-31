using MimeKit;

namespace ResumeSpace.EmailService;

public class Message
{
    public List<MailboxAddress> To { get; set; } = [];
    public string Subject { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;

    public Message(IEnumerable<string> to, string subject, string content)
    {
        To = [.. to.Select(x => new MailboxAddress("To", x))];
        Subject = subject;
        Content = content;
    }
}
