namespace ENS_Server_Client_.Application.Senders.Email;

/// <summary>
/// Настройки для отправки ивента на почту
/// </summary>
public class EmailOptions
{
    /// <summary>
    /// Хост
    /// </summary>
    public string Host { get; set; }
    /// <summary>
    /// Порт
    /// </summary>
    public int Port { get; set; }
    /// <summary>
    /// Данные почты отпрявляемого
    /// </summary>
    public string From { get; set; }
    /// <summary>
    /// Пароль от почты отправляемого
    /// </summary>
    public string Pass { get; set; }
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; }

}
