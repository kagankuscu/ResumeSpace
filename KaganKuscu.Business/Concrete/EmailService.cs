using KaganKuscu.Business.Abstract;
using KaganKuscu.EmailService;
using KaganKuscu.EmailService.Concrete;
using KaganKuscu.Model.Dtos.EmailDto;
using KaganKuscu.Model.Dtos.UserDto;
using MimeKit;

namespace KaganKuscu.Business.Concrete
{
    public class EmailService : IEmailService
    {
        private readonly IUserService _userService;
        private readonly IEmailSender _emailSender;

        public EmailService(IEmailSender emailSender, IUserService userService)
        {
            _emailSender = emailSender;
            _userService = userService;
        }

        public async Task<bool> SenMail(EmailForSendDto emailSend)
        {
            UserForGetDto? user = await _userService.GetUserByUsername(emailSend.Username);

            if (user is null)
                return false;

            string content = $@"Name: {emailSend.Name}
Email: {emailSend.Email}
Subject: {emailSend.Subject}

Message:
{emailSend.Message}";

            Message message = new Message (
                new string[] {user.Email!},
                $"New Contact Form - {emailSend.Subject}",
                content
            );

            await _emailSender.SendEmailAsync(message);

            return true;
        }
    }
}