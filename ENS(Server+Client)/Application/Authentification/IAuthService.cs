using ENS_Server_Client_.Application.Authentification.Dto;

namespace ENS_Server_Client_.Application.Authentification;

/// <summary>
/// Сервис аутенфикации
/// </summary>
public interface IAuthService
{
    public void ValideToken(string token);
    public void SignIn(RegistrationRequestDTO registrationRequest);
    public LoginResponceDTO LogIn(LoginRequestDTO loginRequest);
}
