
using ENS_Server_Client_.Application.Authentification;

namespace ENS_Server_Client_.MiddleWare;

public class TokenMiddleWare(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext context, IAuthService _authService, CurrentUserService userService)
    {
        var token = context.Request.Headers["token"];
        if (!string.IsNullOrEmpty(token))
        {
            _authService.ValideToken(token);
           

            await next.Invoke(context);
        }
        else
        {
            await next.Invoke(context);
        }
    }
}
