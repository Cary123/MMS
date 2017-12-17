using System;
namespace MMS.MicroService.MessageService.Models
{
    public enum MessageState
    {
        Read,
        Unread,
        Scheduled,
        Expired
    }
}