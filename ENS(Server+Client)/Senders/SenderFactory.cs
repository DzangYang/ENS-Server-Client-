using ENS.Domain.Entities;
using ENS_Server_Client_.Senders.Common;
using ENS_Server_Client_.Senders.Email;
using ENS_Server_Client_.Senders.Whatsapp;

namespace ENS_Server_Client_.Senders;

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
