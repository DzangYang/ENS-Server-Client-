using ENS_Server_Client_.Domain.Entities;

namespace ENS_Server_Client_.Application.Senders.Common;

public interface IEventSender
{
    public void Send(Event @event);
}
