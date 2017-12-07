using System;
using System.Collections.ObjectModel;
using MMS.Micro.MessageService.Models;

namespace MMS.Micro.MessageService.Models
{
    public class User
    {
            public Guid Guid { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public DateTime LastUpdateTime { get; set; }
    }
}