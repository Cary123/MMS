using System;
using MMS.MicroService.MessageService.Models;
using MMS.MicroService.MessageService.IServices;
using MMS.MicroService.MessageService.DAL;
using MMS.MicroService.MessageService.Handler;

namespace MMS.MicroService.MessageService.Services
{
    public class MessageService : IMessageService
    {
        private MessageHandler messageHandler;

        public MessageService()
        {
            this.messageHandler = new MessageHandler();
        }

        public MessageService(MessageHandler messageHandler)
        {
            this.messageHandler = messageHandler;
        }

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

        public MailBox GetMailBoxByUserAndSynctime(string username, DateTime synctime)
        {
           return messageHandler.GetMailBoxByUserAndSynctime(username, synctime);
        }

        public void DeleteMessage(Message message)
        {
            
        }
    }
}