namespace Himsug_Final4.Server.Services
{
    public interface IEmailservice
    {
        //public void SendEmail(EmailDto request);
        public void SendEmail(Shared.Models.EmailDto request);
    }
}
