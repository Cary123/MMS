using System;
namespace MMS.Micro.MessageService.Common
{
    public class ReturnResult
    {
        public string Message { get; set; }

        public Object Content { get; set; }

        public int ResultCode { get; set; }
    }
}