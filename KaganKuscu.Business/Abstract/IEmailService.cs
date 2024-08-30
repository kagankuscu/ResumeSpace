using KaganKuscu.Model.Dtos.EmailDto;

namespace KaganKuscu.Business.Abstract
{
    public interface IEmailService
    {
        Task<bool> SenMail(EmailForSendDto emailSend);
    }
}