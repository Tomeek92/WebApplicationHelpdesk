using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace WebApplicationHelpdesk.OnlineUsers
{
    public class UserContext : IUserContext
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public UserContext(IHttpContextAccessor httpContext)
        {
            _contextAccessor = httpContext;
        }
        public OnlineUser GetOnlineUser()
        {
            var user = _contextAccessor.HttpContext?.User;
            if (user == null)
            {
                throw new InvalidOperationException("Context user is not present");
            }
            var id = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)!.Value;
            var email = user.FindFirst(c => c.Type == ClaimTypes.Email)!.Value;
            return new OnlineUser(id, email);
        }
    }
}
