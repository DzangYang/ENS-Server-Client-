
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
    public void Create([FromHeader(Name = "token")] string headerToken, CreateEventRequestDTO eventRequest)
    {
        Validate();
        eventService.Create(eventRequest);
      
    }

    [HttpPost("GetAll")]
    public List<GetAllEventDTO> GetAll([FromHeader(Name = "token")] string headerToken, EventFilterDTO filter)
    {
        Validate();
        return eventService.GetAll(filter);
    }

    private void Validate()
    {
        var tokenExist = HttpContext.Request.Headers.TryGetValue("token", out var token);
        if (!tokenExist) throw new Exception("Токен не найден");

        _authService.ValideToken(token);
    }

}
