using ENS_Server_Client_.Application.Events.Dto;

namespace ENS_Server_Client_.Application.Events;
public interface IEventService
{
    void Create(CreateEventRequestDTO eventRequest);
    List<GetAllEventDTO> GetAll(EventFilterDTO filter);
    void Send(Guid id);
}
