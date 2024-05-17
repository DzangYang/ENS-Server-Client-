using ENS_Server_Client_.Domain.Entities;
using ENS_Server_Client_.Application.Senders.Common;
using ENS_Server_Client_.Application.Senders.Email;
using ENS_Server_Client_.Application.Senders.Whatsapp;

namespace ENS_Server_Client_.Application.Senders;

/// <summary>
/// Класс отвечающий за создание обьекта типа передаваемого ивента
/// </summary>
/// <param name="eventSenders">Список типов отправляемых ивентов</param>
public class SenderFactory(IEnumerable<IEventSender> eventSenders) : ISenderFactory
{
    public IEventSender Create(EventType eventType)
    {
        return eventType switch
        {
            EventType.Email => eventSenders.First(x => x is EmailSender),
            EventType.Phone => eventSenders.First(x => x is WhatsappSender),
            _ => throw new Exception()
        };
    }
}
