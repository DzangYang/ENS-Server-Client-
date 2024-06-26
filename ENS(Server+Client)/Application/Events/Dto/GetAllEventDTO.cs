﻿
using ENS_Server_Client_.Domain.Entities;

namespace ENS_Server_Client_.Application.Events.Dto;

public class GetAllEventDTO
{
    public DateTime CreatedDate { get; set; }
    public DateTime PostedDate { get; set; }
    public List<string> Contacts { get; set; }
    public string Text { get; set; }
    public bool IsPosted { get; set; }
    public string Subject { get; set; }
    public EventType Type { get; set; }
}
