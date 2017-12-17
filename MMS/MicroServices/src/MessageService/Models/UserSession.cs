using System;
using System.Collections.ObjectModel;
using MMS.MicroService.MessageService.Models;

namespace MMS.MicroService.MessageService.Models
{
    public class UserSession
    {
            public Guid SessionID { get; set; }
            public string Username { get; set; }
            public SessionState State { get;set; }
            public DateTime LastUpdateTime { get; set; }
            
    }
}