
using ENS_Server_Client_.Application.Authentification;
using ENS_Server_Client_.Application.Authentification.Dto;
using Microsoft.AspNetCore.Mvc;


namespace ENS_Server_Client_.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthControler(IAuthService authService) : ControllerBase
{
    [HttpPost("SignIn")]
    public void SignIn(RegistrationRequestDTO registrationRequest)
    {
        authService.SignIn(registrationRequest);

        
    }

    [HttpPost("LogIn")]
    public LoginResponceDTO Login(LoginRequestDTO loginRequest)
    {
        var loginResponce = authService.LogIn(loginRequest);

     
        return loginResponce;
    }
}
