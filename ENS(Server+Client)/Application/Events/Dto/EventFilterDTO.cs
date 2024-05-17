
using ENS_Server_Client_.Domain.Entities;

namespace ENS_Server_Client_.Application.Events.Dto;

public class EventFilterDTO
{
    public DateTime? PostedDate { get; set; }
    public bool? IsPosted { get; set; }
    public Guid? UserId { get; set; }
    public EventType? EventType { get; set; }
}
