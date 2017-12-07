using MMS.Micro.MessageService.Models;

namespace MMS.Micro.MessageService.IServices
{
    public interface IMessageService
    {
        void SendMessage(Message message);

        MailBox GetMailBoxByUser(string username);

        void DeleteMessage(Message message);
    }
}