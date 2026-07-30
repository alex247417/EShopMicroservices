var builder = WebApplication.CreateBuilder(args);

// Add Services to the contanier.

builder.Services.AddCarter();
builder.Services.AddMediatR(ConfigurationBinder =>
{
    ConfigurationBinder.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapCarter();
app.Run();
