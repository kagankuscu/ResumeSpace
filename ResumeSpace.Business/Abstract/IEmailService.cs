using ResumeSpace.Model.Dtos.EmailDto;

namespace ResumeSpace.Business.Abstract
{
    public interface IEmailService
    {
        Task<bool> SenMail(EmailForSendDto emailSend);
    }
}