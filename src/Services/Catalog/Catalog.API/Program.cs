
var builder = WebApplication.CreateBuilder(args);

// Add Services to the contanier.

builder.Services.AddCarter();
builder.Services.AddMediatR(ConfigurationBinder =>
{
    ConfigurationBinder.RegisterServicesFromAssembly(typeof(Program).Assembly);
});
builder.Services.AddMarten(opts =>
{
    opts.Connection(builder.Configuration.GetConnectionString("Database")!);
}).UseLightweightSessions();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapCarter();
app.Run();
