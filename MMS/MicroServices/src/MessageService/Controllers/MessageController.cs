using System;
using Microsoft.AspNetCore.Mvc;
using MMS.MicroService.MessageService.Models;
using MMS.MicroService.MessageService.Common;
using MicroMessageService = MMS.MicroService.MessageService.Services.MessageService;
namespace MMS.MicroService.MessageService.Controllers
{
    [Route("mms/[controller]")]
    public class MessageController : Controller
    {
        
        // GET api/message
        [HttpGet]
        public IActionResult Get()
        {
            return Json(Guid.NewGuid().ToString()+"||"+Guid.NewGuid().ToString()+Guid.NewGuid().ToString());
        }

        // GET api/message/5
        [HttpGet("{username}/{synctime}")]
        public IActionResult Get(string username, DateTime synctime)
        {
            ReturnResult result = new ReturnResult();
            MailBox mailBox = null;
            try
            {
                mailBox = new MicroMessageService().GetMailBoxByUserAndSynctime(username,synctime);
                result.ResultCode = 1;
                result.Content = mailBox;
            }
            catch (Exception e)
            {
                result.ResultCode = 0;
                result.Message = e.ToString();
            }
            return Json(result);
        }

        // POST api/message
        [HttpPost]
        public IActionResult Post([FromBody]Message message)
        {
            if (message != null)
            {
                new MicroMessageService().SendMessage(message);
            }
            return Json("111");
        }

        [HttpPost]
        public IActionResult Post([FromBody] MessageConfiguration msgCfg)
        {
            return null;
        }

        // PUT api/message/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/message/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
