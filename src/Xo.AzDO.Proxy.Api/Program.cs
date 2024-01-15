var builder = WebApplication.CreateBuilder(args);
builder.Services.AddXoAzDOProxyApiServices();

var app = builder.Build();

app.MapEndpoints();

app.Run();
