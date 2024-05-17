using ENS_Server_Client_.Application.Senders.Common;
using ENS_Server_Client_.Domain.Entities;

namespace ENS_Server_Client_.Application.Senders;

/// <summary>
/// Сервис для создания обьекта типа отправляемого ивента
/// </summary>
public interface ISenderFactory
{
    public IEventSender Create(EventType eventType);
}
