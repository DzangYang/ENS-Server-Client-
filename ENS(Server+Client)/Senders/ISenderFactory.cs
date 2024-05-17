using ENS.Domain.Entities;
using ENS_Server_Client_.Senders.Common;

namespace ENS_Server_Client_.Senders;

/// <summary>
/// Сервис для создания обьекта типа отправляемого ивента
/// </summary>
public interface ISenderFactory
{
    public IEventSender Create(EventType eventType);
}
