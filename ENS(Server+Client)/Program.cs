using ENS_Server_Client_;
using ENS_Server_Client_.Application.Authentification;
using ENS_Server_Client_.Application.Events;
using ENS_Server_Client_.Application.Senders.Common;
using ENS_Server_Client_.Application.Senders.Email;
using ENS_Server_Client_.Application.Senders.Whatsapp;
using ENS_Server_Client_.Application.Senders;
using Microsoft.EntityFrameworkCore;
using ENS_Server_Client_.MiddleWare;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection")
    ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found.");



builder.Services.AddScoped<IEventService, EventService>();
builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddScoped<CurrentUserService>();


builder.Services.Configure<EmailOptions>(builder.Configuration.GetSection("EmailOptions"));


builder.Services.AddScoped<IEventSender, WhatsappSender>();
builder.Services.AddScoped<IEventSender, EmailSender>();

builder.Services.AddScoped<ISenderFactory, SenderFactory>();


builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddHostedService<EventSendingBackGroundService>();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<TokenMiddleWare>();

app.UseAuthorization();

app.MapControllers();

app.Run();
