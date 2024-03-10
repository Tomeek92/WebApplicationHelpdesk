using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplicationHelpdesk.Models;
using WebApplicationHelpdeskDomain.Entities.Register;

namespace WebApplicationHelpdesk.Extension
{
    public static class ExtensionController 
    {
        public static void SetNotification(this Controller controller, string type,string message)
        {
            var notification = new Notification(type,message);
           controller.TempData["Notification"] = JsonConvert.SerializeObject(notification);
        }
    }
}
