using MMS.Micro.MessageService.Models;
using MMS.Micro.MessageService.IServices;
using MMS.Micro.MessageService.DAL;
namespace MMS.Micro.MessageService.Services
{
    public class MessageService : IMessageService
    {
        public void SetConfiguration(MessageConfiguration cfg)
        {

        }

        public void SendMessage(Message message)
        {

        }

        public MailBox SynchronizeMessage()
        {
            return null;
        }

        public MailBox GetMailBoxByUser(string username)
        {
           return MessageDAL.GetMailBoxByUser(username);
        }

        public void DeleteMessage(Message message)
        {
            
        }
    }
}