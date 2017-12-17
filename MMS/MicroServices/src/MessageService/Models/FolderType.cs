using System;
namespace MMS.MicroService.MessageService.Models
{
    public enum FolderType
    {
        Inbox,
        Outbox,
        Sent,
        Draft,
        Trash,
        Save,
        Personal
    }
}