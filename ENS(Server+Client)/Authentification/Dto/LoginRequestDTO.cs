namespace ENS_Server_Client_.Authentification.Dto;

/// <summary>
/// Запрос данных для автормизации
/// </summary>
public class LoginRequestDTO
{
    public string Name { get; set; }
    public string Password { get; set; }
}
