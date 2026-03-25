var builder = WebApplication.CreateBuilder(args);

// Add Services to the contanier.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.Run();
