using MMS.MicroService.MessageService.Models;

namespace MMS.MicroService.MessageService.IServices
{
    public interface IRegisterService
    {
        void RegisterUser(User user);
    }
}