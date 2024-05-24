
using ENS_Server_Client_.Application.Authentification;
using ENS_Server_Client_.Application.Events;
using ENS_Server_Client_.Application.Events.Dto;
using Microsoft.AspNetCore.Mvc;


namespace ENS_Server_Client_.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventController(IEventService eventService, IAuthService _authService
    , CurrentUserService currentUser) : ControllerBase
{
    [HttpPost("Create")]
    public void Create(string headerToken, CreateEventRequestDTO eventRequest)
    {
        
        
        Validate(headerToken);
        eventService.Create(eventRequest);
      
    }

    [HttpPost("GetAll")]
    public List<GetAllEventDTO> GetAll( string headerToken, EventFilterDTO filter)
    {
        Validate(headerToken);
        return eventService.GetAll(filter);
    }

    private void Validate(string headerToken)
    {
      
        _authService.ValideToken(headerToken);
    }

}
