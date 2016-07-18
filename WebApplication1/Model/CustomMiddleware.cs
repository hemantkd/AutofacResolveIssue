using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Model
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IUserService _userService;

        public CustomMiddleware(RequestDelegate next, IUserService userService)
        {
            _next = next;
            _userService = userService;
        }

        public async Task Invoke(HttpContext context)
        {
            _userService.Name = "Testing 123 name";

            await _next.Invoke(context);
        }
    }
}
