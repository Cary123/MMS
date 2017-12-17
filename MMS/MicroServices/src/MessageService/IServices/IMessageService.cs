using System;
using MMS.MicroService.MessageService.Models;

namespace MMS.MicroService.MessageService.IServices
{
    public interface IMessageService
    {
        void SendMessage(Message message);

        MailBox GetMailBoxByUserAndSynctime(string username, DateTime synctime);

        void DeleteMessage(Message message);
    }
}